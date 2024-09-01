using System.Linq;

namespace Jira_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
        }
        public bool SearchingANumberWithinAnint(int[] bigNum, int num)
        {

            return bigNum.Contains(num) ? true : false;
        }

    }
}
