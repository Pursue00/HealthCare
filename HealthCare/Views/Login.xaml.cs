using HealthCare.ViewModels;
using HealthCareService;
using HealthCareUnity;
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

namespace HealthCare.Views
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Page
    {
        #region Fileds
        public LoginViewModel _viewModel = null;
        public Action<string> LoginEvent;
        #endregion
       
        public Login()
        {
            InitializeComponent();
            _viewModel = new LoginViewModel();
            _viewModel.LoginEvent += LoginSuccess;     
            this.DataContext = _viewModel;
        }

        //async void LoginSuccess(string account)
        //{
        //    //System.Data.DataSet _DT = await WCFClient.ShiPian_LoginAsync(account, pb.Password.Trim());

        //    if (LoginEvent != null)
        //        LoginEvent(account);
        //}
        void LoginSuccess(string account)
        {
            //System.Data.DataSet _DT = await WCFClient.ShiPian_LoginAsync(account, pb.Password.Trim());

            if (LoginEvent != null)
                LoginEvent(account);
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            _viewModel.LoginEvent -= LoginSuccess;     
        }
    }
}
