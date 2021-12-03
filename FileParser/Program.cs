using System;

namespace FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Controller controller = new Controller(Environment.CurrentDirectory + @"\txtfiles\1.txt", "2");
                //Controller controller = new Controller(args[0], args[1]);
                Controller controller2 = new Controller(args[0], args[1], args[2]);
                controller.DisplayHowMuchEntracne();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
    }
}
