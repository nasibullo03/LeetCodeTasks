using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
           
            var s4 = sol.IsValid("{}[](){([])}{}");
            Console.WriteLine($"{s4}");

            Console.ReadLine();
        }
    }
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (!CheckValue(s)) return false;

            while (s != "")
            {
                var splitValue = s.Split(new string[] { "[]", "{}", "()" }, StringSplitOptions.RemoveEmptyEntries);
                
                var ConcatValue = string.Concat(splitValue);
                
                if (ConcatValue == s) break;
                
                s = ConcatValue;
                
                if (s == "") return true;
                
                if (splitValue.Length == 0) return true;

            }

            return false;

        }

        private bool CheckValue(string s)
        {
            string characters = "(){}[]";
            if (s == "" || s.Length > 10000) return false;
            if (s.Length % 2 != 0) return false;
            foreach (var item in s)
            {
                if (!characters.Contains(item)) return false;
            }
            return true;
        }

    }

}
