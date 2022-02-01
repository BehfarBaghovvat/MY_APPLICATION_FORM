using System.Management;


namespace Mbb
{
    internal static class SoftwareUtility
    {
        private static string _otherValue = "SDL3-SL6D-77FJ-S3H5-LKJH-SERV";

		public static string GetSQLServerId 
        { 
            get
			{
                return $"{GetSQLServerID().ToLower()}{_otherValue.ToLower()}";
			}
        }

		static SoftwareUtility()
        {

        }

        /// <summary>
        /// Returns the CPU ID
        /// </summary>
        /// <returns>idCPU</returns>
        private static string GetIdCPU()
        {
            string idCPU = string.Empty;

            ManagementClass mc =
                new ManagementClass("win32_processor");

            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                idCPU = mo.Properties["processorID"].Value.ToString();
                break;
            }

            return idCPU;
        }

        /// <summary>
        /// Return the HDD ID
        /// </summary>
        /// <returns>idHDD</returns>
        private static string GetIdHDD()
        {
            string idHDD = string.Empty;

            System.Management.ManagementObjectSearcher moSearcher =
                new System.Management.ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (System.Management.ManagementObject wmi_HD in moSearcher.Get())
            {
                idHDD =
                    wmi_HD.ToString().Trim();

                break;
            }

            return idHDD;
        }

        /// <summary>
        /// Return the ServerName
        /// </summary>
        /// <returns></returns>
        private static string GetServerName()
        {
            return System.Environment.MachineName.Trim();
        }

        /// <summary>
        /// Return the list of database names 
        /// </summary>
        /// <returns></returns>
        private static System.Collections.Generic.List<string> GetListDatabeseName()
        {
            System.Collections.Generic.List<string> listDatabase = 
                new System.Collections.Generic.List<string>();

            System.Data.SqlClient.SqlConnection
               sc = new System.Data.SqlClient.SqlConnection("Data Source=.;Integrated Security=True");

            sc.Open();
            var command = new System.Data.SqlClient.SqlCommand();

            command.Connection = sc;

            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select name from master.sys.databases";

            var adapter = new System.Data.SqlClient.SqlDataAdapter(command);
            var dataSet = new System.Data.DataSet();

            adapter.Fill(dataSet);
            System.Data.DataTable dt = dataSet.Tables[0];

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                listDatabase.Add(dataSet.Tables[0].Rows[i][0].ToString());

                //if (string.Compare(myDatabase, "CNCFalwator") == 0)
                //{
                //    setInfo += myDatabase;
                //    break;
                //}
                //else
                //{
                //    setInfo += "CNCFalwator";
                //    break;
                //}
                sc.Close();
            }

            return listDatabase;
        }

        /// <summary>
        ///  Reture value InstallID
        /// </summary>
        /// <returns></returns>
        private static string GetSQLServerID()
		{
            System.Collections.Generic.List<string> listDatabase =
                new System.Collections.Generic.List<string>();

            System.Data.SqlClient.SqlConnection
               sc = new System.Data.SqlClient.SqlConnection("Data Source=.;Integrated Security=True");

            sc.Open();
            var command = new System.Data.SqlClient.SqlCommand();

            command.Connection = sc;

            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select value_data from sys.dm_server_registry where value_name= 'InstallID'";

            var adapter = new System.Data.SqlClient.SqlDataAdapter(command);
            var dataSet = new System.Data.DataSet();

            adapter.Fill(dataSet);

            return dataSet.Tables[0].Rows[0][0].ToString();
        }       

        /// <summary>
        /// Returns Server Name And Database Name
        /// </summary>
        /// <returns>serverNameAndDatabaseName</returns>
        private static string GetUniqueSrial()
        {
            string setInfo = null;

            string
                resultInfo,
                idCPU,
                IdHDD,
                serverName;

            serverName =
                System.Environment.MachineName.Trim();

            idCPU = GetIdCPU();
            IdHDD = GetIdHDD();

            setInfo += $"{idCPU}{IdHDD}{serverName.ToLower()}";

            resultInfo = $"{setInfo}";

            return resultInfo;
        }


    }
}
