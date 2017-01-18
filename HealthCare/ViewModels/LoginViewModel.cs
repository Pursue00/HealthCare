using HealthCareModel;
using HealthCareService;
using HealthCareUnity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.ViewModels
{
    public class LoginViewModel : BindingModelBase
    {
        #region Fileds
        public RelayCommand<object> BtnCommand { get; private set; }
        public Action<string> LoginEvent;
        #endregion

        public LoginViewModel()
        {
            this.BtnCommand = new RelayCommand<object>(OnBtnCommand);
        }

        #region Property
        /// <summary>
        /// 用户名
        /// </summary>
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; base.NotifyChanged("UserName"); }
        }
        /// <summary>
        /// 密码
        /// </summary>
        private string _passWord;

        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; base.NotifyChanged("PassWord"); }
        }

        #endregion
        #region Public Method
        private  void OnBtnCommand(object arg)
        {
            string cmd = arg.ToString().ToLower();
            switch (cmd)
            {
                case "login":
                    if (LoginEvent != null)
                        LoginEvent(this.UserName);
                    
                    break;
                case "cancel":
                    break;
            }
        }
        #endregion
    }
}
