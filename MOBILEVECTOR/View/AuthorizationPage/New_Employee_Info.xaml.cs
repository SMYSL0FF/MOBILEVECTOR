using MOBILEVECTOR.Core;
using MOBILEVECTOR.Model;
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

namespace MOBILEVECTOR.View.AuthorizationPage
{
    /// <summary>
    /// Логика взаимодействия для New_Employee_Info.xaml
    /// </summary>
    public partial class New_Employee_Info : Page
    {
        public New_Employee_Info()
        {
            InitializeComponent();
            

        }

        private async void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            if
               (string.IsNullOrEmpty(TxbFIO.Text) ||
               string.IsNullOrEmpty(TxbPost.Text) ||
               string.IsNullOrEmpty(TxbPhone.Text) ||
               string.IsNullOrEmpty(TxbAddress.Text) ||
               string.IsNullOrEmpty(TxbLogin_new_employee.Text) ||
               string.IsNullOrEmpty(PsbPassword_new_employee.Password) ||
               string.IsNullOrEmpty(PsbPassword_new_employee_repeat.Password))
            {
                MessageBox.Show("Все поля должны быть заполнены!",
                "Системное сообщение",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
            else
            {
                if (FrameNavigate.DB.Employee.Count(u => u.NameEmployee == TxbFIO.Text) > 0)
                {
                    MessageBox.Show("Пользователь с таким именем уже зарегистрирован!",
                        "Системная ошибка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);

                }
                FrameNavigate.DB.Employee.Add
                    (new Employee
                    {
                        NameEmployee = TxbFIO.Text,
                        PhoneEmployee = TxbPhone.Text,
                        AddressEmployee = TxbAddress.Text,
                        Post = TxbPost.Text,
                    }
                    );
                FrameNavigate.DB.Users.Add(new Users
                {
                    IdRole = 1,
                    login = TxbLogin_new_employee.Text,
                    Password = PsbPassword_new_employee.Password
                }
                );
                await FrameNavigate.DB.SaveChangesAsync();
                MessageBox.Show("Учетная запись создана!",
                        "Системное уведомление",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            }
    }
}
