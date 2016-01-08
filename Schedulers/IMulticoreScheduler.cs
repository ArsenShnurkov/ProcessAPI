using System;

namespace ProcessAPI
{
	public interface IMulticoreScheduler
	{
		IMulticoreProcess CurrentProcess {get ;}
		int GetAffinity(IMulticoreProcess p);
		void SetAffinity(IMulticoreProcess p, CoreSet affinity);
	}
}
