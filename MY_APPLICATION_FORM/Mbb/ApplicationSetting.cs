

namespace Mbb
{
	internal static class ApplicationSetting
	{
		static ApplicationSetting()
		{
		
		}

		private static string _licenseKey;

		internal static string LicenseKey
		{
			get
			{
				if (_licenseKey == null)
				{
					_licenseKey =
						System.Configuration.ConfigurationManager.AppSettings["LicenseKey"];
				}
				return _licenseKey;
			}


		}


	}
}
