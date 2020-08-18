using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace MenuBuilder
{
    public class MainMenu :IMenu
    {
        

        public void Run<TKey,TValue>(Dictionary<TKey, TValue> menuDict)
        {
            bool showMenu = true;
            


                Console.WriteLine("Choose an option from the menu: ");
                foreach(KeyValuePair<TKey,TValue> item in menuDict)
                {
                    Console.WriteLine("{0} {1}", item.Key, item.Value);
                }
                Console.ReadLine();
            }
            
            
        }

       
        public void AddOption<TKey, TValue>(ref TKey value,ref TValue key)
        {
            Dictionary<TKey, TValue> menuDict = new Dictionary<TKey, TValue>();
            menuDict.Add(value, key);
        }

        
    }
}
