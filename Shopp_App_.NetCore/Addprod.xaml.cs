using Shopp_App_.NetCore.Context;
using Shopp_App_.NetCore.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Shopp_App_.NetCore
{
    /// <summary>
    /// Логика взаимодействия для Addprod.xaml
    /// </summary>
    public partial class Addprod : Window
    {
        public Addprod()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (textname.Text == "" || textQuantity.Text == "" || textPrice.Text == "")
            {
                MessageBox.Show("заполните ячейки");
            }
            else
            {
                var db = new DataContext();
                try
                {
                    var store = new Store(textname.Text, Convert.ToDecimal(textQuantity.Text), Convert.ToDecimal(textPrice.Text));
                    db.Stores.Add(store);
                    db.SaveChanges();
                    MessageBox.Show("продукт добавлен");
                    textname.Text = "";
                    textPrice.Text = "";
                    textQuantity.Text = "";
                        
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

       
    }
}
