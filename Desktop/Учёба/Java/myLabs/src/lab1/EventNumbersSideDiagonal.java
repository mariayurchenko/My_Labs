package lab1;

public class EventNumbersSideDiagonal {
    //Створити двовимірний масив, заповнити його випадковими значеннями від 0 до 9(Random).
    //Вивести його на єкран окремим методом (private void printArray(int [][]arr)).
    //Вивести на єкран всі парні числа побічної діагоналі.
    public static void main(String[] args) {
        int size = 5;
        int[][] arr = new int [size][size];
        arr = randomArray(arr);
        System.out.print("Array: \n");
        printArray(arr);
        int [] sd = new int [5];
        sd = sideDiagonal(arr);
        System.out.print("Event numbers side diagonal: \n");
        printEventNumbers(sd);
    }
    private static int[][] randomArray(int [][]arr){
        for(int i=0; i<5;i++){
            for(int j=0; j<5; j++){
                arr[i][j] = (int) (Math.random()*10);
            }
        }
        return arr;
    }
    private static void printArray(int [][]arr){
        for(int i=0; i<5;i++){
            for(int j=0; j<5; j++){
                System.out.print(arr[i][j]+ " ");
            }
            System.out.print("\n");
        }
    }
    private static int[] sideDiagonal(int [][]arr){
        int [] sd = new int [5];
        int j=4;
        for(int i = 0; i<5; i++){
            sd[i] = arr[i][j];
            j--;
        }
        return sd;
    }
    private static void printEventNumbers(int []arr){
        int test=0;
        for(int i=0; i<5; i++){
            if(arr[i]%2==0)
                System.out.print(arr[i] + " ");
            else
                test++;
        }
        if(test==5)
            System.out.print("The side diagonal hasn't event numbers!");
        else
            System.out.print("\n");
    }
}
