namespace DestinyMod.Core.Loaders
{
    internal class UILoader : ModSystem
    {
        public static List<UserInterface> userInterfaces = new();

        public static List<SafeUIState> states = new();

        public static T GetState<T>() where T : SafeUIState => states.FirstOrDefault(n => n is T) as T;

        public static void AddLayer(List<GameInterfaceLayer> layers, UIState state, int index, bool visible, InterfaceScaleType scaleType)
        {
            string name = state == null ? "Unknown" : state.ToString();
            layers.Insert(index, new LegacyGameInterfaceLayer("BrickAndMortar: " + name, 
                delegate 
                {
                    if (visible)
                        state.Draw(Main.spriteBatch);

                    return true;
                }, scaleType));
        }

        public static void Reload<T>() where T : SafeUIState
        {
            int index = states.IndexOf(GetState<T>());
            states[index] = (T)Activator.CreateInstance(typeof(T), null);
            userInterfaces[index] = new UserInterface();
            userInterfaces[index].SetState(states[index]);
        }

        public override void Load()
        {
            if (Main.dedServ)
                return;

            userInterfaces ??= new List<UserInterface>();

            foreach (Type t in Mod.Code.GetTypes())
            {
                if (!t.IsAbstract && t.IsSubclassOf(typeof(SafeUIState)))
                {
                    var state = (SafeUIState)Activator.CreateInstance(t, null);
                    var userInterface = new UserInterface();
                    userInterface.SetState(state);
                    state.uInterface = userInterface;

                    states?.Add(state);
                    userInterfaces.Add(userInterface);
                }
            }

            base.Load();
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            for (int i = 0; i < states.Count; i++)
            {
                SafeUIState state = states[i];
                AddLayer(layers, state, state.InsertionIndex(layers), state.Visible, state.ScaleType);
            }

            base.ModifyInterfaceLayers(layers);
        }

        public override void Unload()
        {
            states.ForEach(n => n.Unload());
            userInterfaces = null;
            states = null;

            base.Unload();
        }

        public override void UpdateUI(GameTime gameTime)
        {
            if (Main.ingameOptionsWindow || Main.InGameUI.IsVisible)
                return;

            foreach (UserInterface eState in userInterfaces)
                if (eState?.CurrentState != null && ((SafeUIState)eState.CurrentState).Visible)
                    eState.Update(gameTime);

            base.UpdateUI(gameTime);
        }
    }
}