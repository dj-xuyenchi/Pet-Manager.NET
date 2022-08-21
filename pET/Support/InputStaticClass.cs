using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pET.Support
{
    internal class InputStaticClass
    {
        public static string stringReturn(string mes,string err,int maxRang=50,int minRang = 5)
        {
            string ret;
            bool validate = true;
            Console.WriteLine(mes);
            do
            {
                ret = Console.ReadLine();
                validate = ret.Length < minRang && ret.Length > maxRang ? true : false;
                if (!validate)
                {
                    Console.WriteLine(err);
                }
            }while(!validate);
            return ret;
        }
        public static int intReturn(string mes, string err, int maxRang = 50, int minRang = 1)
        {
            int ret;
            bool validate = true;
            Console.WriteLine(mes);
            do
            {
                validate = int.TryParse(Console.ReadLine(),out ret);
                validate = validate&& ret < minRang && ret > maxRang ? true : false;
                if (!validate)
                {
                    Console.WriteLine(err);
                }
            } while (!validate);
            return ret;
        }
    }
}
