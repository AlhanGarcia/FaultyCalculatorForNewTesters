using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCalculator
{
    public class Logic
    {
        public static float compute(float num1, float num2, int count)
        {
            float ans = 0;
            Random rand = new Random();
            if (count == 1)
            {
                ans = (float)(num1 - num2 - num1 * 0.1 * rand.Next(-1, 4));
            }
            else if(count == 2)
            {
                ans = num1 + num2;
            }
            else if (count == 3)
            {
                ans = num1 * num2;
            }
            else if (count == 4)
            {
                ans = num1 / num2;
            }
            return ans;
            
        }
    }
}
