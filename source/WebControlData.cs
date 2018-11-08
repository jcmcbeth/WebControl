using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WebControl
{
    [Serializable]    
    public class WebControlData
    {                
        public string[] Websites { get; set; }
        public ScheduleItem[] Schedule { get; set; }

        public WebControlData() {
            Websites = new string[0];
            Schedule = new ScheduleItem[0];
        }
    }

    [Serializable]
    public class ScheduleItem
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public ScheduleItem() { }
    }
}
