package lab6;

import java.util.Scanner;

public class DigitalRoot {
    public static void main(String[] args) {
        int n = enterN();
        int sum = sum(n);
        System.out.println(sum);
    }



    public static int enterN(){
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
    public static int sum(int n){
        int sum=0;
        int x;
        do{
            x = n%10;
            n=n/10;
            sum = sum + x;
        }while(n>0);
        if (sum>9)
            sum = sum(sum);

        return sum;
    }



}
