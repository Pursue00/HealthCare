using HealthCareModel;
using HealthCareUnity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HealthCare.ViewModels
{
    public class UploadViewModel : BindingModelBase
    {
        #region Fileds
        
        #endregion

        #region Property
        private string _profilePicturePath;
        public string ProfilePicturePath
        {
            get { return _profilePicturePath; }
            set
            {
                _profilePicturePath = value;
                ProfilePictureImageSource = ImageHelper.PathToBitmapImage(ProfilePicturePath);
            }
        }
        private BitmapImage _profilePictureImageSource;
        public BitmapImage ProfilePictureImageSource
        {
            get
            {
                return _profilePictureImageSource;
            }
            set
            {
                _profilePictureImageSource = value;
                base.NotifyChanged("ProfilePictureImageSource");
            }
        }
        private bool _previewColor;

        public bool PreviewColor
        {
            get { return _previewColor; }
            set { _previewColor = value; base.NotifyChanged("PreviewColor"); }
        }
        
        #endregion

        #region Constructors
        public UploadViewModel()
        {
 
        }
        #endregion

        #region Public Method
        
        #endregion
    }
}
