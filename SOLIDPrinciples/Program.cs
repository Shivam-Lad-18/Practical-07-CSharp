using SOLIDPrinciples;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order() { OrderId = 396898 , CustomerEmail="example@eg.com"};
        Console.WriteLine(" Single Responsibilty Principle : \n");
        var orderProcessor = new OrderProcessor();
        orderProcessor.ProcessOrder(order);

        var receiptPrinter = new ReceiptPrinter();
        receiptPrinter.PrintReceipt(order);


        Console.WriteLine("\n\n Open Close Principle : \n");
        double totalAmount = 1000;

        // For Regular Customer
        var regularCalculator = new DiscountCalculator(new RegularCustomerDiscount());
        Console.WriteLine($"\tRegular Customer Discount: {regularCalculator.CalculateDiscount(totalAmount)}");

        // For Premium Customer
        var premiumCalculator = new DiscountCalculator(new PremiumCustomerDiscount());
        Console.WriteLine($"\tPremium Customer Discount: {premiumCalculator.CalculateDiscount(totalAmount)}");

        // Adding new customer type (Gold) - No change in existing code!
        var goldCalculator = new DiscountCalculator(new GoldCustomerDiscount());
        Console.WriteLine($"\tGold Customer Discount: {goldCalculator.CalculateDiscount(totalAmount)}");


        Console.WriteLine("\n\n Liskov Substitution Principle : \n");
        Shape rectangle = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine("\tRectangle Area: " + rectangle.GetArea()); // Output: 50

        Shape square = new Square { Side = 5 };
        Console.WriteLine("\tSquare Area: " + square.GetArea());

        Console.WriteLine("\n\n Interface Segregation Principle : \n");
        var employee = new FullTimeEmployee();
        employee.Eat();
        employee.Work();
        employee.Sleep();
        var robot = new RobotWorker();
        robot.Work();

        Console.WriteLine("\n\n Dependency Inversion Principle : \n");
        ILogger consoleLogger = new ConsoleLogger();
        Application app1 = new Application(consoleLogger);
        app1.Run(); // Logs to console

        // Using FileLogger
        ILogger fileLogger = new FileLogger();
        Application app2 = new Application(fileLogger);
        app2.Run(); // Logs to file

    }
}
