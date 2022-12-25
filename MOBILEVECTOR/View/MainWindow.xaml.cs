using MOBILEVECTOR.Core;
using MOBILEVECTOR.Model;
using MOBILEVECTOR.View;
using System;
using System.Diagnostics;
using System.Security.Policy;
using System.Windows;
using System.Windows.Input;

namespace MOBILEVECTOR
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameNavigate.FrameObject = MainWindowFrame;
            FrameNavigate.DB = new MOBILEVECTOREntities1();
            MainWindowFrame.Navigate(new Authorization());
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        { 
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
             
        }

        private void Btn_new_employee_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Чтобы добавить сотрудника войдите в аккаунт администратора!",
                "Системное уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void Btn_Authorization_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new Authorization());
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://t.me/MOBILEVECTOR");
        }

        private void Btn_New_Client_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new View.AuthorizationPage.New_Client());
        }
    }
}
