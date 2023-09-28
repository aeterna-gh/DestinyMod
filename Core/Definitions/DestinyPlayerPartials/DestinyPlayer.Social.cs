namespace DestinyMod.Core.Definitions.DestinyPlayerPartials
{
    public partial class DestinyPlayer
    {
        public DestinyPlayer[] friendsList;

        public DestinyPlayer[] blockedPlayers;

        public CSteamID PlayerSteamID => SteamUser.GetSteamID();
    }
}