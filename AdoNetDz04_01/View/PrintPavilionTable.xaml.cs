using System.Data;
using System.Windows.Controls;

namespace AdoNetDz04_01.View
{
    /// <summary>
    /// Interaction logic for PrintPavilionTable.xaml
    /// </summary>
    public partial class PrintPavilionTable : Page
    {
        static DataTable d = new DataTable();
        ClassQuery cq = new ClassQuery();

        public PrintPavilionTable()
        {
            InitializeComponent();

            cq.QueryMethod();

            PavilionList.ItemsSource = d.DefaultView;
        }

        public static void GetPavilionTable(DataTable dt)
        {
            d = dt;
        }
    }
}
