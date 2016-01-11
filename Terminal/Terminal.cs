﻿using System;

/*
Mono.Unix.Native.Syscall.isatty
https://github.com/mono/mono/blob/3619fe9c4c88b87f95dfe7fe967d15df281fdb21/mcs/class/Mono.Posix/Mono.Unix.Native/Syscall.cs#L3904
[Obsolete] Mono.Posix.Syscall.isatty
https://github.com/mono/mono/blob/master/mcs/class/Mono.Posix/Mono.Posix/Syscall.cs#L439
*/

namespace ProcessAPI
{
	// how terminal sessions and process groups are related?
	// The tty device driver incorporates a notion of a foreground process group,
	// to which it sends the SIGTSTP, SIGQUIT, and SIGINT signals generated by keyboard interrupts.
	/// <remarks>
	/// if we require all members of a process group to share the same controlling terminal,
	/// we also should require them to be members of the same session.
	/// </remarks>
	public class Terminal
	{
		ProcessCollection Foreground_Process_Group;
	}
}

