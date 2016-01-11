using System;

namespace ProcessAPI
{
	public class Process : IMulticoreProcess
	{
		#region IMulticoreProcess implementation
		public IMulticoreScheduler MulticoreScheduler {
			get {
				return Setup.MulticoreScheduler;
			}
		}
		public IMulticoreProcess Current
		{
			get {
				return MulticoreScheduler.CurrentProcess;
			}
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
		#endregion
	}
}

