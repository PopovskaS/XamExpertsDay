using System;
using System.Collections.Generic;

namespace XamExpertsDay.Models
{
    public class Session
    {
        public List<object> questionAnswers { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime startsAt { get; set; }
        public DateTime endsAt { get; set; }
        public bool isServiceSession { get; set; }
        public bool isPlenumSession { get; set; }
        public List<Speaker> speakers { get; set; }
        public List<object> categories { get; set; }
        public int roomId { get; set; }
        public string room { get; set; }
    }
}
