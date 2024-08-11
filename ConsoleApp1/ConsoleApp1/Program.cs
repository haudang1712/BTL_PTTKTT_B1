using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static int BinarySearch(int[] array, int left, int right, int target)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;

                if (array[mid] > target)
                    return BinarySearch(array, left, mid - 1, target);

                return BinarySearch(array, mid + 1, right, target);
            }

            return -1;
        }

        static void Main()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;

            int[] array = { 2, 3, 4, 10, 20, 25, 30, 40, 42, 43, 45, 50, 55};
            int target = 42;

            int result = BinarySearch(array, 0, array.Length - 1, target);

            if (result == -1)
                Console.WriteLine("Không tìm thấy phần tử trong mảng");
            else
                Console.WriteLine("Phần tử được tìm thấy tại chỉ số: " + result);
            Console.ReadKey();
        }
    }

}
