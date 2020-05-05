using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ric2_kr_1
{
    [Serializable]
    public class Subscribe
    {
        public int id {get; set;}
        public string title {get; set;}
        public string price {get; set;}
        public string startTime {get; set;}
        public string endTime {get; set;}
    }
}