using System;

namespace ProcessAPI
{
	public class DefaultMultimachineSchedulerAPI : IMultimachineScheduler
	{
		public DefaultMultimachineSchedulerAPI ()
		{
		}

		#region IMultimachineScheduler implementation

		public IMultimachineProcess Start (IProcessStartInfo psi)
		{
			throw new NotImplementedException ();
		}

		public IMultimachineProcess CurrentProcess {
			get {
				throw new NotImplementedException ();
			}
		}
		public int GetAffinity (IMultimachineProcess p)
		{
			throw new NotImplementedException ();
		}
		public void SetAffinity (IMultimachineProcess p, MachineSet affinity)
		{
			throw new NotImplementedException ();
		}
		#endregion
	}
}

