using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Logger
	{
		private static Logger instance;
		private string logs;

		private Logger()
		{
			logs = string.Empty;
		}

		public static Logger Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Logger();
				}
				return instance;
			}
		}

		public void LogInfo(string message)
		{
			Log("Info", message);
		}

		public void LogWarning(string message)
		{
			Log("Warning", message);
		}

		public void LogError(string message)
		{
			Log("Error", message);
		}

		private void Log(string logType, string message)
		{
			string logEntry = $"{DateTime.Now}: {logType}: {message}";
			Console.WriteLine(logEntry);
			logs += logEntry + Environment.NewLine;
		}

		public string GetLogs()
		{
			return logs;
		}
	}

}
