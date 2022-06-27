using PojektPOS.Extensions;
using System.ComponentModel.DataAnnotations;
public class Products
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Size { get; set; }
    public string EanCode { get; set; }
    public string ProducerCode { get; set; }
    [Range(1, int.MaxValue)]
    public int Price { get; set; }
    [Range(1, int.MaxValue)]
    public int Count { get; set; }
    public string Manufacturer { get; set; }
    public string PhotoUrl { get; set; }
}

