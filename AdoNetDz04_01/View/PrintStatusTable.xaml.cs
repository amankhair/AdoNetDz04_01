using System.Data;
using System.Windows.Controls;

namespace AdoNetDz04_01.View
{
    /// <summary>
    /// Interaction logic for PrintStatusTable.xaml
    /// </summary>
    public partial class PrintStatusTable : Page
    {
        static DataTable d = new DataTable();
        ClassQuery cq = new ClassQuery();

        public PrintStatusTable()
        {
            InitializeComponent();

            cq.QueryMethod();

            StatusList.ItemsSource = d.DefaultView;
        }

        public static void GetStatusTable(DataTable dt)
        {
            d = dt;
        }
    }
}
