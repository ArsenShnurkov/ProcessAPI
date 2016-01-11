using System;

namespace ProcessAPI
{
	public enum MulticorePriority : int {}
	public enum MultiprocessorPriority : int {}
	public enum MultimachinePriority : int {}
	public enum MulticlusterPriority : int {}

	public static class PriorityExtensionClass
	{
		public static void SetPriority (this IMulticoreProcess process, MulticorePriority priority)
		{
			throw new NotImplementedException();
		}
		public static MulticorePriority GetPriority (this IMulticoreProcess process)
		{
			throw new NotImplementedException();
		}

		public static void SetPriority (this IMultiprocessorProcess process, MultiprocessorPriority priority)
		{
			throw new NotImplementedException();
		}
		public static MultiprocessorPriority GetPriority (this IMultiprocessorProcess process)
		{
			throw new NotImplementedException();
		}

		public static void SetPriority (this IMultimachineProcess process, MultimachinePriority priority)
		{
			throw new NotImplementedException();
		}
		public static MultimachinePriority GetPriority (this IMultimachineProcess process)
		{
			throw new NotImplementedException();
		}

		public static void SetPriority (this IMulticlusterProcess process, MulticlusterPriority priority)
		{
			throw new NotImplementedException();
		}
		public static MulticlusterPriority GetPriority (this IMulticlusterProcess process)
		{
			throw new NotImplementedException();
		}
	}
}

