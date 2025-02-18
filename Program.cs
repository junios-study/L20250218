using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20250218
{
    class DynamicArray
    {
        public DynamicArray()
        {

        }

        ~DynamicArray()
        {

        }

        //objects
        //[1][2][3]
        // ^  ^  ^  ^
        //newObjects
        //[1][2][3][][][]
        //          ^
        //objects <- newObjects 
        //[1][2][3][4][][]
        //          ^
        public void Add(Object inObject)
        {
            if (CurrentPosition >= objects.Length)
            {
                //배열 늘이기
                //이전 정보 옮기기
                Object[] newObject = new Object[objects.Length * 2];
                //이전값 이동
                for (int i = 0; i < objects.Length; ++i)
                {
                    newObject[i] = objects[i];
                }
                objects = null;
                objects = newObject;
            }
            objects[CurrentPosition] = inObject;
            CurrentPosition++;
            count = CurrentPosition;
        }

        //[][][][][]
        public void Remove(Object removObject)
        {

        }

        public void RemoveAt(int index)
        {

        }

        protected Object[] objects = new Object[3];


        protected int CurrentPosition = 0;

        public int count = 0;
        public int Count
        {
            get
            {
                return count;
            }
        }

        public Object this[int index]
        {
            get
            {
                return objects[index];
            }
            set
            {
                if (index < objects.Length)
                {
                    objects[index] = value;
                }
            }
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            //[] ->                  variable
            //[][][][][]             array -> Array
            //[][][][][][][][][][]   DynamicArray
            //DataStructure          자료구조
            //

            DynamicArray a = new DynamicArray();
            for (int i = 0; i < 10; ++i)
            {
                a.Add(i);
            }

            a[1] = 11;
            a[9] = 29;

            for (int i = 0; i < a.Count; ++i)
            {
                Console.Write(a[i] + ", ");
            }
        }
    }
}
