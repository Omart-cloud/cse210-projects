using System;

class Program
{
public class Customer
{
    public int CustomerID { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }

    public Customer(int customerID, string name, string email, string phoneNumber)
    {
        CustomerID = customerID;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}

public class Order
{
    public int OrderID { get; private set; }
    private Customer _customer;
    private List<OrderItem> _items;
    private string _orderStatus;

    public Order(int orderID, Customer customer)
    {
        OrderID = orderID;
        _customer = customer;
        _items = new List<OrderItem>();
        _orderStatus = "Pending";
    }

    public void AddItem(OrderItem item)
    {
        _items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        _items.Remove(item);
    }

    public void GetOrderDetails()
    {
        Console.WriteLine($"Order ID: {OrderID}, Customer: {_customer.Name}, Status: {_orderStatus}");
        foreach (var item in _items)
        {
            Console.WriteLine($"Item: {item.ItemName}, Quantity: {item.Quantity}, Price: {item.Price}");
        }
    }
}

public class OrderItem
{
    public int ItemID { get; private set; }
    public string ItemName { get; private set; }
    public int Quantity { get; private set; }
    public decimal Price { get; private set; }

    public OrderItem(int itemID, string itemName, int quantity, decimal price)
    {
        ItemID = itemID;
        ItemName = itemName;
        Quantity = quantity;
        Price = price;
    }
}

public class PaymentProcessor
{
    private string _paymentMethod;

    public PaymentProcessor(string paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void ProcessPayment(Order order, decimal amount)
    {
        Console.WriteLine($"Processing {_paymentMethod} payment of ${amount} for Order {order.OrderID}");
    }
}

public class DeliveryManager
{
    private string _trackingNumber;

    public void ScheduleDelivery(Order order, string address)
    {
        _trackingNumber = "TRK123456";
        Console.WriteLine($"Order {order.OrderID} scheduled for delivery to {address}. Tracking Number: {_trackingNumber}");
    }
}

}