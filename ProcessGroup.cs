using System;
using System.Collections.Generic;

namespace ProcessAPI
{
	/// <remarks>
	/// http://stackoverflow.com/questions/21692193/why-not-inherit-from-listt
	/// </remarks>
	public class ProcessCollection : List<Thread>
	{
	}
	/// <summary>
	/// Process groups are identified by a positive integer, 
	/// the process group ID, which is the process identifier 
	/// of the process that is (or was) the process group leader.
	/// Process groups need not necessarily have leaders,
	/// although they always begin with one.
	/// </summary>
	/// <remarks>
	/// The system call setpgid() is used to set the process group ID of a process, 
	/// thereby either joining the process to an existing process group, 
	/// or creating a new process group within the session of the process with the process becoming the process group leader
	/// of the newly created group.
	/// <br />
	/// http://stackoverflow.com/questions/27523451/why-group-leader-cannnot-able-create-the-session-in-linux
	/// </remarks>
	public class ProcessGroup : List<Thread>
	{
	}
}
