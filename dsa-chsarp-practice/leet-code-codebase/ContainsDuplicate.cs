public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> dup = new HashSet<int>();

        foreach(int index in nums){
            if(!dup.Add(index)){
                return true;
            }
        }
        return false;
    }
}