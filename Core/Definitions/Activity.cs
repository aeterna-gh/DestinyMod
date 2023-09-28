using DestinyMod.Utils;

namespace DestinyMod.Core.Definitions
{
    public abstract class Activity
    {
        public bool activityUnlocked;

        public int activityLightLevel;

        public int lobbyLightLevel;

        public int lobbySize;

        public const int sixPlayerLobbySize = 6;

        public const int threePlayerLobbySize = 3;

        public List<DestinyPlayer> currentLobbyPlayers = new();

        internal void InLobbyUpdates()
        {
            lobbyLightLevel = LightAverage();
        }

        public void JoinLobby(DestinyPlayer player) 
        {
            if (currentLobbyPlayers.Count >= lobbySize)
                RejectPlayer();



            OnJoinLobby();
        }

        public int LightAverage()
        {
            int[] lightLevels = new int[currentLobbyPlayers.Count];
            for (int i = 0; i < lightLevels.Length; i++)
                lightLevels[i] = currentLobbyPlayers[i].lightLevel;

            int total = Mathf.Average(lightLevels);

            lightLevels = null;

            return total;
        }

        public void WhileActive()
        {

        }

        public void RejectPlayer()
        {

        }

        public virtual void OnJoinLobby() { }
    }
}