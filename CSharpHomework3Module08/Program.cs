using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework3Module08
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            MyIndexer i1 = new MyIndexer(size);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine( $"Enter double value for {i} index");
                string result = Console.ReadLine();
                bool tryParse = double.TryParse(result, out double intResult);
                try
                {
                    if (tryParse == false)
                    {
                        throw new Exception("Value must be double number!");
                    }
                    else i1[i] = intResult;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    Environment.Exit(0);
                }

            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Result for {i} index is {i1[i]}");
            }
            Console.ReadLine();
        }
    }
}
