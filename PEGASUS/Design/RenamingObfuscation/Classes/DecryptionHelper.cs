using System;
using System.Text;

namespace PEGASUS.Design.RenamingObfuscation.Classes
{
	internal static class DecryptionHelper
	{
		public static string Decrypt_Base64(string dataEnc)
		{
			try
			{
				return Encoding.UTF8.GetString(Convert.FromBase64String(dataEnc));
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
