using System.Collections.Generic;
using UnityEngine;

namespace Utilies
{ 
   public class Hash_Map : MonoBehaviour
   {
       private List<int>[] hash_map;

       public Hash_Map()
       {
            hash_map = new[] { new List<int>() };
       }
       public static int computer_hash(int value_to_hash, int hash_map_length)
       {
           if (hash_map_length == 0)
           {
               return -1;
           }

           return value_to_hash % hash_map_length;
       }

       public void put(int new_value)
       {
            int hash = computer_hash(new_value, hash_map.Length);

            if(hash_map[hash].Count == 0)
            {
                hash_map[hash].Add(new_value);
            }
            else
            {
                int i;
                for (i = 0; i < hash_map[hash].Count; i++)
                {
                   hash_map[hash][i] = new_value;
                }
               
            }
       }

       public int get(int new_value_search)
       {
            return -1;
       }
   }
}
