using System;
namespace _4rd_Lab
{
    class AddL_11Ex
    {
        static void Main(string[] args){
            int [] a = {1 , 4 , 6 , 2 , 80 , 100 , 13 , 241};
            int target = -11;
            Array.Sort(a);
            if(BinarySearch(a,0,a.Length - 1,target))
                Console.WriteLine($"The element {target} belongs to the array a");
            else
                Console.WriteLine($"The element {target} does not belong to the array a");
        }
        static bool BinarySearch(int[] a,int left,int right, int target){
            while(left <= right){
                int mid = left + (right - left) / 2;
                if(a[mid] == target)
                    return true;
                if(a[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return false;
        }
    }
}