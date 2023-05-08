using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    //ArrayList is non generic collection.
    //stores the element of multiple data types
    //size can be change dynamically.
    //when the data type and data size is unknown we can ArrayList.
    public class demoArraylist
    {
        public void ArrayDemo()
        {
            //Add
            /*ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(4);
            arrayList.Add(4);
            arrayList.Add(4);
            arrayList.Add(5);
            //Insert
            arrayList.Insert(0, 58);
            arrayList.Insert(4, 58);

            //arrayList.Remove(1);
            //arrayList.RemoveAt(4);
            //arrayList.RemoveRange(2,4);

            int count = arrayList.Count;
            Console.WriteLine("count :" + count);

            //arrayList.Clear();
            //int counts = arrayList.Count;
            //Console.WriteLine("count :" + counts);
            arrayList.Sort();
            


            /*foreach (int i in arrayList)
            {
                Console.WriteLine(i);
            }*/
            /*
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            */
        }

    }
}
