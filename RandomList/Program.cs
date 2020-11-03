using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    public class RandomList : List<string>
    {
        List<string> aList = new List<string>();  //define a new list called aList

        public string RandomString()      //this method will remove a string from aList and will return it
        {
            
            Random rnd = new Random();    //call the random function to create a new random element
            int randomIndex = rnd.Next(0, aList.Count);   //chose a random number between 0 and the length of aList. This will be the index of the string to be removed
            string ChosenForRemoval = aList[randomIndex];  //identify the string having the index identified above

            aList.RemoveAt(randomIndex);  //remove this string from aList. We use its index since we have it
            return ChosenForRemoval;      //return the removed string from aList
        }
    }
}
