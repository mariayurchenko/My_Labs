package lab6;
import java.util.Scanner;

public class LongestWord {
    public static final String ANSI_RESET = "\u001B[0m";
    public static final String ANSI_RED = "\u001B[31m";
    public static void main(String[] args) {
        System.out.print("This program find the longest word and returns it's length.");
        System.out.print("\nEnter a string:-> ");
        Scanner input = new Scanner(System.in);
        String temp = input.nextLine();
        String words[] = temp.split(" ");
        int longestWord = findLongestWord(words);
        System.out.print("The longest word is "+ANSI_RED+words[longestWord]+ANSI_RESET+": "+
                lengthWord(words[longestWord])+" letters.");
    }
    public  static <string> int findLongestWord(string arr[]){
        int longestWord = 0;
        for(int i=1; i<arr.length; i++)
            if(lengthWord(arr[i])>lengthWord(arr[longestWord]))
                longestWord = i;
        return longestWord;
    }
    public static <string> int lengthWord(string str){
        int l = str.toString().length();
        return l;
    }
}
