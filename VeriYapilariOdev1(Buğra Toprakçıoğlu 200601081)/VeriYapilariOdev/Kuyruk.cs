using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace VeriYapilariOdev
{
    public class Kuyruk : IQueue
    {
        private Cagri[] Queue;

        private int front = -1;
        private int back = -1;
        private int size = 0;
        public int count = 0;

        public Kuyruk(int size)
        {
            this.size = size;
            Queue = new Cagri[size];
        }

        public  void Insert(Cagri o)
        {
            if((count==size) || (back == size))
            {
                throw new Exception("Queue Dolu");
            }
            if (front == -1)
            {
                front = 0;
            }
            Queue[++back] = o;
            count++;
        }
        public Cagri Remove()
        {
            if(IsEmpty())
            {
                throw new Exception("Kuyruk boş");
            }
           Cagri temp=Queue[front];
            Queue[front]=null;
            count--;
            front++;
            
            return temp;
        }
        public Boolean IsEmpty()
        {
            return count == 0;
        }
        public Cagri Peek()
        {
            return Queue[front];
        }
        public int Count()
        {
            return count;
        }
        
        //public IEnumerator<object> GetEnumerator()
        //{
        //    return Queue.GetEnumerator();
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return Queue.GetEnumerator();
        //}
        public Cagri Access(int position)
        {
            if (Queue.Count()==0)
            {
               throw new Exception("Kuyruk Boş");
            }
           if (position > Queue.Count())
            {
                throw new InvalidOperationException("Girdiğiniz değer kuyruk uzunluğundan fazla");
            }
            return Queue[position];
        }

    }

}
