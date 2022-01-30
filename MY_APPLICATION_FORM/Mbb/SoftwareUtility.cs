using System.Management;


namespace Mbb
{
    internal static class SoftwareUtility
    {
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
        /// 
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
        /// Returns Server Name And Database Name
        /// </summary>
        /// <returns>serverNameAndDatabaseName</returns>
        internal static string GetUniqueSrial()
        {
            string setInfo = null;

            string
                resultInfo,
                myDatabase,
                idCPU,
                IdHDD,
                serverName;

            serverName =
                System.Environment.MachineName.Trim();

            //if (string.Compare(GetListDatabeseName().Find(x => x.Contains("CNCFalwator")), "CNCFalwator") == 0)
            //{
            //    myDatabase = GetListDatabeseName().Find(x => x.Contains("CNCFalwator"));
            //}
            //else
            //{
            //    myDatabase = string.Empty;
            //}

            idCPU = GetIdCPU();
            IdHDD = GetIdHDD();

            setInfo += $"{idCPU}{IdHDD}{serverName.ToLower()}";

            resultInfo = $"{setInfo}";

            return resultInfo;
        }


    }
}
