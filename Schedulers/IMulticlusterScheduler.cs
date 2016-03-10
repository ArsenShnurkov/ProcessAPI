using System;

namespace ProcessAPI
{
	public interface IMulticlusterScheduler
	{
		IMulticlusterProcess CurrentProcess {get ;}
		int GetAffinity(IMulticlusterProcess p);
		void SetAffinity(IMulticlusterProcess p, ClusterSet affinity);
		IMulticlusterProcess Start(IProcessStartInfo psi);
	}
}

