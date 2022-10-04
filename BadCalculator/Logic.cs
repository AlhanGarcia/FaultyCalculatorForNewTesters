using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCalculator
{
    internal class Logic
    {
        public static float compute(float num1, float num2, int count)
        {
            float ans;
            Random rand = new Random();
            return count switch
            {
                1 => (float)(num1 - num2 - num1 * 0.1 * rand.Next(-1, 4)),
                2 => num1 + num2,
                3 => num1 * num2,
                4 => num1 / num2,
                _ => 0
            };
        }
    }
}
