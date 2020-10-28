package lab6;

import java.util.Scanner;

public class Multiples {
    public static void main(String[] args) {
        System.out.println("This program returns an array of the first x multiples of the real number n. Pleas enter numbers.");
        int x = enterPositiveNumber("Enter x: ");
        int n = enterPositiveNumber("Enter n: ");
        int []arr = findMultipless(x,n);
        System.out.print("findMultiples("+x+", " +n +") => ");
        showArray(arr);
    }
    public static  int enterPositiveNumber(String message){
        Scanner input = new Scanner(System.in);
        int n;
        do{
            System.out.print(message);
            n = input.nextInt();
            if(n<=0)
                System.out.println("Error! The number must be >0");
        }while (n<=0);
        return (n);
    }
    public static int[] findMultipless(int x, int n){
        int[] arr = new int[x];
        int number = n;
        for(int i=0; i<arr.length; i++){
            arr[i]=number;
            number = number +n;
        }
        return arr;
    }
    public static void showArray(int[]arr){
        System.out.print("[");
        for(int i=0; i<arr.length-1; i++){
            System.out.print(arr[i]+ ", ");
        }
        System.out.print(arr[arr.length-1]+"]");
    }
}
