using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace assignment6._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = Product(nums);
            Console.WriteLine(string.Join(",", result));
        }
        public int[] Product(int[] nums)
        {
            int n = nums.Length;

           
            int[] answer = new int[n];

            // Step 1: Fill the prefix product
            answer[0] = 1; // nothing to the left
            for (int i = 1; i < n; i++)
            {
                answer[i] = answer[i - 1] * nums[i - 1];
            }

           
            int suffixProduct = 1; // No elements to the right of the last element
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] *= suffixProduct;
                suffixProduct *= nums[i];
            }

            return answer;
        }
    }
}

