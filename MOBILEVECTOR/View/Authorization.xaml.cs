using MaterialDesignThemes.Wpf;
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

namespace MOBILEVECTOR.View
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Btn_enter_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                employee Name = FrameNavigate.DB.employee.FirstOrDefault(u =>
                u.name_employee == TxbLogin.Text && u.name_employee == PsbPassword.Password);

                if (Name == null)
                {
                    MessageBox.Show("Ошибка данных",
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }

            }
            catch (Exception ex)
             {
                    MessageBox.Show(ex.Message.ToString(),
                        "системная ошибка",
                       MessageBoxButton.OK,
                       MessageBoxImage.Error);

             }

            }
        }
    }
