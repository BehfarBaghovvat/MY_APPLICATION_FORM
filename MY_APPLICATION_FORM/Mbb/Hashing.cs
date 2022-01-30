namespace Mbb
{
	internal static class Hashing
	{
		internal static string GetSHA1(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				return null;
			}
			else
			{
				var sha1 =
			   System.Security.Cryptography.SHA1.Create();

				byte[] bytes =
					sha1.ComputeHash(System.Text.Encoding.ASCII.GetBytes(value));

				var sb =
					new System.Text.StringBuilder();

				for (int i = 0; i < bytes.Length; i++)
				{
					sb.Append(bytes[i].ToString("x2"));
				}

				return sb.ToString();
			}
		}


		internal static string GetMD5(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				return null;
			}
			else
			{
				var md5 =
				System.Security.Cryptography.MD5.Create();

				byte[] bytes =
					md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(value));

				var sb = new System.Text.StringBuilder();

				for (int i = 0; i < bytes.Length; i++)
				{
					sb.Append(bytes[i].ToString("x2"));
				}

				return sb.ToString();
			}
		}




	}
}
