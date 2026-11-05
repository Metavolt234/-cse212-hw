
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Alice", 1);
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Charlie", 10);

        Assert.AreEqual("Charlie", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Alice", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Alice", 5);
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Charlie", 3);

        Assert.AreEqual("Alice", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Charlie", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod]
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 2);
        priorityQueue.Enqueue("Second", 8);

        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("First", priorityQueue.Dequeue());
    }

    [TestMethod]
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<System.InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );

        Assert.AreEqual("The queue is empty.", exception.Message);
    }

    [TestMethod]
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 3);
        priorityQueue.Enqueue("Second", 1);
        priorityQueue.Enqueue("Third", 5);

        Assert.AreEqual(
            "[First (Pri:3), Second (Pri:1), Third (Pri:5)]",
            priorityQueue.ToString()
        );
    }
}
