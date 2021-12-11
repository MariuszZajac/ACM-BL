using Acme.Common;

namespace ACM.BL
{
    public class Product:EntityBase, ILoggable
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

    private string _productName;
    public string ProductName
    {
        get => _productName.InsertSpaces();
        set => _productName = value;
    }
    public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
    public override string ToString() => ProductName;
   
    public override bool Validate()
    {
        bool isValid = !string.IsNullOrWhiteSpace(ProductName);
        if (CurrentPrice == null) isValid = false;
        return isValid;
    }
    
    }
}