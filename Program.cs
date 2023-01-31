using System.Linq;

namespace practiceEntity;
public class CustomerDemo
{
    public CustomerDemo()
    {
        Orders = new List<OrderDemo>();
    }
    public string CustomerId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public int OrderCount { get; set; }

    public List<OrderDemo> Orders { get; set; }
}

public class OrderDemo
{
    public int OrderId { get; set; }
    public decimal TotalAmount { get; set; }
    public List<ProductDemo> Products { get; set; }
}

public class ProductDemo
{
    public int ProductId { get; set; }
    public String Name { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        using (var context = new NorthwindContext())
        {
            var customers = context.Customers
                .Where(i => i.Orders.Count() > 15)
                .Select(i => new CustomerDemo
                {
                    CustomerId = i.CustomerId,
                    Name = i.ContactName,
                    OrderCount = i.Orders.Count(),
                    Orders = i.Orders.Select(m => new OrderDemo
                    {
                        OrderId = m.OrderId,
                        TotalAmount = (decimal)m.OrderDetails.Sum(od => od.Quantity * od.UnitPrice),
                        Products = m.OrderDetails.Select(p => new ProductDemo
                        {
                            ProductId = (int)p.ProductId,
                            Name = p.Product.ProductName
                        }).ToList(),


                    }).ToList(),
                    Title = i.ContactTitle,

                }).OrderBy(i => i.OrderCount)
                .ToList();

            foreach (var customer in customers)
            {
                Console.WriteLine($" id: {customer.CustomerId}  Name: {customer.Name} Title: {customer.Title} OrderCount: {customer.OrderCount}");
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine($"order id: {order.OrderId} Total Amount: {order.TotalAmount}");
                    foreach (var product in order.Products)
                    {
                        Console.WriteLine($"Product id: {product.ProductId} Name: {product.Name}");
                    }
                }
            }

        }


    }
}
