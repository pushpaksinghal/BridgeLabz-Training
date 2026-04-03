class Solution {
    public boolean lemonadeChange(int[] bills) {
        int []ans =new int [3];
        for(int i=0;i<bills.length;i++){
            if(bills[i]==5){
                ans[0]=ans[0]+1;
            }
            else if(bills[i]==10){
                
                if(ans[0]>0){
                    ans[0]-=1;
                    ans[1]+=1;
                }
                else{
                    return false;
                }
                
            }
            else{
                ans[2]+=1;
                if((ans[0]>0&&ans[1]>0)){
                    ans[0]-=1;
                    ans[1]-=1;
                    ans[2]++;
                }
                else if(ans[0]>2){
                    ans[0]-=3;
                    ans[2]++;
                }
                else{
                    return false;
                }
            }
            
        }
        return true;

        
    }
}