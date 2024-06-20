namespace SeedMeUtilities
{
    public static class ListViewHelper
    {
        public static void AddItem<T>(ListView listView, T item)
        {
            ListViewItem listViewItem = new ListViewItem(item.ToString());
            listView.Items.Add(listViewItem);
        }

        public static void AddItemWithSubItems<T>(ListView listView, T item, params string[] subItems)
        {
            ListViewItem listViewItem = new ListViewItem(item.ToString());
            foreach (var subItem in subItems)
            {
                listViewItem.SubItems.Add(subItem);
            }
            listView.Items.Add(listViewItem);
        }
    }
}
