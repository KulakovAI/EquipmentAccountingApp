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
using EquipmentAccountingApp.Classes;

namespace EquipmentAccountingApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        public PageAdmin()
        {
            InitializeComponent();
            lstAdmin.ItemsSource = EquipmentAccountingEntities.GetContext().Admin.ToList();
            //CountRows.Text = lstAdmin.Items.Count.ToString();
        }
    }
}
