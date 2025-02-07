using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating Customers
        Customer customer1 = new Customer(1, "Mary Omotoso", "maryomotoso@umail.com", "09059039114", new Address("12 Lagos Street", "Lagos", "Lagos State", "100001"));
        Customer customer2 = new Customer(2, "Taiwo Omotoso", "taiwoomotoso@hotmail.com", "08142350630", new Address("45 Abuja Crescent", "Abuja", "FCT", "900001"));

        // Creating Orders
        Order order1 = new Order(101, customer1);
        Order order2 = new Order(102, customer2);

        // Adding Items to Orders
        order1.AddItem(new OrderItem(1, "Laptop", 1, 450000.00m));
        order1.AddItem(new OrderItem(2, "Wireless Mouse", 2, 15000.00m));
        
        order2.AddItem(new OrderItem(3, "Smartphone", 1, 300000.00m));
        order2.AddItem(new OrderItem(4, "Power Bank", 1, 20000.00m));

        // Processing Payments
        PaymentProcessor payment1 = new PaymentProcessor("Bank Transfer");
        payment1.ProcessPayment(order1, order1.CalculateTotal());

        PaymentProcessor payment2 = new PaymentProcessor("Mobile Money");
        payment2.ProcessPayment(order2, order2.CalculateTotal());

        // Scheduling Delivery
        DeliveryManager delivery1 = new DeliveryManager();
        delivery1.ScheduleDelivery(order1, customer1.Address.FullAddress());

        DeliveryManager delivery2 = new DeliveryManager();
        delivery2.ScheduleDelivery(order2, customer2.Address.FullAddress());

        // Displaying Order Details
        order1.GetOrderDetails();
        order2.GetOrderDetails();
    }
}

public class Customer
{
    public int CustomerID { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    public Address Address { get; private set; }

    public Customer(int customerID, string name, string email, string phoneNumber, Address address)
    {
        CustomerID = customerID;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
    }
}

public class Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string ZipCode { get; private set; }

    public Address(string street, string city, string state, string zipCode)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public string FullAddress()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
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

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var item in _items)
        {
            total += item.Price * item.Quantity;
        }
        return total;
    }

    public void GetOrderDetails()
    {
        Console.WriteLine($"\nOrder ID: {OrderID}, Customer: {_customer.Name}, Status: {_orderStatus}");
        Console.WriteLine($"Shipping Address: {_customer.Address.FullAddress()}");
        Console.WriteLine("Items:");
        foreach (var item in _items)
        {
            Console.WriteLine($"- {item.ItemName}: {item.Quantity} x ₦{item.Price}");
        }
        Console.WriteLine($"Total Cost: ₦{CalculateTotal()}");
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
        Console.WriteLine($"Processing {_paymentMethod} payment of ₦{amount} for Order {order.OrderID}");
    }
}

public class DeliveryManager
{
    private string _trackingNumber;

    public void ScheduleDelivery(Order order, string address)
    {
        _trackingNumber = "TRKNG12345";
        Console.WriteLine($"Order {order.OrderID} scheduled for delivery to {address}. Tracking Number: {_trackingNumber}");
    }
}
