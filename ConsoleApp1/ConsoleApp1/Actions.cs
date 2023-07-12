using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Actions
	{
		public Result Method1()
		{
			Logger.Instance.LogInfo("Метод запуска: Method1");
			return new Result { Status = true };
		}

		public Result Method2()
		{
			Logger.Instance.LogWarning("Пропущена логіка в методі: Method2");
			return new Result { Status = true };
		}

		public Result Method3()
		{
			Logger.Instance.LogError("Я нарушил логику");
			return new Result { Status = false, ErrorMessage = "Я нарушил логику" };
		}
	}
}
