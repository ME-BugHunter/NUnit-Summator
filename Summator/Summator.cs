using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
         

                long sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        public static double Average(int[] arr)
        {
            double sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }

        public static double Multiply(int[] arr)
        {
            int product = 1;
            for (int i=0; i<arr.Length; i++)
            {
                product *= arr[i];
            
            }
            return product;
        }
       

    }
}
