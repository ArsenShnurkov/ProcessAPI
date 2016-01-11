using System;

// https://github.com/mono/mono/blob/master/mcs/class/Mono.Posix/Mono.Unix/UnixProcess.cs

// https://github.com/mono/mono/blob/master/mcs/class/System/System.Diagnostics/Process.cs

// 4.6.1, https://github.com/Microsoft/referencesource/blob/master/System/services/monitoring/system/diagnosticts/Process.cs

namespace ProcessAPI
{
	public interface IMulticoreProcess
	{
		IMulticoreScheduler MulticoreScheduler { get; }
		int Id { get; }
		bool HasStopped { get; }
		int ExitCode { get; }
		int WaitForExit ();
		void Suspend ();
		void Resume ();
		void Stop ();
	}
}
