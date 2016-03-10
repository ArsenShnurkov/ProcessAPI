using System;

namespace ProcessAPI
{
	public class ProcessStartInfo : IProcessStartInfo
	{
		public ProcessStartInfo (string FileName)
		{
			this.FileName = FileName;
		}

		public string FileName { get ; set ; }
	}
}

