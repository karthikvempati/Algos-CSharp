using System;
using System.Collections;
using System.Linq;

namespace lceasy {

    public class Interval {
      public int start;
      public int end;
      public Interval() { start = 0; end = 0; }
      public Interval(int s, int e) { start = s; end = e; }
  }
    public class MeetingRooms
    {
        public bool CanAttendMeetings(Interval[] intervals) { 
            
            //System.Array.Sort(intervals, new Comparison<Interval>((x, y) => x.start > y.start));
            intervals.OrderBy(a => a.start).ToArray();
            for (int i = 0; i < intervals.Length-1; i++)
            {
                if(intervals[i].end > intervals[i+1].start)
                    return false;
            }

            return true;
        }
    }
}