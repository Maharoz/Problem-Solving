namespace StackEasyProblems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			QueueUsingStack q = new QueueUsingStack();
			q.enQueue(1);
			q.enQueue(2);
			q.enQueue(3);

			Console.Write(q.deQueue() + " ");
			Console.Write(q.deQueue() + " ");
			Console.Write(q.deQueue());
		}
	}
}