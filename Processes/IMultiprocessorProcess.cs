using System;

// https://github.com/mono/mono/blob/master/mcs/class/Mono.Posix/Mono.Unix/UnixProcess.cs

// https://github.com/mono/mono/blob/master/mcs/class/System/System.Diagnostics/Process.cs

namespace ProcessAPI
{
	/// <summary>
	/// abstracts both Linux and Windows processes
	/// </summary>
	/// <remarks>
	/// process works on some machine in some cluster (is started by some service?)
	/// </remarks>
	public interface IMultiprocessorProcess : IMulticoreProcess
	{
		IMultiprocessorScheduler MultiprocessorScheduler { get; }
	}
}
