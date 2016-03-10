using System;

/*
Mono.Unix.Native.Syscall.isatty
https://github.com/mono/mono/blob/3619fe9c4c88b87f95dfe7fe967d15df281fdb21/mcs/class/Mono.Posix/Mono.Unix.Native/Syscall.cs#L3904
[Obsolete] Mono.Posix.Syscall.isatty
https://github.com/mono/mono/blob/master/mcs/class/Mono.Posix/Mono.Posix/Syscall.cs#L439
*/

namespace ProcessAPI
{
	// Session contain set of process groups
	// processes can't migrate between sessions
	// https://en.wikipedia.org/wiki/Process_group
	// process groups are used for distribution of signals
	// New process images created by a call to a function of the exec family 
	// inherit the process group membership and the session membership of the old process image.
	// The system call setsid() is used to create a new session
	// containing a single (new) process group,
	// with the current process as both the session leader and the process group leader of that single process group.
	/// <summary>
	/// Sessions are identified by the process group ID of the session leader. 
	/// </summary>
	/// <remarks>
	/// POSIX prohibits the change of the process group ID of a session leader.
	/// </remarks>
	public class Session
	{
	}
}

