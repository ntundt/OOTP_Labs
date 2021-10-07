using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab4
{
    class List<T>
    {
        public Container<T> FirstElement = null;
        public Container<T> LastElement = null;

        private bool Initialized
        {
            get
            {
                return !(this.FirstElement == null || this.LastElement == null);
            }
        }

        private void Initialize(T element)
        {
            Container<T> container = new Container<T>(element);
            this.FirstElement = container;
            this.LastElement = container;
        }

        private class Date
        {
            int Hours { get; set; }
            int Minutes { get; set; }
            public Date(int hours, int minutes)
            {
                this.Hours = hours;
                this.Minutes = minutes;
            }
        }

        private Owner owner;
        private List<T>.Date creationDate;

        public List(List<T> source)
        {
            Container<T> ptr = source.FirstElement;
            while (ptr != null)
            {
                this.InsertHead(ptr.value);
                ptr = ptr.next;
            }
        }

        public List()
        {
            this.owner = new Owner(0, "Mikita Tsikhanovich", "BSTU");
            DateTime now = DateTime.Now;
            this.creationDate = new List<T>.Date(now.Hour, now.Minute);
        }

        public void InsertHead(T element)
        {
            if (!this.Initialized)
            {
                this.Initialize(element);
            }
            else
            {
                Container<T> container = new Container<T>(element);
                this.FirstElement.prev = container;
                container.next = this.FirstElement;
                this.FirstElement = container;
            }
        }

        public void InsertTail(T element)
        {
            if (!this.Initialized)
            {
                this.Initialize(element);
            }
            else
            {
                Container<T> container = new Container<T>(element);
                this.LastElement.next = container;
                container.prev = this.LastElement;
                this.LastElement = container;
            }
        }

        public T RemoveLastElement()
        {
            if (this.LastElement.prev != null)
            {
                this.LastElement.prev.next = null;
                return this.LastElement.value;
            }
            else
            {
                T value = this.LastElement.value;
                this.LastElement = null;
                return value;
            }
        }

        public T RemoveFirstElement()
        {
            if (this.FirstElement.next != null)
            {
                this.FirstElement.next.prev = null;
                return this.FirstElement.value;
            }
            else
            {
                T value = this.FirstElement.value;
                this.FirstElement = null;
                return value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder("");
            Container<T> ptr = this.FirstElement;
            while (ptr != null)
            {
                result.Append(ptr.value);
                result.Append(" ");
                ptr = ptr.next;
            }
            return result.ToString();
        }

        public static List<T> operator +(List<T> list, T item)
        {
            list.InsertTail(item);
            return list;
        }

        public static List<T> operator --(List<T> list)
        {
            list.RemoveLastElement();
            return list;
        }

        public static bool operator ==(List<T> list1, List<T> list2)
        {
            Container<T> ptr1 = list1.FirstElement;
            Container<T> ptr2 = list2.FirstElement;
            while (ptr1 != null && ptr2 != null)
            {
                if (!ptr1.value.Equals(ptr2.value))
                {
                    return false;
                }
                ptr1 = ptr1.next;
                ptr2 = ptr2.next;
            }
            return true;
        }

        public static bool operator !=(List<T> list1, List<T> list2)
        {
            return !(list1 == list2);
        }

        public static List<T> operator *(List<T> list1, List<T> list2)
        {
            List<T> result = new List<T>(list1);
            Container<T> ptr = list1.FirstElement;
            while (ptr != null)
            {
                result.InsertTail(ptr.value);
                ptr = ptr.next;
            }
            return result;
        }

        public static bool operator true(List<T> list)
        {
            if (list.GetType().GenericTypeArguments[0].Name != "Int32")
            {
                return false;
            }
            bool ascending;
            ascending = Convert.ToInt32(list.FirstElement.value.ToString()) < Convert.ToInt32(list.FirstElement.next.value.ToString());
            Container<T> ptr = list.FirstElement;
            int prevValue = Convert.ToInt32(ptr.value.ToString());
            while (ptr != null)
            {
                int value = Convert.ToInt32(ptr.value.ToString());
                if ((ascending && value < prevValue) || (!ascending && value > prevValue))
                {
                    return false;
                }
                ptr = ptr.next;
                prevValue = value;
            }

            return true;
        }

        public static bool operator false(List<T> list)
        {
            if (list)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
