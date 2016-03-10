using System;

// https://github.com/mono/mono/blob/master/mcs/class/Mono.Posix/Mono.Unix/UnixProcess.cs

// https://github.com/mono/mono/blob/master/mcs/class/System/System.Diagnostics/Process.cs

// 4.6.1, https://github.com/Microsoft/referencesource/blob/master/System/services/monitoring/system/diagnosticts/Process.cs

namespace ProcessAPI
{
	public class MulticoreProcess  : IMulticoreProcess
	{
		ProcessAPI.Linux.Process process;
		public MulticoreProcess(ProcessAPI.Linux.Process p)
		{
			process = p;
		}
		public int WaitForExit ()
		{
			throw new NotImplementedException ();
		}
		public void Suspend ()
		{
			throw new NotImplementedException ();
		}
		public void Resume ()
		{
			throw new NotImplementedException ();
		}
		public void Stop ()
		{
			throw new NotImplementedException ();
		}
		public IMulticoreScheduler MulticoreScheduler {
			get {
				throw new NotImplementedException ();
			}
		}
		public int Id {
			get {
				throw new NotImplementedException ();
			}
		}
		public bool HasStopped {
			get {
				throw new NotImplementedException ();
			}
		}
		public int ExitCode {
			get {
				throw new NotImplementedException ();
			}
		}
	}
}
