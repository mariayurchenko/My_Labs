package lab4;

import java.io.Console;

public class UniqueNumber {
    public static void main(String[] args) {
        double[]arr=new double[]{1,2,1,2,2,3.5,3,2,3};
        double u = unique(arr);
        System.out.println(u);
    }
    public static double unique(double[] arr){
        Boolean test;
        for(int i=0; i<arr.length; i++){
            test = true;
            for (int j=0; j<arr.length; j++){
                if(arr[i]==arr[j] && i!=j){
                    test = false;
                    j=arr.length;
                }
            }
            if(test)
                return arr[i];
        }
        return 0;
    }
}
