public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    public string Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;

        // BUG FIX: The loop was not checking the last item.
        // The condition should be '< _queue.Count'
        for (int index = 1; index < _queue.Count; index++)
        {
            // The priority item should have higher priority, not greater than or equal
            // to preserve insertion order for items with equal priority.
            if (_queue[index].Priority > _queue[highPriorityIndex].Priority)
            {
                highPriorityIndex = index;
            }
        }

        // Retrieve the value before removing the item
        var value = _queue[highPriorityIndex].Value;

        // BUG FIX: The item with the highest priority is now removed.
        _queue.RemoveAt(highPriorityIndex);

        return value;
    }

    // DO NOT MODIFY THE CODE IN THIS METHOD
    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    // DO NOT MODIFY THE CODE IN THIS METHOD
    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}
