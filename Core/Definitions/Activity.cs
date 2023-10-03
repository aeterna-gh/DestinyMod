using DestinyMod.Utils;

namespace DestinyMod.Core.Definitions
{
    public abstract class Activity
    {
        public bool activityUnlocked;

        public bool isActive;

        public int activityLightLevel;

        public int lobbyLightLevel;

        public int lobbySize;

        public const int sixPlayerLobbySize = 6;

        public const int threePlayerLobbySize = 3;

        public List<DestinyPlayer> currentLobbyPlayers = new();

        internal int FireteamLightAverage()
        {
            int[] lightLevels = new int[currentLobbyPlayers.Count];
            for (int i = 0; i < lightLevels.Length; i++)
                lightLevels[i] = currentLobbyPlayers[i].lightLevel;

            int total = Mathf.Average(lightLevels);

            lightLevels = null;

            return total;
        }

        public void LaunchActivity()
        {
            isActive = true;
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