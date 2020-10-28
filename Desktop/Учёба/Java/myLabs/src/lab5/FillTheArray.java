package lab5;

import java.util.Scanner;

public class FillTheArray {
    public static void main(String[] args) {
        int n = enterPositiveNumber("Enter size: ");
        showArray(getArray(n));
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
    public static int[] getArray(int n){
        int[] arr = new int[n];
        int j=0;
        int i=n/2;
        do{
            j++;
            arr[i]=j;
            if(arr[n-1]!=0 && arr[0]==0)
                i=-1;
            i++;
        }while(j!=n);
        return arr;
    }
    public static void showArray(int[] arr){
        System.out.print("[");
        for (int i=0; i<arr.length-1; i++){
            System.out.print(arr[i]+", ");
        }
        System.out.print(arr[arr.length-1]+"]");
    }
}
