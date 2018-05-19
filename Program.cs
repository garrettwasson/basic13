using System;
using System.Collections.Generic;
namespace Basic13
{
    class Program
    {
        public static void Main(string[] args)
        {
            To255Range();
            OddsRange();
            TotalSum();
            int[] itArr = new int[8] {2,3,5,10,55,13,15,20};
            IterArray(itArr);
            Max(itArr);
            Average(itArr);
            OddArray();
            GreaterThanY(itArr, 10);
            Squared(itArr);
            int[] negativeArr = new int[5] {-1, 7, 10, -2, -4};
            RemoveNegative(negativeArr);
            MinMaxAvg(itArr);
            int[] shiftArray = new int [5] {4,7,8,6,9};
            ShiftArray(shiftArray);
            object[] Box = new object[3] {-1, -3, -2};
            NumString(Box);
        }
        public static void To255Range(){
            for (int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
        }
        public static void OddsRange(){
            for (int i = 1; i <= 255; i++){
                if (i % 2 != 0)
                Console.WriteLine(i);
            }
        }
        public static void TotalSum(){
            int Sum = 0;
            for (int i = 0; i <= 255; i++){
                Sum += i;
                Console.WriteLine("The sum is " + Sum + "!");
            }
        }

        public static void IterArray(int[] arr){
            foreach (int numbers in arr){
                Console.WriteLine(numbers);
            }
        }
        public static void Max(int[] arr){
            int maxNumb = arr[0];
            foreach (int numbers in arr){
                if (numbers > maxNumb){
                    maxNumb = numbers;
                }
            }
            Console.WriteLine(maxNumb);
        }
        public static void Average(int[] arr){
            int sum = 0;
            foreach (int num in arr){
                sum += num;
            }
            double castSum = (double)sum;
            double avg = (castSum / arr.Length);
            Console.WriteLine(avg);
        }
        public static void OddArray(){
            List<int> odds = new List<int>();
            for (int i = 1; i <= 255; i++){
                if (i % 2 != 0){
                    odds.Add(i);
                }
            }
            int[] oddsArr = odds.ToArray();
            string output = "";
            foreach (int num in oddsArr){
                output += num + " , ";
            }
            output += "";
            Console.WriteLine(output);
        }
        public static void GreaterThanY(int[] arr, int y){
            int total = 0;
            foreach (int num in arr){
                if (num > y){
                    total += 1;
                }
            }
            Console.WriteLine(total);
        }
        public static void Squared(int[] arr){
            for (int idx = 0; idx < arr.Length; idx++){
                arr[idx] *= arr[idx];
            }
            string output = "";
            foreach (int num in arr){
                output += num + " , ";
            }
            output += "";
            Console.WriteLine(output);
        }
        public static void RemoveNegative(int[] arr){
            for (int idx = 0; idx < arr.Length; idx++){
                if (arr[idx] < 0){
                    arr[idx] = 0;
                }
            }
            string output = "";
            foreach (int num in arr){
                output += num + " , ";
            }
            output += "";
            Console.WriteLine(output);
        }
        public static void MinMaxAvg(int[] arr){
            int max = arr[0];
            int min = arr[0];
            int sum = 0;
            foreach (int num in arr){
                sum += num;
                if (num > max){
                    max = num;
                }
                else if (num < min){
                    min = num;
                }
            }
            double castSum = (double)sum;
            double avg = (castSum / arr.Length);
            Console.WriteLine("Min: {0}, Max: {1}, Avg: {2}", min, max, avg);
        }
        public static void ShiftArray(int[] arr){
            for (int idx = 0; idx < arr.Length-1; idx++){
                arr[idx] = arr[idx + 1];
            }
            arr[arr.Length-1] = 0;
            string output = "";
            foreach (int num in arr){
                output += num + " , ";
            }
            output += "";
            Console.WriteLine(output);
        }
        public static object[] NumString(object[] arr){
            for (int idx = 0; idx < arr.Length; idx++){
                if ((int)arr[idx] < 0){
                    arr[idx] = "Dojo";
                }
            }
            return arr;
        }
    }
}