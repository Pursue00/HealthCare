using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareService
{
    public class WCFClient
    {
        static WCFService.Service1Client _wcfService = null;
        public static WCFService.Service1Client GetInstace()
        {
            if (_wcfService == null)
                _wcfService = new WCFService.Service1Client();
            return _wcfService;
        }

        /// <summary>
        /// 试片室登录
        /// </summary>
        /// <param name="_userName"></param>
        /// <param name="_passWord"></param>
        /// <returns></returns>
        public async static Task<System.Data.DataSet> ShiPian_LoginAsync(string _userName, string _passWord)
        {
            return await WCFClient.GetInstace().ShiPian_LoginAsync(_userName, _passWord);
        }

        /// <summary>
        /// 大厅登录
        /// </summary>
        /// <param name="_userName"></param>
        /// <param name="_passWord"></param>
        /// <returns></returns>
        public async static Task<System.Data.DataSet> Hall_LoginAsync(string _userName, string _passWord)
        {
            return await WCFClient.GetInstace().Hall_LoginAsync(_userName, _passWord);
        }

        /// <summary>
        /// 增加日程
        /// </summary>
        /// <param name="title"></param>
        /// <param name="userid"></param>
        /// <param name="Togeter_date"></param>
        /// <param name="Session_id"></param>
        /// <param name="Togeter_hall"></param>
        /// <param name="time_slot"></param>
        /// <param name="realName"></param>
        /// <returns></returns>
        public async static Task<bool> Add_RichengAsync(string title, string userid, string Togeter_date, string Session_id, string Togeter_hall, string time_slot, string realName)
        {
            return await WCFClient.GetInstace().Add_RichengAsync(title, userid, Togeter_date, Session_id, Togeter_hall, time_slot, realName);
        }

        /// <summary>
        /// 修改日程
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="title"></param>
        /// <param name="userid"></param>
        /// <param name="Togeter_date"></param>
        /// <param name="Session_id"></param>
        /// <param name="Togeter_hall"></param>
        /// <param name="time_slot"></param>
        /// <param name="realName"></param>
        /// <param name="is_upload"></param>
        /// <param name="is_upload_en"></param>
        /// <param name="filedir"></param>
        /// <param name="have_video"></param>
        /// <param name="org"></param>
        /// <param name="AuthorizeState"></param>
        /// <param name="mobile_phone"></param>
        /// <returns></returns>
        public async static Task<bool> Update_RichengAsync(string ID, string title, string userid, string Togeter_date, string Session_id, string Togeter_hall, string time_slot, string realName, string is_upload, string is_upload_en, string filedir, string have_video, string org, string AuthorizeState, string mobile_phone)
        {
            return await WCFClient.GetInstace().Update_RichengAsync(ID, title, userid, Togeter_date, Session_id, Togeter_hall, time_slot, realName, is_upload, is_upload_en, filedir, have_video, org, AuthorizeState, mobile_phone);
        }

        /// <summary>
        /// 异步删除项目
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async static Task<bool> DelProgramAsync(string id)
        {
            return await WCFClient.GetInstace().DelProgramAsync(id);
        }

        public async static Task<System.Data.DataSet> Get_Togeter_dateAsync()
        {
            return await WCFClient.GetInstace().Get_Togeter_dateAsync();
        }

        public async static Task<System.Data.DataSet> Get_Togeter_hallAsync()
        {
            return await WCFClient.GetInstace().Get_Togeter_hallAsync();
        }

        public async static Task<bool> ExecuteNonQueryAsync(string strSql)
        {
            return await WCFClient.GetInstace().ExecuteNonQueryAsync(strSql);
        }

        public async static Task<System.Data.DataSet> Get_TableInfoAsync(string strSql)
        {
            return await WCFClient.GetInstace().Get_TableInfoAsync(strSql);
        }

        public async static Task<System.Data.DataSet> Get_RichengAsync(string id, string userid, string Togeter_date, string Session_id, string Togeter_hall, string is_upload, string realName)
        {
            return await WCFClient.GetInstace().Get_RichengAsync(id, userid, Togeter_date, Session_id, Togeter_hall, is_upload, realName);
        }
    }
}
