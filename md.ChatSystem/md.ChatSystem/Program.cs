using System;

namespace Md.ChatSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            if(args.Length == 0)
            {
                Console.WriteLine("Running GUI client...");
                //TODO add launch of graphical client
                return;
            }
            else
            {

            }

            #region EndMsg
            Console.WriteLine("Press any key to end execution...");
            Console.ReadKey();
            #endregion
        }
    }
}
