
namespace PuRIM
{
    class Product
    {
       // The products identifier 
       public string Name { get; set; }
       // The products price
       public double Value { get; set; }
       // The ammount of product we have stocked
       public int AmmountInStock { get; set; }
       public dynamic ProductType { get; set; }
    }
}
