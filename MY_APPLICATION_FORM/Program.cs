using System.Linq;

namespace MY_APPLICATION_FORM
{
	internal static class Program
	{
		private static string _sqlServerId = 
			Mbb.SoftwareUtility.GetSQLServerId;

		private static string _activeCode =
			Mbb.LockUtility.GetLicenseKeyByActiveCode(_sqlServerId);

		#region SetAcivetCode
		private static void SetAcivetCode(string activeCode)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.LicenseKey licenseKey =
					dataBaseContext.LicenseKeys
					.Where(current => string.Compare(current.Active_Code, activeCode) == 0)
					.FirstOrDefault();

				if (licenseKey == null)
				{
					licenseKey =
						new Models.LicenseKey { Active_Code = activeCode };

					dataBaseContext.LicenseKeys.Add(licenseKey);
					dataBaseContext.SaveChanges();
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"{ex.Message}");
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
		#endregion /SetAcivetCode

		private static Mbb.GetSerialNumberForm _getSerialNumberForm;
		public static Mbb.GetSerialNumberForm GetSerialNumberForm
		{
			get
			{
				if (_getSerialNumberForm == null || _getSerialNumberForm.IsDisposed == true)
				{
					_getSerialNumberForm =
						new Mbb.GetSerialNumberForm();
				}
				return _getSerialNumberForm;
			}
			set
			{
				_getSerialNumberForm = value;
			}
		}


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[System.STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

			SetAcivetCode(_activeCode);

			string validActiveCode =
				Mbb.LockUtility.GetLicenseKeyByActiveCode(_activeCode);

			string cuerrentLicenseKey =
				Mbb.LicenseSetting.LicenseCode;

			var statupForm = new Form1();

			if (string.Compare(cuerrentLicenseKey, validActiveCode) != 0)
			{
				GetSerialNumberForm.activeCodeTextBox.Text = $"{_activeCode}";
				GetSerialNumberForm.ShowDialog();
			}
			else
			{
				int timeRemaining = Mbb.LicenseSetting.RemainingExpirationDate;


				if (timeRemaining <= 0)
				{
					System.Windows.Forms.MessageBox.Show("The program is expire!");

					GetSerialNumberForm.activeCodeTextBox.Text = $"{_activeCode}";
					GetSerialNumberForm.ShowDialog();
				}
				else
				{
					System.Windows.Forms.Application.Run(statupForm);
				}

			}

			//System.Windows.Forms.Application.Run(statupForm);
		}
	}
}
