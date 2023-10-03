using DestinyMod.Core.SteamLink;

namespace DestinyMod.Core.Definitions.DestinyPlayerPartials
{
    public partial class DestinyPlayer
    {
        public DestinyPlayer[] friendsList;

        public DestinyPlayer[] blockedPlayers;

        public Fireteam playerFireteam;

        public CSteamID PlayerSteamID => SteamUser.GetSteamID();

        public void OnJoinFireteam() { }

        public void JoinFireteam(Fireteam toJoin) { }

        public void OnRecieveJoinRequest()
        {
            
        }

        public void LeaveFireteam() { }
    }

    public enum FireteamSettings
    {
        Open,
        FriendsOnly,
        InviteOnly,
        Closed
    }

    public struct Fireteam
    {
        public SteamLobby attachedLobby;

        public List<CSteamID> currentPlayers;

        public Fireteam()
        {

        }
    }
}