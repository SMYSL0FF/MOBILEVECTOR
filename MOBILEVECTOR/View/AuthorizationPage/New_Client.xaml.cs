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
    /// Логика взаимодействия для New_Client.xaml
    /// </summary>
    public partial class New_Client : Page
    {
        public New_Client()
        {
            InitializeComponent();
        }

        private async void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if
              (string.IsNullOrEmpty(TxbFIO.Text) ||
              string.IsNullOrEmpty(TxbTelegram.Text) ||
              string.IsNullOrEmpty(TxbPhone.Text) ||
              string.IsNullOrEmpty(TxbAddress.Text) ||
              string.IsNullOrEmpty(TxbDevice.Text))
             
            {
                MessageBox.Show("Все поля должны быть заполнены!",
                "Системное сообщение",
                MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
            else
            {
                FrameNavigate.DB.Client.Add
                    (new Client
                    {
                        NameClient = TxbFIO.Text,
                        PhoneClient = TxbPhone.Text,
                        AddressClient = TxbAddress.Text,
                        Device = TxbDevice.Text,
                        TelegramUsername= TxbTelegram.Text,
                    }
                    );
                await FrameNavigate.DB.SaveChangesAsync();
                MessageBox.Show("Данные сохранены!",
                        "Системное уведомление",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
        }
    }
    }

