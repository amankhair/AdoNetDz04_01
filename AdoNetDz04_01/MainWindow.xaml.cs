using System;
using System.Windows;

namespace AdoNetDz04_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GroupTable_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PrintGroupTable.xaml", UriKind.RelativeOrAbsolute);
        }

        private void StatusTable_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PrintStatusTable.xaml", UriKind.RelativeOrAbsolute);
        }

        private void PavilionTable_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PrintPavilionTable.xaml", UriKind.RelativeOrAbsolute);
        }

        private void ModelTable_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PrintModelTable.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
