package lab3;

import java.util.Scanner;

public class ArithmeticMean {
    //Заповнити масив розміром n рандомними значеннями в діапозоні (від 0 до 9)
    //та порахувати середнє арифметичне всіх парних чисел
        public static void main(String[] args) {
            Scanner input = new Scanner(System.in);
            int n;
            do {
                System.out.print("Enter array length: ");
                n = input.nextInt();
                if (n <= 0)
                    System.out.println("Error! The length of the array must be >0");
            } while (n <= 0);
            int[] arr = new int[n];
            int sum = 0, x = 0;
            System.out.print("Array: ");
            for (int i : arr) {
                arr[i] = (int) Math.round((Math.random() * 10));
                System.out.print(arr[i] + " ");
                if (arr[i] % 2 == 0) {
                    sum = sum + arr[i];
                    x++;
                }
            }
            System.out.println();
            sum = sum / x;
            System.out.println("Arithmetic mean of all paired numbers is " + sum);
        }
}
