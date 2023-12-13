using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kornyakov12
{
    public class Class
    {
        public static void Reshenie(double a, double b, out double pr, out double gip)
        {
            gip = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            pr = a + b + gip;

            gip = Math.Round(gip, 2);
            pr = Math.Round(pr, 2);
        }

        public static int Reshenie1(int a)
        {
            if (a > 999)
            {
                return (a / 100) % 10;
            }
            else throw new ArgumentException("Я не люблю такие маленькие числа, предпочитаю > 999");
        }

    }
}
