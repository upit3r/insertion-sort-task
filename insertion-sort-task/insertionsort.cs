using System;
//init static array and organized the insertion sorting algorithm
namespace insertion_sort_task
{
    class MainClass {
        static int[] arr = new int[] {0,9,0,65,14,1,5,8,4,56,5};
        public static void Main (string[] args) {
            Console.WriteLine("init array:");
            foreach(var item in arr){
            Console.Write(item+" ");
            }
            InsertionSort();
            
            Console.WriteLine("\narray after insertion sort :");
            foreach(var item in arr){
            Console.Write(item+" ");
            }
        }
        public static void InsertionSort(){
            int current;
            int j;
            for(int i = 1;i < arr.Length;i++){   
                j = i-1;
                current = arr[i];      
                while(j >= 0 && arr[j] > current){
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = current;
            }
        }
    }
}
