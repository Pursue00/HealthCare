using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareModel
{
    public class Schedule : BindingModelBase
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; base.NotifyChanged("Id"); }
        }
        
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; base.NotifyChanged("Title"); }
        }

        private string _userid;

        public string Userid
        {
            get { return _userid; }
            set { _userid = value; base.NotifyChanged("Userid"); }
        }

        private string _togeter_date;

        public string Togeter_date
        {
            get { return _togeter_date; }
            set { _togeter_date = value; base.NotifyChanged("Togeter_date"); }
        }

        private string _session_id;

        public string Session_id
        {
            get { return _session_id; }
            set { _session_id = value; base.NotifyChanged("Session_id"); }
        }

        /// <summary>
        /// 会场
        /// </summary>
        private string _togeter_hall;

        public string Togeter_hall
        {
            get { return _togeter_hall; }
            set { _togeter_hall = value; base.NotifyChanged("Togeter_hall"); }
        }

        private string _time_slot;

        public string Time_slot
        {
            get { return _time_slot; }
            set { _time_slot = value; base.NotifyChanged("Time_slot"); }
        }

        private string _realName;

        public string RealName
        {
            get { return _realName; }
            set { _realName = value; base.NotifyChanged("RealName"); }
        }

        private string _is_upload;

        public string Is_upload
        {
            get { return _is_upload; }
            set { _is_upload = value; base.NotifyChanged("Is_upload"); }
        }

        private string _is_upload_en;

        public string Is_upload_en
        {
            get { return _is_upload_en; }
            set { _is_upload_en = value; base.NotifyChanged("Is_upload_en"); }
        }

        private string _filedir;

        public string Filedir
        {
            get { return _filedir; }
            set { _filedir = value; base.NotifyChanged("Filedir"); }
        }

        private string _have_video;

        public string Have_video
        {
            get { return _have_video; }
            set { _have_video = value; base.NotifyChanged("Have_video"); }
        }

        private string _org;

        public string Org
        {
            get { return _org; }
            set { _org = value; base.NotifyChanged("Org"); }
        }

        private string authorizeState;

        public string AuthorizeState
        {
            get { return authorizeState; }
            set { authorizeState = value; base.NotifyChanged("AuthorizeState"); }
        }

        private string _mobile_phone;

        public string Mobile_phone
        {
            get { return _mobile_phone; }
            set { _mobile_phone = value; base.NotifyChanged("Mobile_phone"); }
        }
        
    }
}
