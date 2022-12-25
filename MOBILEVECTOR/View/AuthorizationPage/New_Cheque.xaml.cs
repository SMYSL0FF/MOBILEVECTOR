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
    /// Логика взаимодействия для New_Cheque.xaml
    /// </summary>
    public partial class New_Cheque : Page
    {
        public New_Cheque()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
           
                await FrameNavigate.DB.SaveChangesAsync();
                MessageBox.Show("Учетная запись создана!",
                        "Системное уведомление",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
        }
    }
    

