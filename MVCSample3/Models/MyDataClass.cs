using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSample3.Models
{
    public class MyDataClass
    {
        public string RecordKey;
        public int IntegerData;
        public string StringData;
        public float FloatData;
        public DateTime DateTimeData;

        public MyDataClass()
        {
        }

        public MyDataClass(string RecordKey, int IntegerData, string StringData, float FloatData, DateTime DateTimeData)
        {
            this.RecordKey = RecordKey;
            this.IntegerData = IntegerData;
            this.StringData = StringData;
            this.FloatData = FloatData;
            this.DateTimeData = DateTimeData;
        }
    }

    public class MyDataFactory
    {
        public List<MyDataClass> GenerateData()
        {
            List<MyDataClass> MyDataList = new List<MyDataClass>();

            for (int i = 0; i < 30; i++)
            {
                MyDataClass DataClassObj = new MyDataClass(Guid.NewGuid().ToString(), 1000 + i + 1, "Str" + (i + 1), 100.01f + i, DateTime.Now);
                MyDataList.Add(DataClassObj);
            }

            return MyDataList;
        }
    }

    public class LoginExt
    {
        public int g1 { get; set; }
    }

    
}