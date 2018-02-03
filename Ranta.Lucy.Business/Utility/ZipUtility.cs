using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Net.Mime;
using System.Text;

namespace Ranta.Lucy.Business
{
	public static class ZipUtility
	{
		//public FilePathResult Test()
		//{
		//	string folderPath = @"D:\TestSpace";

		//	string filePath = @"E:\ttt.zip";

		//	Package package = Package.Open(filePath, FileMode.Create);

		//	DirectoryInfo rootFolder = new DirectoryInfo(folderPath);

		//	ZipFolderToPackage(folderPath, rootFolder, package);

		//	package.Close();

		//	return File(filePath, MediaTypeNames.Application.Zip);
		//}

		public static void ZipFolder(string folderPath, string tarZipPath)
		{
			DirectoryInfo root = new DirectoryInfo(folderPath);

			Package package = Package.Open(tarZipPath, FileMode.Create);

			ZipFolderToPackage(folderPath, root, package);

			package.Close();
		}

		private static void ZipFolderToPackage(string rootFolderPath, DirectoryInfo folder, Package package)
		{
			foreach (var file in folder.GetFiles())
			{
				string relativePath = file.FullName.Replace(rootFolderPath, string.Empty).Replace("\\", "/");

				PackagePart part = package.CreatePart(new Uri(relativePath, UriKind.Relative), MediaTypeNames.Application.Zip);

				using (FileStream stream = file.OpenRead())
				{
					byte[] buffer = new byte[0x1000];
					int readed = 0;
					while ((readed = stream.Read(buffer, 0, 0x1000)) > 0)
					{
						part.GetStream().Write(buffer, 0, readed);
					}
				}
			}

			foreach (var subFolder in folder.GetDirectories())
			{
				ZipFolderToPackage(rootFolderPath, subFolder, package);
			}
		}
	}
}
