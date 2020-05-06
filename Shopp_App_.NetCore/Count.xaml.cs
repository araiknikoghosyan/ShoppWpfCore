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
    /// Логика взаимодействия для Count.xaml
    /// </summary>
    public partial class Count : Window
    {
        public int count = 0;
        public Count()
        {
            InitializeComponent();
        }
        public int Ok()
        {
            return count;
        }

        private void CountOK_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                count = int.Parse(textCount.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Մուտքագրեք թիվ");
            }
            this.Close();

        }
    }
}
