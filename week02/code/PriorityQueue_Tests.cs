using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

/*[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}*/
[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue a single item and then dequeue
    // Expected Result: The value returned matches the enqueued value
    // Defect(s) Found: If Dequeue does not return correct value, queue implementation is broken
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("A", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities
    // Expected Result: Dequeue returns the highest priority item
    // Defect(s) Found: If priority is not considered, test fails
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 10);
        priorityQueue.Enqueue("C", 1);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("B", result); // Highest priority first
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with same highest priority
    // Expected Result: Dequeue returns the first item enqueued among highest priority
    // Defect(s) Found: If FIFO not maintained for tie, test fails
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 10);
        priorityQueue.Enqueue("B", 10);
        priorityQueue.Enqueue("C", 5);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("A", result); // First enqueued among tie
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: Throws InvalidOperationException
    // Defect(s) Found: If exception not thrown, test fails
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), 
            "The queue is empty.");
    }
}
