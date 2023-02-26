using Lekcja19;
using System.Reflection;

namespace QueueTests
{
    public class UnitTest1
    {
        [Fact]
        public void ShiftTest()
        {
            var q = new Lekcja19.Queue<int>(10);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            int[] arr = q.GetType().GetField("values", BindingFlags.NonPublic).GetValue(q) as int[];
        }
    }
}