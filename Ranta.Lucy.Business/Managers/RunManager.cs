using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranta.Lucy.Business.Managers
{
	public class RunManager
	{
		private void ZipFolder(string folderPath, string targetZipPath)
		{
			ZipUtility.ZipFolder(folderPath, targetZipPath);
		}
	}
}
