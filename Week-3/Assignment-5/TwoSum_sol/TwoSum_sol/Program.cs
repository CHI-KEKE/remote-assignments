namespace TwoSum_sol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            //Test 1 Valid input with one pair fullfilled
            int[] nums1 = { 3, 9, 8, 2 };
            int target1 = 10;

            try
            {
                int[] result1 = solution.TwoSum(nums1, target1);
                Console.WriteLine($"Testing! [{string.Join(",", nums1)}], Target : {target1}");
                Console.WriteLine($"The result of Indices : [{result1[0]},{result1[1]}]");
                Console.ReadLine();
            }

            catch(ArgumentException ex)
            {
                Console.WriteLine($"Testing! [{string.Join(", ", nums1)}], Target : {target1}");
                Console.WriteLine($"Exception : {ex.Message}");
                Console.ReadLine();
            }

            // Test 2: Valid input with multiple pairs fullfilled
            int[] nums2 = { 3, 2, 4, 5, 6, 7, 8 };
            int target2 = 9;
            int[] result2 = solution.TwoSum(nums2, target2);
            Console.WriteLine($"Testing! [{string.Join(", ", nums2)}], Target: {target2}");
            Console.WriteLine($"Indices: [{result2[0]}, {result2[1]}]"); 
            Console.WriteLine();


            // Test 3: Valid input with negative numbers
            int[] nums3 = { -3, -8, -1, -6 };
            int target3 = -9;
            int[] result3 = solution.TwoSum(nums3, target3);
            Console.WriteLine($"Testing! [{string.Join(", ", nums3)}], Target: {target3}");
            Console.WriteLine($"Indices: [{result3[0]}, {result3[1]}]"); 
        }
    }
}