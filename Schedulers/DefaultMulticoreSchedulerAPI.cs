using System;

namespace ProcessAPI
{
	public class DefaultMulticoreSchedulerAPI : IMulticoreScheduler
	{
		public DefaultMulticoreSchedulerAPI ()
		{
		}

		#region IMulticoreScheduler implementation
		public IMulticoreProcess CurrentProcess {
			get {
				throw new NotImplementedException ();
			}
		}
		public int GetAffinity (IMulticoreProcess p)
		{
			throw new NotImplementedException ();
		}
		public void SetAffinity (IMulticoreProcess p, CoreSet affinity)
		{
			throw new NotImplementedException ();
		}
		#endregion
	}
}

