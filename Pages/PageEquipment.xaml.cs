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
using EquipmentAccountingApp.Classes;

namespace EquipmentAccountingApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEquipment.xaml
    /// </summary>
    public partial class PageEquipment : Page
    {
        public PageEquipment()
        {
            InitializeComponent();
            dtgEquip.ItemsSource = EquipmentAccountingEntities.GetContext().Equipment.ToList();
            //CountRows.Text = dtgEquip.Items.Count.ToString();
        }
    }
}
