
namespace Models
{
    public class LicenseKey
    {
        public LicenseKey() : base()
        {

        }

		/// <summary>
		/// ردیف
		/// </summary>
		#region Id
		//-----DisplayName field for Id
		[System.ComponentModel.DisplayName(displayName: "ردیف")]
		//-----Primery Key For this field
		[System.ComponentModel.DataAnnotations.Key]
		public int Id
		{
			get; set;
		}
		#endregion /Id

		/// <summary>
		/// SQL کد یکتای
		/// </summary>
		#region Active_Code
		//-----DisplayName field for Active_Code
		[System.ComponentModel.DisplayName(displayName: "کد فعالسازی")]
		public string Active_Code
		{
			get; set;
		}
		#endregion /Active_Code

		/// <summary>
		/// کلید مجوز
		/// </summary>
		#region License_Code
		//-----DisplayName field for License_Code
		[System.ComponentModel.DisplayName(displayName: "کد مجوز")]
		public string License_Code
		{
			get; set;
		}
		#endregion /License_Code

		/// <summary>
		/// تاریخ انقضای نرم افزار
		/// </summary>
		#region Expire_Date
		//-----DisplayName field for Expire_Date
		[System.ComponentModel.DisplayName(displayName: "تاریخ انقضا")]
		public string Expire_Date
		{
			get; set;
		}
		#endregion /Expire_Date
	}
}
