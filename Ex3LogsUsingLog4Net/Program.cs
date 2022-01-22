using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3LogsUsingLog4Net
{
    internal class Program
    {




        private static readonly log4net.ILog Log =
       log4net.LogManager.GetLogger (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {

            try
            {
                Log.Info("This is the start of DoWork");
                DoWork();
                Log.Info("This is the end of DoWork");
            }
            catch (Exception ex)
            {
                Log.Error("You app has encountred an exception");
                Log.Error(ex.Message);
            }

        }

        private static void DoWork()
        {
            Console.WriteLine("This is DoWork method");
            throw new Exception("This is a man made exception");
        }
    }
}
