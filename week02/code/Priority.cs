public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        //Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue that will test multiple priorities 2, 3, 1, 3, two that are the same.
        // Expected Result: Tesla2, Tesla4, Tesla1, Tesla3
        Console.WriteLine("---------");
        Console.WriteLine("Test 1");
        Console.WriteLine("---------");
        priorityQueue.Enqueue("Tesla1", 2);
        priorityQueue.Enqueue("Tesla2", 3);
        priorityQueue.Enqueue("Tesla3", 1);
        priorityQueue.Enqueue("Tesla4", 3);

        for (int i = 0; i < 4; i++) {
            var item = priorityQueue.Dequeue();
            Console.WriteLine(item);
        }
        // Defect(s) Found: Dequeue method not looping through entire list with index < _queue.Count -1; Removed -1
        // Also Dequeue method isn't taking off the highest priority with a >=, removed =. Otherwise it won't work with multiple priorities that were the same 
        // When removing highest priority, have to adjust the code to state RemoveAt due to _queue being a list

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue that will run the queue to 0 and then display the error message
        // Expected Result: Porche2, Porche1, Porche3, The queue is empty
        Console.WriteLine("Test 2");
        Console.WriteLine("---------");
        priorityQueue.Enqueue("Porche1", 2);
        priorityQueue.Enqueue("Porche2", 3);
        priorityQueue.Enqueue("Porche3", 1);
                
        for (int i = 0; i < 4; i++) {
            var item = priorityQueue.Dequeue();
            Console.WriteLine(item);
        }
        // Defect(s) Found: Fixed in previous test

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue that will validate the added values will be put at the end of the queue each time
        // Expected Result: Ferrari1 (Pri:2), Ferrari2 (Pri:3), Ferrari (Pri:1)
        Console.WriteLine("Test 3");
        Console.WriteLine("---------");
        priorityQueue.Enqueue("Ferrari1", 2);
        priorityQueue.Enqueue("Ferrari2", 3);
        priorityQueue.Enqueue("Ferrari3", 1);
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: None
    }
}