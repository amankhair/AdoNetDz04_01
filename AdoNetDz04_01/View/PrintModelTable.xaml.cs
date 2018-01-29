using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace AdoNetDz04_01.View
{
    /// <summary>
    /// Interaction logic for PrintModelTable.xaml
    /// </summary>
    public partial class PrintModelTable : Page
    {
        private string _connectionString =
            @"Data Source=AMANKELDI-PC;initial catalog=CRCMS_new;Integrated Security=True";

        private string sqlExpression = "SELECT * FROM dic_Model";

        public PrintModelTable()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable modelTable = new DataTable("dic_Model");
                    DataTableMapping tblMap = adapter.TableMappings.Add("Model", "dic_Model");
                    tblMap.ColumnMappings.Add("ModelId", "ModelId");
                    tblMap.ColumnMappings.Add("Code", "CodeModel");
                    tblMap.ColumnMappings.Add("Name", "NameModel");
                    tblMap.ColumnMappings.Add("SeriesId", "Series");
                    adapter.Fill(modelTable);

                    ModelList.ItemsSource = modelTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
