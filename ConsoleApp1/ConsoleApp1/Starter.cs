using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Starter
	{
		public void Run()
		{
			Actions actions = new Actions();
			Logger logger = Logger.Instance;

			for (int i = 0; i < 100; i++)
			{
				int randomAction = new Random().Next(1, 4);

				switch (randomAction)
				{
					case 1:
						Result result1 = actions.Method1();
						if (!result1.Status)
						{
							logger.LogError($"Действие не выполнено по причине: {result1.ErrorMessage}");
						}
						break;
					case 2:
						Result result2 = actions.Method2();
						if (!result2.Status)
						{
							logger.LogError($"Действие не выполнено по причине: {result2.ErrorMessage}");
						}
						break;
					case 3:
						Result result3 = actions.Method3();
						if (!result3.Status)
						{
							logger.LogError($"Действие не выполнено по причине: {result3.ErrorMessage}");
						}
						break;
				}
			}

			string logContent = logger.GetLogs();
			System.IO.File.WriteAllText("log.txt", logContent);
		}
	}
}
