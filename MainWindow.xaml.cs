using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EquipmentAccountingApp.Pages;

namespace EquipmentAccountingApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Classes.ClassFrame.frmObj = frmMain;
            frmMain.Navigate(new PageAdmin());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            frmMain.GoBack();
        }

        private void btnAutor_Click(object sender, RoutedEventArgs e)
        {
            WindowAuthorization windowAuthorization = new WindowAuthorization();
            windowAuthorization.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            windowAuthorization.Show();
            Close();
        }

        private void btnEquip_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
