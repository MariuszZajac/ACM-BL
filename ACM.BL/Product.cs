namespace ACM.BL
{
    public class Product:EntityBase
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }
    public decimal? CurrentPrice { get; set; }
    public string ProductDescription { get; set; }
    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public override string ToString() => ProductName;
   
    public override bool Validate()
    {
        bool isValid = !string.IsNullOrWhiteSpace(ProductName);
        if (CurrentPrice == null) isValid = false;
        return isValid;
    }
    
    }
}