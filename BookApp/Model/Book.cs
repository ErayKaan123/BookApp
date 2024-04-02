namespace BookApp.Model;

public class Book
{
    public string Id = Guid.NewGuid().ToString();
    public string Title { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public string Image { get; set; }
    public string Url { get; set; }
}