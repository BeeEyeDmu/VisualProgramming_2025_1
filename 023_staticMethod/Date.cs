using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_staticMethod
{
  internal class Date
  {
    public int year, month, day;

    public static bool IsLeapYear(int y)
    {
      // 윤년은 4로 나누어지고 100으로는 나누어지지 않는 해
      // 그런데 400으로 나누어지면 윤년
      return (y % 4 == 0 && y % 100 != 0) || y % 400 == 0;
    }

    static int[] days =
      {0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334};

    public int DayOfYear()
    {
      //if (month > 2 && IsLeapYear(year)) 
      //  return days[month - 1] + day + 1;     
      //else
      //  return days[month - 1] + day;

      return days[month - 1] + day 
        + (month > 2 && IsLeapYear(year) ? 1 : 0);
    }
  }
}
