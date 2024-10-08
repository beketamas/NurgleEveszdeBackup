﻿using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NurgleEveszdeWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnBejelentkezes.Click += (s, e) =>
            {
                Rendeles rendeles = new Rendeles();
                this.Close();
                rendeles.ShowDialog();
            };
        }

        private void btnRegisztracio_Click(object sender, RoutedEventArgs e)
        {
            Window registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            App.Current.MainWindow.Close();
        }
    }
}