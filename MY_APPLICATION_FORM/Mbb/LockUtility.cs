namespace Mbb
{
	internal static class LockUtility
	{
		/// <summary>
		/// Receive the activation code and generate a license code and return it.
		/// </summary>
		/// <param name="activeCode"></param>
		/// <returns>licenseKey</returns>
		internal static string GetLicenseKeyByActiveCode(string activeCode)
		{
			string licenseKey =
				Hashing.GetSHA1(activeCode);

			licenseKey =
				licenseKey.Substring(startIndex: 0, length: 30);


			licenseKey =
				Hashing.GetMD5(licenseKey);

			licenseKey =
				licenseKey.Substring(startIndex: 0, length: 30);
				

			return licenseKey.ToString();
		}

	}
}
