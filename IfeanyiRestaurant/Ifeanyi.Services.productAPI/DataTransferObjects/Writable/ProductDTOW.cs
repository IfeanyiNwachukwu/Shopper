namespace Ifeanyi.Services.productAPI.DataTransferObjects.Writable
{
    public class ProductDTOW
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public string? CategoryName { get; set; }
        public string? ImageUrl { get; set; }
    }
}
