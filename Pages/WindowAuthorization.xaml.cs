﻿using System;
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
using System.Windows.Shapes;
using EquipmentAccountingApp.Classes;

namespace EquipmentAccountingApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для WindowAuthorization.xaml
    /// </summary>
    public partial class WindowAuthorization : Window
    {
        public WindowAuthorization()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text.Trim();
            string pass = pbPass.Password.Trim();

            if (login.Length < 5)
            {
                tbLogin.ToolTip = "Поле введено не корректно!";
                tbLogin.BorderBrush = Brushes.Red;
            }
            else if (pass.Length < 5)
            {
                pbPass.ToolTip = "Поле введено не корректно!";
                pbPass.BorderBrush = Brushes.Red;
            }
            else
            {
                tbLogin.ToolTip = "";
                tbLogin.BorderBrush = Brushes.Transparent;
                pbPass.ToolTip = "";
                pbPass.BorderBrush = Brushes.Transparent;

                Admin admin = null;
                using (EquipmentAccountingEntities db = new EquipmentAccountingEntities())
                {
                    admin = EquipmentAccountingEntities.GetContext().Admin.Where(x => x.Username == login && x.Password == pass).FirstOrDefault();
                }

                if (admin != null)
                {
                    MessageBox.Show("Авторизация прошла успешно");
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Пользователь не авторизован");
            }
        }
    }
}
