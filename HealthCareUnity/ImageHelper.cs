using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;
using System.IO;
using System.Threading;
using System.Windows;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Net;
using System.Windows.Interop;
using System.Drawing.Imaging;

namespace HealthCareUnity
{
    public class ImageHelper
    {
        [DllImport("FFmpegWrapper.dll", EntryPoint = "_GenMp4Image@8", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 GenMp4Image(String infilename, String outfilename);///////
        public static BitmapImage PathToBitmapImage(string ImagePath, string ControlType = "")
        {
            //ImagePath = ImagePath.Replace("//", "\\").Replace("/", "\\");
            var uri = new Uri(ImagePath, UriKind.RelativeOrAbsolute);

            if (!uri.IsAbsoluteUri && !string.IsNullOrEmpty(ControlType))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("/CustomControls;component/");
                sb.Append(ControlType);
                sb.Append("/");
                sb.Append(ImagePath);
                return new BitmapImage(new Uri(sb.ToString(), UriKind.Relative));
            }

            if (uri.IsFile && !File.Exists(uri.LocalPath))
                return null;

            return PathToBitmapImage(uri);
        }
        public static BitmapImage PathToBitmapImage(Uri ImagePath)
        {
            try
            {
                BitmapImage bitMapImage = new BitmapImage();
                bitMapImage.CreateOptions = BitmapCreateOptions.IgnoreColorProfile;
                bitMapImage.BeginInit();
                bitMapImage.CacheOption = BitmapCacheOption.OnLoad; //增加这一行
                bitMapImage.UriSource = ImagePath;
                bitMapImage.EndInit();
                if (ImagePath.Scheme != "http")
                    bitMapImage.Freeze();
                return bitMapImage;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
