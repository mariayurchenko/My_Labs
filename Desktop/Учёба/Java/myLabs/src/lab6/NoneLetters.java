package lab6;

import java.util.Scanner;

public class NoneLetters {

    public static void main(String[] args){
        System.out.print("Enter your blacklist -> ");
        Scanner input = new Scanner(System.in);
        String bl = input.nextLine();
        System.out.print("Enter your sentence -> ");
        String myStr = input.nextLine();
        System.out.println(hasNoneLetters(myStr,bl));
    }
    static boolean hasNoneLetters(String str, String bl){
        char blackList[] = bl.toCharArray();
        char arr[] = str.toCharArray();
        for(int i = 0; i < arr.length; i++){
            for(int j=0; j<blackList.length; j++) {
                if(Character.toLowerCase(arr[i])==Character.toLowerCase(blackList[j]))
                    return false;
            }
        }
        return true;
    }
}
