using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StackOfStrings
{
    class StackOfStrings
    {
        private List<string> data = new List<string>();
        public void Push(string item)  //to add a string to the list data.
        {
            data.Add(item);
        }
        public string pop()   //pop removes and returns the top item, or the last element, of a stack, or a list
        {
            string poped = data[data.Count -1];    //to read the last element of the list data. For C# 8.0 one can use data[^1] to get to the last element
            data.RemoveAt(data.Count -1);
            return poped;
        }
        public string peek()  //peek returns the top element, or the last element, of a stack, or a list
        {
            string topWord = data[data.Count -1];   //selecting the last element. For C# 8.0 one can use data[^1] to get to the last element
            return topWord;              //returning the last element
        }
        public bool IsEmpty()
        {
            return data.Count==0;  //if it is empty, this will return true because the list length will be 0.
        }
    }
}
