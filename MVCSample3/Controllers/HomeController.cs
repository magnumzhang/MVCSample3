using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCSample3.Models;
using MVCSample3.Lib;

namespace MVCSample3.Controllers
{
    public class HomeController : MyAuthorizeController
    {
        public ActionResult Index(string JSonPostDataStr)
        {
            return View("View2");
        }

        private static List<MyDataClass> DataCollection;

        static HomeController()
        {
            DataCollection = new MyDataFactory().GenerateData();
        }

        public JsonResult SearchData()
        {
            return Json(DataCollection);
        }

        public void AddData(string JSonPostDataStr)
        {
            Dictionary<string, string> dic = JSonUtility.GetJSonDic(JSonPostDataStr);

            MyDataClass DataClassObj = new MyDataClass(DateTime.Now.ToString("yyyyMMddHHmmss"), Convert.ToInt32(dic["para1"]), dic["para2"], Convert.ToSingle(dic["para3"]), DateTime.Now);
            DataCollection.Add(DataClassObj);
        }

        public void UpdateData(string JSonPostDataStr)
        {
            Dictionary<string, string> dic = JSonUtility.GetJSonDic(JSonPostDataStr);

            string RecordKey = dic["RecordKey"];

            MyDataClass DataClassObj = (from t in DataCollection where t.RecordKey == RecordKey select t).FirstOrDefault();

            if (DataClassObj != null)
            {
                DataClassObj.IntegerData = Convert.ToInt32(dic["para1"]);
                DataClassObj.StringData = dic["para2"];
                DataClassObj.FloatData = Convert.ToSingle(dic["para3"]);
                DataClassObj.DateTimeData = Convert.ToDateTime(dic["para4"]);
            }
        }

        public void DeleteData(string JSonPostDataStr)
        {
            Dictionary<string, string> dic = JSonUtility.GetJSonDic(JSonPostDataStr);
            string RecordKey = dic["RecordKey"];

            MyDataClass DataClassObj = null;

            foreach (MyDataClass t in DataCollection)
            {
                if (t.RecordKey == RecordKey)
                {
                    DataClassObj = t;
                }
            }

            if (DataClassObj != null)
            {
                DataCollection.Remove(DataClassObj);
            }
        }

    }
}