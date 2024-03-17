namespace task2
{
    internal class Program
    {
        public static void hasil(int[] nums)
        {
            int product = 1;
            for (int i = 0; i < nums.Length; i++)
            {
            
                {
                    product = product * nums[i];
                }
             
            }
            Console.WriteLine("elementlerin hasili:"+product);

        }

        static void Main(string[] args)
        {
          int[] nums = {4,5,6,2};
            hasil(nums);
        }
    }
}