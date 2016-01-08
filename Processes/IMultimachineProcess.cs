using System;

// https://github.com/mono/mono/blob/master/mcs/class/Mono.Posix/Mono.Unix/UnixProcess.cs

// https://github.com/mono/mono/blob/master/mcs/class/System/System.Diagnostics/Process.cs

namespace ProcessAPI
{
	/// <summary>
	/// Group of processes on some machine?
	/// </remarks>
	public interface IMultimachineProcess : IMultiprocessorProcess
	{
		IMultimachineScheduler MultimachineScheduler { get; }
	}
}
