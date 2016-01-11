using System;

namespace ProcessAPI.Linux
{
	// the event "process stopped" should be added
	// to allow other code to react for it
	// and may be "process started"?
	// is it possible to create the object and then call start (in 2 actions instead of one?)
	/// <summary>
	/// http://man7.org/linux/man-pages/man2/intro.2.html
	/// http://man7.org/linux/man-pages/man2/syscalls.2.html
	/// http://stackoverflow.com/questions/10387603/p-invoke-ioctl-system-call
	/// </summary>
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
		/// <summary>
		/// we fork the current process, creating a new child process which is exactly the same as the parent process;
		/// then we do an exec system call to replace all the data from the parent process with that for the new process.
		/// </summary>
		/// <remarks>
		/// http://unix.stackexchange.com/questions/136637/why-do-we-need-to-fork-to-create-new-processes
		/// https://jineshkj.wordpress.com/2006/12/22/how-to-capture-stdin-stdout-and-stderr-of-child-program/
		/// </remarks>
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
