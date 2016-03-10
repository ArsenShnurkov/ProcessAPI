using System;
using ProcessAPI;

namespace Starter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var psi = new ProcessStartInfo ("/bin/bash");
			Setup.Scheduler.Start (psi);
			Console.WriteLine ("Hello World!");
		}
	}
}
