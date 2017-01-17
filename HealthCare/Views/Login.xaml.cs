using HealthCare.ViewModels;
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
      
        #endregion
       
        public Login()
        {
            InitializeComponent();
            _viewModel = new LoginViewModel();
            this.DataContext = _viewModel;
        }

       
    }
}
