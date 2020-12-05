namespace OOPDesignPattern.Model.Models
{
    public interface IProduct
    {
        string Description { get; set; }
        int Id { get; set; }
        string Image { get; set; }
        double Price { get; set; }
        string Title { get; set; }
    }
}