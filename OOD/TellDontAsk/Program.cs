using TellDontAsk;

var product1 = new Product_ViolatesTDA();
product1.Visibility = true;

if(product1.Visibility == false)
{
    Console.WriteLine("Product is Visible");
}
else
{
    Console.WriteLine("Product is hidden");
}

var product2 = new Product_Refactored(true);