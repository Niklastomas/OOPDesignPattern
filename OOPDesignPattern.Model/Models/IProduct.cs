namespace OOPDesignPattern.Model.Models
{
    public interface IProduct
    {
        int Quantity { get; set; }
        int Id { get; set; }
        string Image { get; set; }
        double Price { get; set; }
        string Title { get; set; }
    }
}