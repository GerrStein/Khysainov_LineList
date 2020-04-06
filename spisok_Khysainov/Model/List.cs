﻿using System;


namespace spisok_Khysainov.Model
{
    public class List<T>
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public List()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public List(T data)
        {
            
            SetHeadAndTail(data);
        }

        public void Add(T data)
        {
            
            
        
           if(Tail != null )
           {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
           }
            else
            {
                SetHeadAndTail(data);
            }
        } 

        

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;

        }
            
    }
}

