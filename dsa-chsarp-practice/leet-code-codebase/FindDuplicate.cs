public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> dup = new HashSet<int>();

        foreach(int x in nums){
            if(!dup.Add(x)){
                return x;
            }
        }
        return 0;
    }
}