class Solution {
    public boolean isPalindrome(int x) {
        if(x<0){
            return false;
        }
        else{
            int r = 0 ;
            int temp=x;
            while(x!=0){
                int a=x%10;
                r = a + 10*r;
                x=x/10;
            }
            if(temp==(int)r){
                return true;
            }
            else{
                return false;
            }
        }
    }
}