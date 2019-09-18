using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace AchaoCalculator
{
    public class Program
    {
        private static string[] s = { "+", "-", "*", "/" };
        static void Main(string[] args)
        {
            Console.WriteLine("输入题目数量：");
            int n = int.Parse(Console.ReadLine());

            Calculator(n);
            
            Console.ReadLine();
                
        }
        public static void Calculator(int n)
        {
            Random r = new Random();
            for (int j = 0; j < n; j++)
            {
                int c = r.Next(2, 4);
                int[] num = new int[10];

                for (int i = 0; i < c + 1; i++)
                {
                    num[i] = r.Next(1, 101);
                }
                string[] x = new string[c * 2 + 1];
                for (int k = 0; k < c * 2 + 1; k++)
                {
                    if (k % 2 == 0)
                    {
                        x[k] = num[k / 2].ToString();
                    }
                    else
                    {
                        x[k] = s[r.Next(0, 3)];
                    }
                }
                string finals = x[0];
                for (int z = 0; z < c * 2 + 1; z++)
                {
                    Console.Write(x[z]);
                    if (z != 0)
                    {
                        finals += x[z];
                    }
                }
                Console.WriteLine("=" + MainCal(finals));
            }
        }
        public static int MainCal(string finals)
        {
            DataTable d = new DataTable();
            
            return int.Parse(d.Compute(finals, null).ToString());
        }
    }
}
