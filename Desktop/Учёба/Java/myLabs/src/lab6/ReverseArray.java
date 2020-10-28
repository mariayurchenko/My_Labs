package lab6;

import java.util.Scanner;

public class ReverseArray {
    public static void main(String[] args) {
        String [] arrayString = enterArray();
        System.out.print("Input: ");
        showArray(arrayString);
        System.out.print("\nOutput: ");
        String [] reverse = reverseArray(arrayString);
        showArray(reverse);
    }
    public static String[] enterArray(){
        Scanner input = new Scanner(System.in);
        int n;
        System.out.println("Enter the size og the array:");
        do{
            System.out.print("n = ");
            n = input.nextInt();
            if(n<=0)
                System.out.println("Error! n must be >0");
        }while (n<=0);
        String [] arr = new String[n];
        System.out.println("Please, enter strings. Use the button 'Enter'.");
        input.nextLine();
        for(int i=0; i<n; i++){
            arr[i] = input.nextLine();
        }
        return arr;
    }
    public static <string> void showArray(string[]arr){
        System.out.print("[");
        for(int i=0; i<arr.length-1; i++){
            System.out.print("'"+arr[i]+ "', ");
        }
        System.out.print("'" + arr[arr.length-1]+"']");
    }
    public static <string> String[] reverseArray(string [] arr){
        String []newArray = new String[arr.length];
        char [] arrayChar = new char[lengthAllStrings(arr)];
        int l=0;
        for(int i=0; i<arr.length; i++){
            for(int j=0; j<arr[i].toString().length(); j++){
                arrayChar[l] = arr[i].toString().charAt(j);
                l++;
            }
        }
        int lastLetter = arrayChar.length;
        for(int i=0; i<arr.length; i++){

            int size = arr[i].toString().length();
            char[] word = new char[size];
            for(int j=0; j<size; j++){
                lastLetter--;
               word[j] = arrayChar[lastLetter];

            }
            newArray[i]= new String(word);
        }
        return newArray;
    }
    public static <string> int lengthAllStrings(string []arr){
        int l = 0;
        for(int i=0; i< arr.length; i++){
            l+=arr[i].toString().length();
        }
        return l;
    }
}
