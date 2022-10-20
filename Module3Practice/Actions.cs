using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Practice
{
    public class Actions
    {
        public int Res { get; private set; } = 0;

        public int Result(Delegate[] list, int[] numbers)
        {
            try
            {
                int i = 0;
                int j = 1;
                Res = 0;

                foreach (var method in list)
                {
                    Res += Convert.ToInt32(method.DynamicInvoke(numbers[i], numbers[j]));
                    i += 2;
                    j += 2;
                }

                return Res;
            }
            catch (Exception)
            {
                Console.WriteLine("func was null");
            }

            return 0;
        }
    }
}
