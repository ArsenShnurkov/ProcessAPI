using System;

namespace ProcessAPI
{
	public interface IMultiprocessorScheduler
	{
		IMultiprocessorProcess CurrentProcess {get ;}
		int GetAffinity(IMultiprocessorProcess p);
		void SetAffinity(IMultiprocessorProcess p, ProcessorSet affinity);
		IMultiprocessorProcess Start(IProcessStartInfo psi);
	}
}

