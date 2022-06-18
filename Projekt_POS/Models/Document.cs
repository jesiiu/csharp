public class Document
{
    public int Id { get; set; }
    public string Type { get; set; }
    public DateTime InsertDate { get; set; }
    public string Description { get; set; }
    public List<Product> Products { get; set; }
    public float TotalPrice { get; set; }
    public int TotalCount { get; set; }
    public string Payment { get; set; }
}

