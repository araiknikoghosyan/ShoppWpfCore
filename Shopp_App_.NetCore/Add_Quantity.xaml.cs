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
    /// Логика взаимодействия для Add_Quantity.xaml
    /// </summary>
    public partial class Add_Quantity : Window
    {
        public int Quantity = 0; 

        public Add_Quantity()
        {
            InitializeComponent();
        }

        public int OK ()
        {
            return Quantity;
        }
        private void OkAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Quantity = int.Parse(textquantity.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Մուտքագրեք թիվ");
            }
            this.Close();
        }
    }
}
