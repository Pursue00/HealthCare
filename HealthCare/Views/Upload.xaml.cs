using HealthCare.ViewModels;
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
using System.Windows.Shapes;

namespace HealthCare.Views
{
    /// <summary>
    /// Upload.xaml 的交互逻辑
    /// </summary>
    public partial class Upload : Window
    {
        #region Fileds
        UploadViewModel _viewModel = null;
        #endregion
        public Upload()
        {
            InitializeComponent();
            _viewModel = new UploadViewModel();
            this.DataContext = _viewModel;
        }
    }
}
