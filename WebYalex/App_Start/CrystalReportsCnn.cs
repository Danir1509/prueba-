﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebYalex.App_Start
{
    public class CrystalReportsCnn
    {
        public static CrystalDecisions.Shared.ConnectionInfo GetConnectionInfo()
        {
            var SConn = new System.Data.SqlClient.SqlConnectionStringBuilder(
                System.Configuration.ConfigurationManager.ConnectionStrings["DbModels"].ConnectionString);

            CrystalDecisions.Shared.ConnectionInfo connInfo = new CrystalDecisions.Shared.ConnectionInfo();
            connInfo.ServerName = SConn.DataSource;
            connInfo.DatabaseName = SConn.InitialCatalog;
            connInfo.UserID = SConn.UserID;
            connInfo.Password = SConn.Password;

            return connInfo;
        }
    }
}