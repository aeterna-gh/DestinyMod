namespace DestinyMod.Content.GUI.Screens.Inventory
{
    internal class InventoryUIState : SafeUIState
    {
        //upon opening:
        // ---> have options at top (CHARACTER, CLAN, etc.)
        // ------> selected option = selected tab

        public override int InsertionIndex(List<GameInterfaceLayer> layers) => 1;

        public CharacterTab characterTab;

        public ClanTab clanTab;

        public CollectionsTab collectionsTab;

        public InventoryTab inventoryTab;

        public TriumphsTab triumphsTab;


    }
}