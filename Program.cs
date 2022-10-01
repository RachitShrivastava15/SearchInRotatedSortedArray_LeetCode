namespace SearchInRotatedSortedArray
{
    class Pragram
    {
        static void Main(string[] args)
        {
            int[] nums= {4,5,6,7,0,1,2};
            int target = 0;
            int result = Search(nums, target);
            Console.WriteLine(result);
        }

        public static int Search(int[] nums, int target) {
            if(nums == null || nums.Length == 0)
                return -1;
            int left = 0, right = nums.Length -1;
            
            while (left <= right)
            {
                int mid = left + (right - left) /2;
                if(target == nums[mid])
                    return mid;
                else if (nums[mid] >= nums[left])
                {
                    if (target >= nums[left] && target < nums[mid])
                        right = mid -1;
                    else
                        left = mid +1;
                }
                else {
                    if(target > nums[mid] && target <= nums[right])
                        left = mid + 1;
                    else
                        right = mid -1;
                }
            }
            return -1;
        }
    }
}