using System;
using System.IO;
using MyJobs.Properties;

namespace MyJobs
{
    static class Log
    {
        /* Methods */
        public static void WriteLine(String s)
        {
            try
            {
                FileStream f = new FileStream(Resources.strLogFileName, FileMode.Append);
                StreamWriter log = new StreamWriter(f);
                log.WriteLine(s);
                log.Flush();
                log.Close();
                f.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AppendMessage(String s)
        {
            WriteLine(String.Format("[{0}] : \"{1}\"", DateTime.Now.ToString(), s));
        }
    }
}
