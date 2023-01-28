package ReverseTheStringWithDot;
//https://practice.geeksforgeeks.org/problems/reverse-words-in-a-given-string5459/1?page=1&status[]=solved&sortBy=submissions
public class Main {
    public static void main(String[] args) {

        String s ="i.like.this.program.very.much";
        reversed(s);
        System.out.print(reversed(s));
    }

    static String reversed(String s){

        String result ="";
        String[] res = s.split("[.]");
        for(int i =res.length-1;i>=0;i--) {
            result+=(res[i]+".");

        }
       // System.out.print(result);
         return result.substring(0,result.length() - 1);
    }
}