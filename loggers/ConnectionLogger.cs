using System;
using System.IO;
using GTANetworkAPI;

namespace MyBeastSolution.Server.loggers
{
    public class ConnectionLogger
    {
        
        public void LogMessageToFile(string msg)
        {
            string path = "C:/RAGEMP/server-files/bridge/resources/MyBeastSolution/Server-Side/MyBeastSolution.Server/Logs/ConnectionLog.txt";
                System.IO.StreamWriter sw = System.IO.File.AppendText(path);
            try
            {
                string logLine = System.String.Format("{0:G}: {1}.", System.DateTime.Now, msg);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
