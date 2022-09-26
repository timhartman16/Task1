using System;
using System.Diagnostics;
using System.Runtime;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			FailProcess();
		}
		catch { }

		Console.WriteLine("Failed to fail process!");
		Console.ReadKey();
	}

	static void FailProcess()
	{
		/*Вариант 1.
		Завершаем этот процесс и возвращаем код выхода операционной системе.*/
		Environment.Exit(0);

		/*Вариант 2.
		Принудительно завершаем процесс.*/
		//process.Kill();
		//process.WaitForExit(); //Дает компоненту Process команду ожидать завершения
							   //связанного процесса в течение неограниченного времени.
	}
}
