public class Query2
{
    public int Productid { get; set; }
    public string ProductName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public int Reviewid { get; set; }
    public int Userid { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
    public DateTime Createdat { get; set; }

}