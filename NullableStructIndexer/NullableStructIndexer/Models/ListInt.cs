using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructIndexer.Models
{
    internal class ListInt
    {
        private int[] _arr;

        public int Length { get { return _arr.Length; } }
        public int this[int index] { 
            get
            {
                if (index<_arr.Length)
                {
                    return _arr[index];
                }
                return _arr[_arr.Length-1];
             
              
            }
            set
            {
                if (index<_arr.Length)
                {
                    _arr[index] = value;
                }
               
            }
        }
        public ListInt()
        {
            _arr=new int[0];
        }

        public ListInt(int length)
        {
            _arr = new int[length];
        }

        public ListInt(params int[] arr)
        {
            _arr=arr;
        }


        public void Add(int num)
        {
            Array.Resize(ref _arr, Length + 1);
            _arr[_arr.Length-1] = num;
        }
    }
}
