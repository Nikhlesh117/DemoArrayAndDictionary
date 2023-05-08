using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class demoDictionarty
    {
        //Dictionary is a generic collection that consist of element.
        // As Key Value Pair.
        //It is not Sorted Order.
        Dictionary<string,string> dictionary = new Dictionary<string,string>();
        public void dict()
        {
            dictionary.Add("1","Nk");
            dictionary.Add("2", "apple");
            dictionary.Add("3", "banana");
            dictionary.Add("4", "mango");
            dictionary.Add("5", "orange");

            Console.WriteLine(dictionary["3"]);
            Console.WriteLine(dictionary["4"]);
            //Console.WriteLine(dictionary["apple"]);
            //Modify by using Key.
            dictionary["2"] = "Pineapple";
            //
            foreach(KeyValuePair<string,string> KVP in dictionary)
            {
                Console.WriteLine(KVP.Key+" : "+KVP.Value);
            }

            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "Car");
            dict.Add(2, "Bike");
            dict[3] = "Truck";
            //Remove the value.
            dict.Remove(3);

            if (dict.ContainsKey(2))
            {
                dict[2] = "Cycle";
            }

            foreach (KeyValuePair<int,string> KVP in dict)
            {
                Console.WriteLine(KVP.Key + " : " + KVP.Value);
            }
            //Clear method is use to clear the dictionary.
            dict.Clear();
            Console.WriteLine(dict.Count);
            
            


        }
    }
}
