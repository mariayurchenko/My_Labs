package lab3;

import java.util.Arrays;
import java.util.List;

public class SortList {
    //Вивести в консоль всі зменні в відсортованому вигляді
    //які починаються з "с" та трансформувати їх в вурхній регістр
    public static void main(String[] args) {
        List<String> myList = Arrays.asList("a1", "a2", "b1", "c2", "c1");
        myList.stream().filter(x -> x.startsWith("c")).sorted().map(c-> c.toUpperCase()).forEach(System.out::println);
    }
}
