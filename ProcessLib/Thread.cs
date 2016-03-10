using System;

// https://github.com/mono/mono/blob/master/mcs/class/Mono.Posix/Mono.Unix/UnixProcess.cs

// https://github.com/mono/mono/blob/master/mcs/class/System/System.Diagnostics/Process.cs

namespace ProcessAPI
{
	/// <summary>
	/// Thread works within process
	/// </summary>
	public class Thread
	{
		public static Thread Current
		{
			get
			{
				//return new UnixProcess (GetCurrentProcessId ());
				throw new NotImplementedException ();
			}
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
			if (this.Id == Thread.Current.Id) {
				throw new ArgumentException ("waiting itself is a halt");
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
		public void Stop ()
		{
			if (this.Id == Thread.Current.Id) {
				throw new NotImplementedException ();
			} else {
				throw new NotImplementedException ();
			}
			//Signal (Native.Signum.SIGKILL);
		}
	}
}
