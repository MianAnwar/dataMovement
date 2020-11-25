using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppQ3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> lst1 = new ObservableCollection<string>();
        ObservableCollection<string> lst2 = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            list1.ItemsSource = lst1;
            list2.ItemsSource = lst2;
        }

        private void Add1_Click(object sender, RoutedEventArgs e)
        {
            if (value1.Text.Equals(""))
            {
                MessageBox.Show("Must Fill it!", "Alert");
                return;
            }
            else
            {
                lst1.Add(value1.Text);
                value1.Text = "";
            }
        }

        private void Add2_Click(object sender, RoutedEventArgs e)
        {
            if (value2.Text.Equals(""))
            {
                MessageBox.Show("Must Fill it!", "Alert");
                return;
            }
            else
            {
                lst2.Add(value2.Text);
                value2.Text = "";
            }
        }

        private void forwards_Click(object sender, RoutedEventArgs e)
        {
            if (list1.SelectedItem != null)
            {
                lst2.Add(list1.SelectedItem as string);
                lst1.Remove(list1.SelectedItem as string);
                list1.SelectedItem = null;
                list2.SelectedItem = null;
            }
        }

        private void forward_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < lst1.Count; i++)
            { 
                lst2.Add(lst1[i]);
                lst1.Remove(lst1[i]);
            }         
        }

        private void backwards_Click(object sender, RoutedEventArgs e)
        {
            if (list2.SelectedItem != null)
            {
                lst1.Add(list2.SelectedItem as string);
                lst2.Remove(list2.SelectedItem as string);
                list1.SelectedItem = null;
                list2.SelectedItem = null;
            }
        }

        private void backward_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < lst2.Count; i++)
            {
                lst1.Add(lst2[i]);
                lst2.Remove(lst2[i]);
            }
        }
    }
}
