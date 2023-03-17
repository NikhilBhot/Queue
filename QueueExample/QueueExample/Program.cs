namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come TO Queue Data Structure!");
            QueueLinkedList queueLinkedList=new QueueLinkedList();
            queueLinkedList.Enqueue(56);
            queueLinkedList.Enqueue(30);
            queueLinkedList.Enqueue(70);
            queueLinkedList.Display();
            Console.ReadKey();
        }
    }
}