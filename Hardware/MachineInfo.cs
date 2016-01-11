using System;

namespace ProcessAPI
{
	public class MachineInfo
	{
		public ClusterInfo Parent
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		/// <summary>
		/// CPUs, GPUs, FPGAs
		/// </summary>
		/// <returns>The processor types count.</returns>
		/// <param name="">.</param>
		public int ProcessorTypesCount
		{
			get{
				throw new NotImplementedException ();
			}
		}
		public int TotalProcessorsCount
		{
			get{
				throw new NotImplementedException ();
			}
		}
	}
}

