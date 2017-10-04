using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            do
            {
                double a=0, b=0, c=0;
                Console.WriteLine("Введите первый коэффицент квадратного ур-я");
                Program.try_read(ref a);

                Console.WriteLine("Введите второй коэффицент квадратного ур-я");
                Program.try_read(ref b);

                Console.WriteLine("Введите третий коэффицент квадратного ур-я");
                Program.try_read(ref c);

                double x1, x2, D;

                Console.WriteLine("Д = " + (D = b * b - 4 * a * c));

                if (D > 0)
                {
                    x1 = ((-b - Math.Sqrt(D)) / 2 / a);
                    x2 = ((-b + Math.Sqrt(D)) / 2 / a);
                    Console.WriteLine("Корни уравнения: x1 =" + x1 + " x2 =" + x2); 
                }
                else if (D == 0)
                {
                    Console.WriteLine("Дискриминант равен 0, один корень x = " + (-b / 2 / a));
                }
                else
                {
                    Console.WriteLine("Корней нет, дискриминант меньше нуля");
                }
                Console.WriteLine("Хотите решить ещё одно уравние (да/нет):");
            } while (Program.ans_to_bool() == true);
        }

        static bool ans_to_bool()
        {
            string enter = Console.ReadLine();
            if (enter == "да" || enter == "д" || enter == "yes" || enter == "y")
                return true;
            else
                return false;
        }

        static void try_read(ref double tmp)
        {
            bool error = false;
            tmp = -1;
            do
            {
                string enter = Console.ReadLine();
                try
                {
                    error = false;
                    tmp = double.Parse(enter);
                }
                catch (Exception)
                {
                    Console.WriteLine("Введен неверный коэффицент.\n Введите повторно: ");
                    error = true;
                }
            }
            while (error == true);
        } 
    }

}

