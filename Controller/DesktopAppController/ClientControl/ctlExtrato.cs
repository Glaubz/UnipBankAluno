using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClientControl
{
    public class ctlExtrato
    {

        public void Logs (string log)
        {
            if(LogsContext.Logs.Count == 0)
                for(int i = 0; i < 5; i++)
                {
                    LogsContext.Logs.Add(string.Empty);
                }

            LogsContext.Logs.Add(log);

            if (LogsContext.Logs.Count > 5)
            {
                LogsContext.Logs.RemoveAt(0);
            }
        }

        public List<string> GetLogs()
        {
            return LogsContext.Logs;
        }

    }
}
