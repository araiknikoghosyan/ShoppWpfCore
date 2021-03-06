﻿using Shopp_App_.NetCore.Context;
using System.Windows;
using Shopp_App_.NetCore.Model;
using System.Linq;
using System.Windows.Controls;
using System;

namespace Shopp_App_.NetCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using var db = new DataContext();
            gridload.ItemsSource = db.Stores.ToList();
            gridload.AutoGeneratedColumns += Gridload_AutoGeneratedStore;
        }
        private void Gridload_AutoGeneratedStore(object sender, System.EventArgs e)
        {
            try
            {
                DataGrid dataGrid = sender as DataGrid;
                dataGrid.Columns[1].Header = "Անուն";
                dataGrid.Columns[2].Header = "Քանակ";
                dataGrid.Columns[3].Header = "Գին";
                dataGrid.Columns[4].Header = "Ամսաթիվ";
            }
            catch (Exception) { }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var addprod = new Addprod();
            addprod.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы точно хотите удалить?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                try
                {
                    var db = new DataContext();
                    Store dataModel = (Store)gridload.SelectedItem;
                   
                    db.Stores.Remove(dataModel);
                    db.SaveChanges();
                    gridload.ItemsSource = db.Stores.ToList();
                }
                catch (Exception)
                {
                    MessageBox.Show("Не получилось ");
                }
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new DataContext())
            {
                gridload.ItemsSource = db.Stores.ToList();
                Gridload_AutoGeneratedStore(gridload, null);
            }
        }

        private void Sales_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new DataContext())
                {
                    Count window = new Count();
                    window.ShowDialog();
                    int count = window.Ok();
                    var temp = (Store)gridload.SelectedItem;
                    if (count <= temp.Quantity)
                    {
                        var temp2 = db.Stores.FirstOrDefault(p => p.NameProduct == temp.NameProduct && p.Quantity == temp.Quantity);
                        temp2.Quantity -= count;
                        db.SaveChanges();
                        gridload.ItemsSource = db.Stores.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Столько нету");
                    }
                }
                 
            }
           
            catch (Exception)
            {
                MessageBox.Show("Не получилось");
            }
        }

        private void Addquantity_Click(object sender, RoutedEventArgs e)
        {
            using var db = new DataContext();
            Add_Quantity window = new Add_Quantity();
            window.ShowDialog();
            int count = window.OK();
            var temp = (Store)gridload.SelectedItem;

            try
            {
                var temp2 = db.Stores.FirstOrDefault(p => p.NameProduct == temp.NameProduct && p.Quantity == temp.Quantity);
                temp2.Quantity += count;
                db.SaveChanges();
                gridload.ItemsSource = db.Stores.ToList();

            }
            catch (Exception)
            {

                MessageBox.Show("Не получилось");
            }
           
        }
 
    }
}
