using System;

namespace ProcessAPI
{
	public class DefaultMultiprocessorSchedulerAPI : IMultiprocessorScheduler
	{
		public DefaultMultiprocessorSchedulerAPI ()
		{
		}

		#region IMultiprocessorScheduler implementation

		public IMultiprocessorProcess CurrentProcess {
			get {
				throw new NotImplementedException ();
			}
		}
		public int GetAffinity (IMultiprocessorProcess p)
		{
			throw new NotImplementedException ();
		}
		public void SetAffinity (IMultiprocessorProcess p, ProcessorSet affinity)
		{
			throw new NotImplementedException ();
		}
		#endregion
	}
}

