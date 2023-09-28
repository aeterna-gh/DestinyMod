namespace DestinyMod.Core.SteamLink
{
    internal class SteamLobby
    {
        public CSteamID LobbyId;
        public CSteamID LobbyHost;

        private CallResult<LobbyCreated_t> _lobbyCreated;
        private CallResult<LobbyCreated_t>.APIDispatchDelegate _lobbyCreatedExternCallback;

        private CallResult<LobbyEnter_t> _lobbyEnter;
        private CallResult<LobbyEnter_t>.APIDispatchDelegate _LobbyEnterExternCallback;

        private List<CSteamID> _seenUsers = new();

        public SteamLobby() => _lobbyCreated = CallResult<LobbyCreated_t>.Create(new CallResult<LobbyCreated_t>.APIDispatchDelegate(OnLobbyCreated));

        public void CreateLobby(HostFireteamSettings setting, int activityLobbyLimit, CallResult<LobbyCreated_t>.APIDispatchDelegate callResult)
        {
            SteamAPICall_t newLobby;

            switch (setting)
            {
                case HostFireteamSettings.Open:
                    newLobby = SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypePublic, activityLobbyLimit);
                    break;

                case HostFireteamSettings.FriendsOnly:
                    newLobby = SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeFriendsOnly, activityLobbyLimit);
                    break;

                case HostFireteamSettings.InviteOnly:
                    newLobby = SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypePrivate, activityLobbyLimit);
                    break;

                case HostFireteamSettings.Closed:
                    newLobby = SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeInvisible, activityLobbyLimit);
                    break;

                default:
                    newLobby = SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypePublic, 3);
                    break;
            }

            _lobbyCreatedExternCallback = callResult;
            _lobbyCreated.Set(newLobby, null);
        }

        public void OpenInviteOverlay() => SteamFriends.ActivateGameOverlayInviteDialog(LobbyId);

        private void OnLobbyCreated(LobbyCreated_t result, bool fail)
        {
            LobbyId = new(result.m_ulSteamIDLobby);
            LobbyHost = SteamMatchmaking.GetLobbyOwner(LobbyId);
            _lobbyCreatedExternCallback.Invoke(result, fail);
        }

        public static void JoinLobby(HostFireteamSettings setting, CSteamID lobbyID, CSteamID host)
        {
            EFriendRelationship friend = EFriendRelationship.k_EFriendRelationshipFriend;

            if (setting is HostFireteamSettings.Open)
                SteamMatchmaking.JoinLobby(lobbyID);

            if (setting is HostFireteamSettings.FriendsOnly)
            {
                if (SteamFriends.GetFriendRelationship(host) != friend)
                    return;

                else 
                    SteamMatchmaking.JoinLobby(lobbyID);
            }

            if (setting is HostFireteamSettings.InviteOnly)
                //invite stuff here

            if (setting is HostFireteamSettings.Closed)
            {
                SteamMatchmaking.SetLobbyJoinable(lobbyID, false);
                return;
            }

            //not done yet. still needs callbacks.
        }

        public CSteamID GetUserByIndex(int index) => SteamMatchmaking.GetLobbyByIndex(index);

        public DestinyPlayer MatchUserToPlayer(int index)
        {
            CSteamID userInQuestion = GetUserByIndex(index);

            DestinyPlayer playerMatch = Main.LocalPlayer.GetModPlayer<DestinyPlayer>();

            if (playerMatch.PlayerSteamID == userInQuestion)
                return playerMatch;

            else return null;
        }

        public bool TryMatchUserToPlayer(int index, out DestinyPlayer playerMatch)
        {
            CSteamID userInQuestion = GetUserByIndex(index);

            DestinyPlayer testPlayer = Main.LocalPlayer.GetModPlayer<DestinyPlayer>();

            if (testPlayer.PlayerSteamID == userInQuestion)
            {
                playerMatch = testPlayer;
                return true;
            }

            else
            {
                playerMatch = null;
                return false;
            }
        }

        public enum HostFireteamSettings
        {
            Open,
            FriendsOnly,
            InviteOnly,
            Closed
        }

        public enum LobbyState
        {
            Inactive,
            Connecting,
            Creating,
            Active
        }
    }
}