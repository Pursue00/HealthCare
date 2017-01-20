using HealthCareModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.ViewModels
{
    public class ShiPianMainViewModel : BindingModelBase
   {
       #region Fileds
       
       #endregion

       #region Property
       private ObservableCollection<Schedule> _scheduleCollection;

       public ObservableCollection<Schedule> ScheduleCollection
       {
           get { return _scheduleCollection; }
           set { _scheduleCollection = value; base.NotifyChanged("ScheduleCollection"); }
       }
       
       #endregion

       #region Constructors
       public ShiPianMainViewModel()
       {
 
       }
       #endregion

       #region Public Method
       
       #endregion
   }
}
