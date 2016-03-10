using System;

namespace ProcessAPI
{
	public interface IMultimachineScheduler
	{
		IMultimachineProcess CurrentProcess {get ;}
		int GetAffinity(IMultimachineProcess p);
		void SetAffinity(IMultimachineProcess p, MachineSet affinity);
		IMultimachineProcess Start(IProcessStartInfo psi);
	}
}

