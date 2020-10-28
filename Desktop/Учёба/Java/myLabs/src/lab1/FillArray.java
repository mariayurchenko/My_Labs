package lab1;

public class FillArray {
    //Створити метод private  int[] fillArray(int begin, int end, int step).
    //Який заповнює масив від begin до end, з кроком в step.
    //Приклад: fillArray(0,10,2) -> [0, 2, 4, 6, 8, 10] end - begin
    public static void main(String[] args) {
        System.out.print("fillArray(0,10,2) -> [");
        printFillArray(fillArray(0,10,2));
        System.out.print("fillArray(-20,-6,3) -> [");
        printFillArray(fillArray(-20,-6,3));
    }
    private static int[] fillArray(int begin, int end, int step){
        int size=(end-begin)/step+1;
        int [] arr=new int [size];
        if(begin<end) {
            int j = 0;
            for (int i = begin; i <= end; i = i + step) {
                arr[j] = i;
                j++;
            }
        }
        return arr;
    }
    private static void printFillArray(int[]arr){
        for (int i=0; i<arr.length; i++){
            System.out.print(arr[i]+ " ");
        }
        System.out.print("] end - begin \n");
    }
}
