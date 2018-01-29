using AdoNetDz04_01.View;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace AdoNetDz04_01
{
    class ClassQuery
    {
        private string _connectionString =
            @"Data Source=AMANKELDI-PC;initial catalog=CRCMS_new;Integrated Security=True";

        private string sqlExpression = "SELECT * FROM dic_Status; SELECT * FROM dic_Pavilion";

        public void QueryMethod()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable statusTable = new DataTable("dic_Status");
                    DataTable pavilionTable = new DataTable("dic_Pavilion");


                    adapter.Fill(statusTable);
                    adapter.Fill(pavilionTable);

                    PrintStatusTable.GetStatusTable(statusTable);
                    PrintPavilionTable.GetPavilionTable(pavilionTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
