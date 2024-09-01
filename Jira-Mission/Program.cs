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
        public void bubalSort(int[] bigNum)
        {
            for (int i = 0; i < bigNum.Length-1; i++)
            {
                for (int j = 0; j < bigNum.Length-1 -i; j++)
                {
                    bool isSorted = true;
                    if (bigNum[j] > bigNum[j+1])
                    {
                        int temp = bigNum[j];
                        bigNum[j] = bigNum[j+1];
                        bigNum[j+1] = temp;
                        isSorted = false;
                    }
                    if (isSorted)
                        break;

                }
            }
        }
        public void SelectionSort(int[] bigNum)
        {
            for(int i = 0;i < bigNum.Length-1;i++)
            {
                int temp = bigNum[i];
                for(int j = i+1;j < bigNum.Length-1 -1;j++)
                {
                    if (bigNum[j] < temp)
                    {
                        temp = bigNum[j];
                        bigNum[j] = bigNum[i];
                    }
                }
                bigNum[i] = temp;
            }
        }

    }
}
