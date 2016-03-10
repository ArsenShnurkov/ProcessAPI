using System;

namespace ProcessAPI
{
	public class DefaultMulticlusterSchedulerAPI : IMulticlusterScheduler
	{
		public DefaultMulticlusterSchedulerAPI ()
		{
		}

		#region IMulticlusterScheduler implementation

		public IMulticlusterProcess Start (IProcessStartInfo psi)
		{
			throw new NotImplementedException ();
		}

		public IMulticlusterProcess CurrentProcess {
			get {
				throw new NotImplementedException ();
			}
		}

		public int GetAffinity (IMulticlusterProcess p)
		{
			throw new NotImplementedException ();
		}

		public void SetAffinity (IMulticlusterProcess p, ClusterSet affinity)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

