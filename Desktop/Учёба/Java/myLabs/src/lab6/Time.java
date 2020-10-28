package lab6;

import java.util.Scanner;

public class Time {
    public static void main(String[] args) {
        int n = enterTime();
        getTime(n);

    }
    public static int enterTime(){
        Scanner input = new Scanner(System.in);
        int n;
        do{
            System.out.print("Enter n: ");
            n = input.nextInt();
            if(n<=0)
                System.out.println("Error! n must be >0");
        }while (n<=0);
        return (n);
    }
    public static void getTime(int n){

        int hour = n/3600;
        n=n - hour*3600;
        int min = n/60;
        n=n-min*60;
        if(hour<10)
            System.out.print("0"+ hour + ":");
        else
            System.out.print(hour + ":");
        if(min<10)
            System.out.print("0"+ min + ":");
        else
            System.out.print(min + ":");
        if(n<10)
            System.out.print("0"+ n);
        else
            System.out.print(n);

    }
}
