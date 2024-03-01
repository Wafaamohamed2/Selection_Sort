using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length : ");
            int len =int .Parse(Console.ReadLine());  
            

            int[] arr=new int[len];
            Console.Write("Enter array elements : ");

            //take the element from user
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Selection_sort(arr, len);




        }


        //method to swap the small nember with the big one in the array
        static  void Swap(int[]arr,int i,int j) {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

       
       static void Selection_sort(int[] arr,int len)
        {
            int min;
            for(int i = 0; i < len-1; i++)
            {
                min = i;
                for(int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min =j;
                    }
                    
                }

               // calling swap method 
               Swap (arr,i,min);
            }


            // Print the sorted array
            Console.Write("Sorted array is : ");

            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
        }
    }
}
