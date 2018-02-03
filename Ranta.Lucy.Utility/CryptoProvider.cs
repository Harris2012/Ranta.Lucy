using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Ranta.Lucy.Utility
{
	public class CryptoProvider
	{
		/// <summary>
		/// var key = Encoding.ASCII.GetBytes("FFC926A1145E4F459A419F65E665CF16").Take(32).ToArray();
		/// var iv = Encoding.ASCII.GetBytes("3E0FFBC0D17C4CBD8E7D5FC2DAFE44B8").Take(16).ToArray();
		/// var data = CryptoUtility.Encrypt(password, key, iv);
		/// </summary>
		/// <param name="password"></param>
		/// <param name="Key"></param>
		/// <param name="IV"></param>
		/// <returns></returns>
		private string Encrypt(string password, byte[] Key, byte[] IV)
		{
			#region Check Parameters
			if (string.IsNullOrEmpty(password))
			{
				throw new ArgumentNullException("password");
			}
			if (Key == null || Key.Length <= 0)
			{
				throw new ArgumentNullException("Key");
			}
			if (IV == null || IV.Length <= 0)
			{
				throw new ArgumentNullException("IV");
			}
			#endregion

			byte[] bytes;

			using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
			{
				aes.Key = Key;
				aes.IV = IV;
				ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

				using (MemoryStream msEncrypt = new MemoryStream())
				{
					using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
					{
						using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
						{
							swEncrypt.Write(password);
						}

						bytes = msEncrypt.ToArray();
					}
				}
			}

			return string.Join(string.Empty, bytes.Select(v => v.ToString("X")));
		}
	}
}
