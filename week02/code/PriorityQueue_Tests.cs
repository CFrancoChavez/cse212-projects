using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add several items with different priorities and verify that the highest priority item is selected.
    // Expected Result: The item with the highest priority (3) must be released first
    // Defect(s) Found: The loop did not check the last element (index < _queue.Count - 1)
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("High", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Items with the same priority must follow FIFO order
    // Expected Result: "First" must leave before "Second" because it entered first (same priority)
    // Defect(s) Found: He was using >= instead of >, which caused the last one to appear instead of the first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 5);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("First", result);
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Verify that the item is removed after Dequeue
    // Expected Result: After two Dequeues, the third highest priority item must be output
    // Defect(s) Found: The element was not removed with RemoveAt()
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue());  // Prioridad 3
        Assert.AreEqual("C", priorityQueue.Dequeue());  // Prioridad 2
        Assert.AreEqual("A", priorityQueue.Dequeue());  // Prioridad 1
    }

    [TestMethod]
    // Scenario: Dequeue on empty queue should throw exception
    // Expected Result: InvalidOperationException
    // Defect(s) Found: None (this case already works correctly)
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}