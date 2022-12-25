using MOBILEVECTOR.Core;
using MOBILEVECTOR.Model;
using MOBILEVECTOR.View.AuthorizationPage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
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

namespace MOBILEVECTOR.View
{
    /// <summary>
    /// Логика взаимодействия для MainAdminPage.xaml
    /// </summary>
    public partial class MainAdminPage : Page
    {
        public MainAdminPage()
        {
            InitializeComponent();

            InfoE.ItemsSource = FrameNavigate.DB.Employee.ToList();
            InfoClient.ItemsSource = FrameNavigate.DB.Client.ToList();
            InfoCheque.ItemsSource = FrameNavigate.DB.Cheque.ToList();
            InfoPart.ItemsSource = FrameNavigate.DB.Part.ToList();
            InfoAccount.ItemsSource = FrameNavigate.DB.Users.ToList();
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PackIcon_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new Authorization());
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnDeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            int IDEmployee = (InfoE.SelectedItem as Employee).IdEmployee;
            var result = MessageBox.Show("Удалить информацию о сотруднике?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) 
            {
                Employee employee =(from b in FrameNavigate.DB.Employee where b.IdEmployee == IDEmployee select b).SingleOrDefault();
                FrameNavigate.DB.Employee.Remove(employee);
                FrameNavigate.DB.SaveChanges();
                InfoE.ItemsSource = FrameNavigate.DB.Employee.OrderBy(b => b.IdEmployee).ToList();
            }
        
           
        }

        private void BtnDeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            int IdUser = (InfoAccount.SelectedItem as Users).IdUser;
            var result = MessageBox.Show("Удалить аккаунт сотрудника?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Users user = (from c in FrameNavigate.DB.Users where c.IdUser == IdUser select c).SingleOrDefault();
                FrameNavigate.DB.Users.Remove(user);
                FrameNavigate.DB.SaveChanges();
                InfoAccount.ItemsSource = FrameNavigate.DB.Users.OrderBy(c => c.IdUser).ToList();
            }
        }

        private void BtndeleteClient_Click(object sender, RoutedEventArgs e)
        {
            int IdClient = (InfoClient.SelectedItem as Client).IdClient;
            var result = MessageBox.Show("Удалить данные о клиенте?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Client client = (from c in FrameNavigate.DB.Client where c.IdClient == IdClient select c).SingleOrDefault();
                FrameNavigate.DB.Client.Remove(client);
                FrameNavigate.DB.SaveChanges();
                InfoClient.ItemsSource = FrameNavigate.DB.Client.OrderBy(c => c.IdClient).ToList();
            }
        }

        private void BtnDeleteCheque_Click(object sender, RoutedEventArgs e)
        {
            int IdCheque = (InfoCheque.SelectedItem as Cheque).IdCheque;
            var result = MessageBox.Show("Удалить чек?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Cheque cheque = (from c in FrameNavigate.DB.Cheque where c.IdCheque == IdCheque select c).SingleOrDefault();
                FrameNavigate.DB.Cheque.Remove(cheque);
                FrameNavigate.DB.SaveChanges();
                InfoCheque.ItemsSource = FrameNavigate.DB.Cheque.OrderBy(c => c.IdCheque).ToList();
            }
        }

        private void BtnDeletePart_Click(object sender, RoutedEventArgs e)
        {
            int IdPart = (InfoPart.SelectedItem as Part).IdPart;
            var result = MessageBox.Show("Удалить запчасть?",
                                         "Системное сообщение",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Part part = (from c in FrameNavigate.DB.Part where c.IdPart == IdPart select c).SingleOrDefault();
                FrameNavigate.DB.Part.Remove(part);
                FrameNavigate.DB.SaveChanges();
                InfoPart.ItemsSource = FrameNavigate.DB.Part.OrderBy(c => c.IdPart).ToList();
            }
        }

        private void AddEmployee_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new New_Employee_Info());
        }

        private async void Save1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            await FrameNavigate.DB.SaveChangesAsync();
            MessageBox.Show("Изменения сохранены!",
                    "Системное уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
        }

        private void BtnUpdate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            InfoE.ItemsSource = FrameNavigate.DB.Employee.ToList();
            InfoClient.ItemsSource = FrameNavigate.DB.Client.ToList();
            InfoCheque.ItemsSource = FrameNavigate.DB.Cheque.ToList();
            InfoPart.ItemsSource = FrameNavigate.DB.Part.ToList();
            InfoAccount.ItemsSource = FrameNavigate.DB.Users.ToList();
        }
    }
}
