using System;

namespace ProcessAPI.Windows
{
	/// <remarks>
	/// wrapper around System.Diagnostics.Process
	/// </remarks>
	public class Process
	{
		public static Process Current
		{
			get
			{
				//return new UnixProcess (GetCurrentProcessId ());
				throw new NotImplementedException ();
			}
		}
		public static Process Start ()
		{
			throw new NotImplementedException ();
		}
		public int Id
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public bool HasStopped {
			get {
				/*int status = GetProcessStatus ();
				return Native.Syscall.WIFSTOPPED (status);*/
				throw new NotImplementedException ();
			}
		}
		public int ExitCode {
			get {
				/*if (!HasExited)
					throw new InvalidOperationException (
						Locale.GetText ("Process hasn't exited"));
				int status = GetProcessStatus ();
				return Native.Syscall.WEXITSTATUS (status);*/
				throw new NotImplementedException ();
			}
		}
		public int WaitForExit ()
		{
			if (this.Id == Process.Current.Id) {
				throw new ArgumentException ("waiting for itself is a halt");
			}
			/*
			int status;
			int r;
			do {
				r = Native.Syscall.waitpid (pid, out status, (Native.WaitOptions) 0);
			} while (UnixMarshal.ShouldRetrySyscall (r));
			UnixMarshal.ThrowExceptionForLastErrorIf (r);
			*/
			return ExitCode;
		}
		/// <remarks>
		/// this is necessary to pass Ctrl-C signal to the process
		/// </remarks>
		public void Signal (int signal)
		{
			/*int r = Native.Syscall.kill (pid, signal);
			UnixMarshal.ThrowExceptionForLastErrorIf (r);*/
			throw new NotImplementedException ();
		}
		public void Stop ()
		{
			if (this.Id == Process.Current.Id) {
				throw new NotImplementedException ();
			} else {
				throw new NotImplementedException ();
			}
			//Signal (Native.Signum.SIGKILL);
		}
	}
}
