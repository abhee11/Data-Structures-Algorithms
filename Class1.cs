using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class HashTable
    {

        class HashEntry
        {
            private int key;
            private string value;

            public HashEntry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }

            public int GetKey()
            {
                return key;
            }

            public string GetValue()
            {
                return value;
            }
        }
        public class HashTableUsingArray
        {
            private int size = 128;
            HashEntry[] newHashTable;
            public HashTableUsingArray()
            {
                newHashTable = new HashEntry[size];
                for(int i =0; i<size; i++)
                {
                    newHashTable[i] = null;
                }
            }

            public string Get(int key)
            {
                int hash = key%size;
                while(newHashTable[hash] != null && newHashTable[hash].GetKey() != key)
                {
                    hash = (hash + 1) % size + 10 % 3;
                }
                if(newHashTable[hash].GetKey() == key)
                {
                    return newHashTable[hash].GetValue();
                }
                else {
                    return "Key not found";
                }
            }
            
            public void Put(int key, string value)
            {
                int hash = key%size;
                while(newHashTable[hash] != null && newHashTable[hash].GetKey() != key)
                {
                    hash = (hash+1)%size;
                }
                newHashTable[hash] = new HashEntry(key, value);
            }
        }
        
        public static void ImplementHashTableinCSharp()
        {
            Dictionary<string, int> EmployeeID = new Dictionary<string, int>();
            EmployeeID.Add("Susan", 24);
            EmployeeID.Add("Robert", 42);
            EmployeeID.Add("Abhinav", 26);
            EmployeeID.Add("Amith", 24);
            EmployeeID.Add("Mukul", 22);

            int getAge =0;
            if(EmployeeID.TryGetValue("Susan", out getAge))
            {
                Console.WriteLine("The age of the given emplyee is :" + getAge);
            }

            foreach(var match in EmployeeID)
            {
                if(match.Value<35 )
                Console.WriteLine("\n The key is : " + match.Key + " & the value is : " + match.Value);
            }
        }

        public static string ReverseString(string Str)
        {
            char[] StrCh= Str.ToCharArray();
            for (int i = 0; i < StrCh.Length/2; i++)
            {
                char c = StrCh[i];
                StrCh[i] = StrCh[Str.Length - 1 - i];
                StrCh[Str.Length - 1 - i] = c;
            }
            Console.WriteLine(StrCh);
            return StrCh.ToString();
        }

        public static void PrintTables()
        {
            for (int i =1;i<13;i++)
            {
                for(int j =1;j<13;j++)
                {
                    Console.Write("\t"+i * j);
                }
                Console.WriteLine("\n                                                                                                                                                              ");            
            }
        }
    }
}
