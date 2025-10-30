namespace MauiERP.UI.Models
{
    public class ItemDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Dictionary<string, string> Properties { get; set; }
    }
}
