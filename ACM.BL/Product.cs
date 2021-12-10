namespace ACM.BL
{
    public class Product
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

    public Product Retrieve(int productId)
    {
        return new Product();
    }

    public bool Save()
    {
        return true;
    }

    public bool Validate()
    {
        bool isValid = !string.IsNullOrWhiteSpace(ProductName);
        if (CurrentPrice == null) isValid = false;
        return isValid;
    }
    
    }
}