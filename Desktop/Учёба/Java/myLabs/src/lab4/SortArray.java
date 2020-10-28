package lab4;

import java.util.function.IntPredicate;
import java.util.stream.IntStream;

public class SortArray {
    public static void main(String[] args) {
        int[]arr=new int[]{5,3,2,8,1,4};
        showArray(arr);
        System.out.print(" -> ");
        showArray(sortArray(arr, (n) -> n % 2 != 0));
    }

    public static int[] sortArray(int[] array, IntPredicate predicate){
        int[] filtered = IntStream.of(array).filter(predicate).sorted().toArray();
        int[] newarray = new int[array.length];
        for (int i = 0, j = 0; i < array.length; i++) {
            newarray[i] = predicate.test(array[i]) ? filtered[j++] : array[i];
        }
        return newarray;
    }
    public static void showArray(int[] arr){
        System.out.print("[");
        for (int i=0; i<arr.length-1; i++){
            System.out.print(arr[i]+", ");
        }
        System.out.print(arr[arr.length-1]+"]");
    }
}
