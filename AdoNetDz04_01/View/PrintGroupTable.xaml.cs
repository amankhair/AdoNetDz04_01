using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace AdoNetDz04_01.View
{
    /// <summary>
    /// Interaction logic for PrintGroupTable.xaml
    /// </summary>
    public partial class PrintGroupTable : Page
    {
        private string _connectionString =
            @"Data Source=AMANKELDI-PC;initial catalog=CRCMS_new;Integrated Security=True";

        private string sqlExpression = "SELECT * FROM dic_Group";

        public PrintGroupTable()
        {
            InitializeComponent();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable groupTable = new DataTable("dic_Group");
                    adapter.Fill(groupTable);

                    GroupList.ItemsSource = groupTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
