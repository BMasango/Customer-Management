using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFiveFriday.DataAccessLayer
{
    public class DBAccessLayer
    {
        private ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["AssignmentFiveFriday.Properties.Settings.connString"];
        private string connString;

        public DBAccessLayer()
        {
            if (settings == null)
                throw new Exception("Connection string settings could not be located. Please verify connection settings are configured correctly.");

            connString = settings.ConnectionString;
        }

        public int GetCustomerID(string where)
        {
            if (string.IsNullOrEmpty(where))
                return 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                DataSet ds = new DataSet();
                conn.Open();

                string sqlQuery = $"SELECT * FROM Customer WHERE {where}";
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conn);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);

                try
                {
                    da.TableMappings.Add("Table", "Customer");
                    da.Fill(ds);

                    return Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public string InsertContactBuilder(DataSet ContactCollection, string whereClause)
        {
            string query = $"DECLARE @CustomerID int SELECT @CustomerID = ID FROM Customer WHERE {whereClause} ";
            query += $"INSERT INTO CustomerContacts (Email, ContactNo, CustomerID) VALUES";
            foreach (DataRow row in ContactCollection.Tables["CustomerContacts"].Rows)
            {
                query += $"('{row["Email"]}', '{row["ContactNo"]}', @CustomerID),";
            }
            query = query.TrimEnd(',');
            return query;
        }

        public void NonQueryExecution(string command) {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand(command, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string InsertCustomerBuilder(DataRow row)
        {
            return $"INSERT INTO Customer (Name, Longitude, Latitude) VALUES ('{row["Name"]}', '{row["Longitude"]}', '{row["Latitude"]}')";
        }

        public DataSet ExecuteQueryHandler(DataSet dataSetSource, string whereClause)
        {   
            if (dataSetSource.Tables["Customer"].DataSet.GetChanges(DataRowState.Modified) != null || dataSetSource.Tables["Customer"].DataSet.GetChanges(DataRowState.Added) != null)
                InsertUpdateQueryHandler(dataSetSource.Tables["Customer"].DataSet.GetChanges(), "Customer");

            if (dataSetSource.Tables["CustomerContacts"].DataSet.HasChanges() && dataSetSource.Tables["CustomerContacts"].DataSet.GetChanges().Tables["CustomerContacts"].Rows.Count > 0)
            {
                string command = InsertContactBuilder(dataSetSource.Tables["CustomerContacts"].DataSet.GetChanges(DataRowState.Added), whereClause);
                NonQueryExecution(command);
            }
            
            return GetAllCustomerDetails();
        }

        public void InsertUpdateQueryHandler(DataSet dataSetSource, string tblName, string whereClause = null)
        {
            if (string.IsNullOrEmpty(tblName) || dataSetSource == null)
                throw new Exception("Database table name or data set has not been set");

            using (SqlConnection conn = new SqlConnection(connString))
            {
                DataSet ds = new DataSet();
                conn.Open();

                string sqlQuery = string.Format("SELECT * FROM {0} {1}", tblName, string.IsNullOrEmpty(whereClause) ? "" : "WHERE " + whereClause);
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conn);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);

                try
                {
                    da.TableMappings.Add("Table", tblName);
                    da.Fill(ds);
                    da.Update(dataSetSource);
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw new Exception("An error occurred while trying to update the database. Please see inner exception.", ex.InnerException);
                }
            }
        }

        public DataSet GetAllCustomerDetails()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmdSelect = new SqlCommand("RetrieveCustomerDetails", conn) { CommandType = CommandType.StoredProcedure };
                conn.Open();

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.TableMappings.Add("Table", "Customer");
                    da.TableMappings.Add("Table1", "CustomerContacts");
                    da.SelectCommand = cmdSelect;

                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    return ds;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw new Exception("An error occurred during customer information retrieval. Please see inner exception.", ex.InnerException);
                }
            }
        }
    }
}
