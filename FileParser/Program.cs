using System;

namespace FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                switch (args.Length)
                {
                    case 2:
                        Controller controller = new Controller(args[0], args[1]);
                        controller.DisplayHowMuchEntracne();
                        break;

                    case 3:
                        Controller controller2 = new Controller(args[0], args[1], args[2]);
                        controller2.DisplayAllLines(); 
                        break;

                    default:
                        break;
                }



            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Вы зашли за границы массива. Уменьшите кол-во аргументов передаваемых в консоль");   
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
