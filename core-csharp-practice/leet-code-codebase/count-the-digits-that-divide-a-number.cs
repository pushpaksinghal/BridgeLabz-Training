class Solution {
    public int countDigits(int num) {
        int count=0;
        int temp=num;
        while(temp>0){
            int a= temp%10;
            temp=temp/10;
            if(num%a==0){
                count++;
            }
            

        }
        return count;
    }
}