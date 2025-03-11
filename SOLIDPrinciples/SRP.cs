namespace SOLIDPrinciples
{
    // Order class for creating order object
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerEmail { get; set; }
    }
    // Craeting different class for different responsibilty 
    // OrderProcessor class to process order
    public class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"\tYour order with order ID :{order.OrderId} is processing ....");
            // Logic to process order
            Console.WriteLine("\tOrder processed.\n");
        }
    }
    // ReceiptPrinter class to print receipt
    public class ReceiptPrinter
    {
        public void PrintReceipt(Order order)
        {
            Console.WriteLine("\tYour order receipt : ");
            Console.WriteLine($"\tOrder ID : {order.OrderId}");
            Console.WriteLine($"\tCustomer Email : {order.CustomerEmail}");

            // Logic to print receipt
            Console.WriteLine("\tReceipt printed.");
        }
    }
}
