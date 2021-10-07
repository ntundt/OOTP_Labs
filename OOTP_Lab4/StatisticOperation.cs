using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOTP_Lab4
{
    static class StatisticOperation
    {
        public static int Sum(this List<int> list)
        {
            int sum = 0;
            Container<int> ptr = list.FirstElement;
            while (ptr != null)
            {
                sum += ptr.value;
                ptr = ptr.next;
            }
            return sum;
        }

        public static int MinMaxDiff(this List<int> list)
        {
            Container<int> ptr = list.FirstElement;
            int max = ptr.value;
            int min = ptr.value;
            while (ptr != null)
            {
                if (max < ptr.value)
                {
                    max = ptr.value;
                }
                if (min > ptr.value)
                {
                    min = ptr.value;
                }
                ptr = ptr.next;
            }
            return max - min;
        }
        public static int ElementCount(this List<int> list)
        {
            Container<int> ptr = list.FirstElement;
            int length = 0;
            while (ptr != null)
            {
                length++;
                ptr = ptr.next;
            }
            return length;
        }
        public static int WordCount(this List<string> list)
        {
            int count = 0;
            Container<string> ptr = list.FirstElement;
            while (ptr != null)
            {
                if (ptr.value != null)
                {
                    Regex regex = new Regex(@"[^\s]+");
                    count += regex.Matches(ptr.value).Count;
                }
                ptr = ptr.next;
            }
            return count;
        }
        public static bool HasNullElements(this List<string> list)
        {
            Container<string> ptr = list.FirstElement;
            while (ptr != null)
            {
                if (ptr.value == null)
                {
                    return true;
                }
                ptr = ptr.next;
            }
            return false;
        }
    }
}
