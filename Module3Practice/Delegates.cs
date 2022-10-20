using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Practice
{
    public class Delegates
    {
        public Delegates()
        {
            MyEvent += Sum;
            MyEvent += Sum;
        }

        public event Func<int, int, int> MyEvent;

        public Func<int, int, int> Func { get; set; }

        public int Sum(int x, int y) => x + y;

        public int Calc()
        {
            var list = MyEvent.GetInvocationList();

            Actions actions = new Actions();

            try
            {
                return actions.Result(list, AskNumbers());
            }
            catch (Exception)
            {
            }

            return 0;
        }

        private int[] AskNumbers()
        {
            Console.WriteLine("Write 4 numbers");
            List<int> numbers = new List<int>();

            int temp = 0;
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    temp = Convert.ToInt32(Console.ReadLine());
                    numbers.Add(temp);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return numbers.ToArray();
        }
    }
}
