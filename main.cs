public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return 0;
        }
        
        int writePointer = 1; 

        for (int readPointer = 1; readPointer < nums.Length; readPointer++) {

            if (nums[readPointer] != nums[readPointer - 1]) {
                nums[writePointer] = nums[readPointer];
                writePointer++;
            }
        }
        return writePointer;
    }
}
