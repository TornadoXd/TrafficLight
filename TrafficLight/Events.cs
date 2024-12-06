using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    public static class Events
    {
        // האירוע שיתרחש כשצבע הרמזור ישתנה, הוא היוזם של האירוע
        // הדמויות יגיבו לאירוע
        public static Action<TrafficLight.light> OnChange;
    }
}
