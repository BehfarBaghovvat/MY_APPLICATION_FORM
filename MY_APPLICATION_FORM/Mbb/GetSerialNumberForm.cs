using System;
using System.Linq;

namespace Mbb
{
	public partial class GetSerialNumberForm : System.Windows.Forms.Form
	{
		//----------------------------- Fields - Properites - Layers

		public class InformationLicense
		{
			public string Acitve_Code
			{
				get; set;
			}

			public string License_Key
			{
				get; set;
			}

			public System.DateTime Expire_Date
			{
				get; set;
			}

			public System.TimeSpan Day_Remaining
			{
				get; set;
			}
		}

		private string _licenseCode;
		private string _activeCode;
		private string _licenseKey;
		private string _expireDate;

		private InformationLicense _informationLicense;
		public InformationLicense Information_License
		{
			get
			{
				if (_informationLicense == null)
				{
					_informationLicense =
						new InformationLicense();
				}
				return _informationLicense;
			}
			set
			{
				_informationLicense = value;
			}
		}

		public bool PasteClick { get; set; }

		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
		//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


		//----------------------------- Constructor

		public GetSerialNumberForm()
		{
			InitializeComponent();
		}

		//----------------------------- Events Control

		private void GetSerialNumberForm_Load(object sender, System.EventArgs e)
		{
			PasteClick = false;
			notificationTimer.Start();
		}

		private void GetSerialNumberForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void MinimizedButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}

		private void CopyButton_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(activeCodeTextBox.Text))
			{
				return;
			}
			else
			{
				System.Windows.Forms.Clipboard.SetText(activeCodeTextBox.Text);
			}
		}

		private void PasteButton_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(System.Windows.Forms.Clipboard.GetText()))
			{
				PasteClick = false;
			}
			else
			{
				PasteClick = true;

				inputSerialNumberTextBox.Text = GetLicenseKeyAndExpireDate().License_Key;
				Information_License.Expire_Date = GetLicenseKeyAndExpireDate().Expire_Date;

				System.Windows.Forms.MessageBox.Show($"Expire Date: {GetLicenseKeyAndExpireDate().Expire_Date.ToShortDateString()} Time Left: {GetLicenseKeyAndExpireDate().Day_Remaining.Days + 1}");
			}
		}

		private void ActiveCodeTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Information_License.Acitve_Code = activeCodeTextBox.Text;
		}

		private void InputSerialNumberTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Information_License.License_Key = inputSerialNumberTextBox.Text;
		}

		private void AddKeyButton_Click(object sender, System.EventArgs e)
		{
			SetLicenseCode(Information_License);
            
            if (System.Windows.Forms.MessageBox.Show
				("Reset Program?",
				"info",
				System.Windows.Forms.MessageBoxButtons.YesNo,
				System.Windows.Forms.MessageBoxIcon.Information,
				System.Windows.Forms.MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
				System.Windows.Forms.Application.Restart();
			}
            else
            {
				return;
            }
            
		}

		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			if (messgeLabel.Visible)
			{
				messgeLabel.Visible = false;
			}
			else
			{
				messgeLabel.Visible = true;
			}
		}




		//----------------------------- Methods

		private void SetLicenseCode(InformationLicense infoLicense)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.LicenseKey licenseKey =
					dataBaseContext.LicenseKeys
					.Where(current => string.Compare(current.Active_Code, infoLicense.Acitve_Code) == 0)
					.FirstOrDefault();

				if (licenseKey != null)
				{
					if (!PasteClick)
					{
						licenseKey.License_Code = infoLicense.License_Key;
						licenseKey.Expire_Date = string.Empty;
					}
					else
					{
						licenseKey.License_Code = infoLicense.License_Key;
						licenseKey.Expire_Date = infoLicense.Expire_Date.ToShortDateString();
					}
				}

				dataBaseContext.SaveChanges();

				messgeLabel.Text = "License key registered";
				messgeLabel.ForeColor = System.Drawing.Color.LimeGreen;
				notificationTimer.Stop();

				checkPictureBox.Visible = true;
			}
			catch (System.Exception ex)
			{
				checkPictureBox.Visible = false;

				messgeLabel.Text = "License key registered";

				notificationTimer.Start();

				messgeLabel.ForeColor = System.Drawing.Color.Tomato;

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

		private InformationLicense GetLicenseKeyAndExpireDate()
		{
			InformationLicense informationLicense = new InformationLicense();

			informationLicense.License_Key =
				System.Windows.Forms.Clipboard.GetText();

			informationLicense.Expire_Date =
				System.DateTime.Parse(informationLicense.License_Key.Substring((informationLicense.License_Key.Length - 10), 10));

			informationLicense.License_Key =
				informationLicense.License_Key.Substring(0, (informationLicense.License_Key.Length - 13));

			System.DateTime nowDate =
				System.DateTime.Now;

			informationLicense.Day_Remaining =
				informationLicense.Expire_Date.Date.Subtract(nowDate.Date);

			return informationLicense;

		}
	}
}
