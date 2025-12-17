class Solution {
    public int findContentChildren(int[] g, int[] s) {
        Arrays.sort(g);
        Arrays.sort(s);
        int a = g.length-1;
        int e = s.length-1;
        int re =0;
        while(e>=0&&a>=0){
            if(g[a] <=s[e]){
                re+=1;
                e--;
            }
            a--;
        }
        return re;
    }
}