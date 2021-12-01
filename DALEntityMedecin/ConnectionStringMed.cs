﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEntityMedecin
{
    class ConnectionStringMed
    {
        public static string GetEFConnectionString()
        {

            // Specify the provider name, server and database.
            string providerName = "System.Data.SqlClient";
            string serverName = @"DESKTOP-SGBO0M4\EPHEC2020";
            string databaseName = "MedAssistV2";

            // Initialize the connection string builder for the
            // underlying provider.
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            // Set the properties for the data source.
            sqlBuilder.DataSource = serverName;
            sqlBuilder.InitialCatalog = databaseName;
            sqlBuilder.IntegratedSecurity = false;
            sqlBuilder.UserID = "MedAssistMedecin";
            sqlBuilder.Password = "Misterx";

            // Build the SqlConnection connection string.
            // string providerString = sqlBuilder.ToString();

            // Initialize the EntityConnectionStringBuilder.
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();

            //Set the provider name.
            entityBuilder.Provider = providerName;

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = sqlBuilder.ConnectionString;

            // Set the Metadata location.
            entityBuilder.Metadata = @"res://*/Model2.csdl|
                                    res://*/Model2.ssdl|
                                    res://*/Model2.msl
                                    ";
            return entityBuilder.ConnectionString;

        }
    }
}
