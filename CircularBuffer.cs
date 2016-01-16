using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

namespace ViberationScope
{
    class CircularBuffer <T>
    {
        protected T [] Buffer;
        protected UInt32 size;
        protected UInt32 indexPut;
        protected UInt32 indexGet;
        public CircularBuffer(UInt32 _size)
        {
            size = _size;
            Buffer=new T[size];
        }
        public virtual void Put(T elem)
        {
            Buffer[indexPut] = elem;
            indexPut++;
            indexPut %= size;
        }
        public virtual T Get()
        {
            return Buffer[indexGet];
        }
        public virtual T ElementAt(UInt32 i)
        {
            return Buffer[i%size];
        }
    }
    class BlockingCircularBuffer<T>:CircularBuffer<T>
    {
        Semaphore semBuf;
        public BlockingCircularBuffer(UInt32 _size)
            : base(_size)
        {
            semBuf = new Semaphore(0, (int)size - 1);
        }
        public override void Put(T elem)
        {
            try
            {
                base.Put(elem);
                semBuf.Release();
            }
            catch (Exception ex) { }
        }
        public override T Get()
        {
            if (semBuf.WaitOne(1000))
            {
                T retVal = Buffer[indexGet];
                indexGet++;
                indexGet %= size;
                return retVal;
            }
            else
            {
                return Buffer[indexGet];
            }
        }
    }
}
