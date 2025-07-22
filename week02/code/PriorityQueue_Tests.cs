using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple people with different priorities.
    // Expected Result: Dequeue should return people in order of highest to lowest priority.
    //["Faith", "John", "Sam", "Alice", "Sarah"]
    // Defect(s) Found: None (assuming the test passed and itmes were dequeued correctly in priority order).
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("John", 8);
        priorityQueue.Enqueue("Alice", 2);
        priorityQueue.Enqueue("Sam", 4);
        priorityQueue.Enqueue("Faith", 23);
        priorityQueue.Enqueue("Sarah", 1);

        var result = new List<string>
        {
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
        };

        var expected = new List<string> { "Faith", "John", "Sam", "Alice", "Sarah" };

        for (int i = 0; i < expected.Count; i++)
        {
            if (result[i] != expected[i])
            {
                Assert.Fail($"Expected {expected[i]} at position {i}, but got {result[i]}");
            }
        }
    }

    [TestMethod]
    // Scenario: Dequeue from an empty priority queue.
    // Expected Result: Should throw an InvalidOperationException with the message "The queue is empty."
    // Defect(s) Found: None (assuming the exception and message were correctly thrown and matched).
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected InvalidOperationException, but no exception was thrown");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Enqueue several people with a mix of:
    // High, low, and negative priorities.
    // Duplicate names but different priorities.
    // Same priority
    // Expected Result: Dequeue should return people from highest to lowest priority, persevering order among items with the same priority.
    // ["Isabella", "Mia", "Oliver", "Elijah", "Liam", "Sophie", "Charlotte", "Oliver", "Noah", "James", "Ava"]
    // Defect(s) Found: None if test passes.
    // If it fails, possible defects could include:
    // Unstable ordering for same-priority elements.
    // Incorrect handling of negative or duplicate priorities.
    // Priorities not used properly in comparison logic.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Liam", 8);
        priorityQueue.Enqueue("Ava", -1);
        priorityQueue.Enqueue("Noah", 4);
        priorityQueue.Enqueue("Sophie", 8);
        priorityQueue.Enqueue("Oliver", 13);
        priorityQueue.Enqueue("Elijah", 9);
        priorityQueue.Enqueue("Isabella", 20);
        priorityQueue.Enqueue("Mia", 16);
        priorityQueue.Enqueue("James", 1);
        priorityQueue.Enqueue("Charlotte", 7);
        priorityQueue.Enqueue("Oliver", 5);

        var result = new List<string>
        {
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
            priorityQueue.Dequeue(),
        };

        var expected = new List<string> { "Isabella", "Mia", "Oliver", "Elijah", "Liam", "Sophie", "Charlotte", "Oliver", "Noah", "James", "Ava" };

        for (int i = 0; i < expected.Count; i++)
        {
            if (result[i] != expected[i])
            {
                Assert.Fail($"Expected {expected[i]} at position {i}, but got {result[i]}");
            }
        }
    }
}