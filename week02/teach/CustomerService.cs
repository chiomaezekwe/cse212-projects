/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");

        /* I added these lines 18 - 21 */
        var cs1 = new CustomerService(0);
        Console.WriteLine(cs1);
        Console.WriteLine("=================");

        // Defect(s) Found:

        Console.WriteLine("=================");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        /* I added these lines 32 - 38 */
        var cs2 = new CustomerService(2);
        cs2.AddTestCustomer("Alex", "A1", "Login issue");
        cs2.AddTestCustomer("Bisi", "B1", "Payment issue");
        cs2.AddTestCustomer("Chioma", "C1", "Account locked"); 
        Console.WriteLine(cs2);
        Console.WriteLine("=================");

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below

        /* I added these lines 46 - 69 */
        // Test 3
        // Scenario: Serve a customer from queue
        // Expected Result: First customer is displayed and removed
        Console.WriteLine("Test 3");
        cs2.ServeCustomer();
        Console.WriteLine(cs2);
        Console.WriteLine("=================");

        // Test 4
        // Scenario: Serve remaining customer
        // Expected Result: Customer served, queue becomes empty
        Console.WriteLine("Test 4");
        cs2.ServeCustomer();
        Console.WriteLine(cs2);
        Console.WriteLine("=================");

        // Test 5
        // Scenario: Serve customer from empty queue
        // Expected Result: Error message displayed
        Console.WriteLine("Test 5");
        cs2.ServeCustomer();
        Console.WriteLine("=================");
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count > _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }


    /* I added these lines 125 - 137 */
    /// <summary>
    /// Helper method for automated testing (no user input)
    /// </summary>
    private void AddTestCustomer(string name, string accountId, string problem) {
        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        /*I added thses lines 143 - 147, and 149 */
        if (_queue.Count == 0) {
            Console.WriteLine("No customers in queue.");
            return;
        }

        var customer = _queue[0];
        _queue.RemoveAt(0);
        //var customer = _queue[0];
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}