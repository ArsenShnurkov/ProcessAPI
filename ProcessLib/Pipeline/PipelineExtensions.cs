using System;
using System.IO;

namespace ProcessAPI
{
	public static class PipelineExtensions
	{
		public static StreamWriter GetStandardInput (this IMulticoreProcess proc)
		{
			throw new NotImplementedException ();
		}
		public static StreamReader GetStandardOutput (this IMulticoreProcess proc)
		{
			throw new NotImplementedException ();
		}
		public static StreamReader GetStandardError (this IMulticoreProcess proc)
		{
			throw new NotImplementedException ();
		}
	}
}

