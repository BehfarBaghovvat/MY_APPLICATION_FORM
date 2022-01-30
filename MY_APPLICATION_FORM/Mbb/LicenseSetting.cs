

using System.Linq;

namespace Mbb
{
	internal static class LicenseSetting
	{
		static LicenseSetting()
		{

		}

		private static string _licenseCode;
		public static string LicenseCode
		{
			get
			{
				if (_licenseCode == null)
				{
					_licenseCode = GetLicenseKey();
				}

				return _licenseCode;
			}
		}


		private static int _emainingExpirationDate;

		public static int RemainingExpirationDate
		{
			get
			{
				_emainingExpirationDate = GetRemainingExpirationDate();
				
				return _emainingExpirationDate;
			}
		}


		private static string GetLicenseKey()
		{
			string _getLicenseKey;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.LicenseKey licenseKey =
					dataBaseContext.LicenseKeys
					.FirstOrDefault();

				_getLicenseKey = licenseKey.License_Code;

				return _getLicenseKey;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"{ex.Message}");
				return null;
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}


		private static int GetRemainingExpirationDate()
		{
			int remainingExpierDate = 0;

			System.DateTime expireDate;
			System.DateTime currentDate = System.DateTime.Now;

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.LicenseKey licenseKey =
					dataBaseContext.LicenseKeys
					.FirstOrDefault();

				expireDate = System.DateTime.Parse(licenseKey.Expire_Date);

				System.TimeSpan dayDifferent = expireDate.Subtract(currentDate);

				return remainingExpierDate = int.Parse(dayDifferent.Days.ToString());

			}
			catch (System.Exception ex)
			{
				return 0;
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}


	}
}
