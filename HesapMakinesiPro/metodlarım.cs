using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesiPro
{
    public class metodlarım
    {
        public static void fibonacciMethod(int adım)
        {
            List<int> fibonacci = new List<int>();
            fibonacci.Add(0);
            fibonacci.Add(1);
            for (int i = 0; i <= (adım-2); i++)
            {
                fibonacci.Add( fibonacci[i] + fibonacci[i + 1]);
            }
            foreach (int sayi in fibonacci)
            {
                MessageBox.Show(sayi.ToString());
            }
        }




    }
}
