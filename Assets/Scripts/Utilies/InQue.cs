using System;
using System.Collections.Generic;
using UnityEngine;

namespace Utilies
{
    [Serializable]
   public class InQue <T>
   {
       [SerializeField] private List<T> que;

       public InQue()
       {
            que = new List<T>();
       }

       public void Enque (T next_element)
       {
          que.Add(next_element);
       }

       public T Peek()
       {
           if (que.Count == 0)
           {
               throw new Exception("Queue is empty, cannot peek");
           }

           return que[0];
       }

       public T Deque()
       {
           if (que.Count == 0)
           {
               throw new Exception("Queue is empty, cannot dequeue");
           }

           T top_of_que = que[0];
           que.RemoveAt(index: 0);
           return top_of_que;
       }

       public void CLear()
       {
           que.Clear();
       }

   }
}
