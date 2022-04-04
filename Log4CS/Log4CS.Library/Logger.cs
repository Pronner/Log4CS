using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Log4CS.Library
{
    public class Logger
    {

        public string logPath = null; // unnecessary, just leaving it here tho
        private static string txtLog;

        public static void CreateLog(string path)
        {

            try
            {

                File.Create(path);

            }
            catch (IOException ioex)
            {

                Console.WriteLine(ioex);

            }

        }

        public static void writeLog(string whatToWrite, string path)
        {

            txtLog = txtLog + whatToWrite + Environment.NewLine;
            File.WriteAllText(path, txtLog);

        }

        public static void openLog(string path)
        {


            System.Diagnostics.Process.Start(path);


        }

    }
}
