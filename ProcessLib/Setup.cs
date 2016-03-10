using System;

namespace ProcessAPI
{
	/// <summary>
	/// Reads current setup
	/// </summary>
	public class Setup
	{
		static DefaultMulticoreSchedulerAPI MulticoreSchedulerAPI = new DefaultMulticoreSchedulerAPI();
		public Setup ()
		{
		}
		public static IMulticoreScheduler Scheduler
		{
			get{
				return MulticoreSchedulerAPI;
			}
		}
		public ClusterSet AllClusters
		{
			get{
				throw new NotImplementedException ();
			}
		}
		public MachineSet AllMachines
		{
			get{
				throw new NotImplementedException ();
			}
		}
		public ProcessorSet AllProcessors
		{
			get{
				throw new NotImplementedException ();
			}
		}
		public CoreSet AllCores
		{
			get{
				throw new NotImplementedException ();
			}
		}
	}
}

