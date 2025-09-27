public class PersonQueue
{
    // Use the built-in Queue<Person> class
    private readonly Queue<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Adds a person to the queue. O(1) operation.
    /// </summary>
    public void Enqueue(Person person)
    {
        _queue.Enqueue(person);
    }

    /// <summary>
    /// Removes and returns a person from the queue. O(1) operation.
    /// </summary>
    public Person Dequeue()
    {
        // Add a check to prevent InvalidOperationException on an empty queue
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return _queue.Dequeue();
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}
