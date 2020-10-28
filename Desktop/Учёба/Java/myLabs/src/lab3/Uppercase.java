package lab3;


public class Uppercase {
    //Даний рядок (рандомні букви в нижньому регістрі). Підняти всі букви в діапозоні від H до L по алфавіту
    public static void main(String[] args) {
        String str = "wrshedxcgljknnc";
        String s = newStr(str);
        System.out.println(str+" -> "+s);

    }
    private static String newStr(String str){
        char[] s = str.toCharArray();
        for(int i=0; i<s.length; i++){
            if('h' <=s[i] && s[i]<= 'l')
                s[i] = Character.toUpperCase(s[i]);
        }
        str = new String(s);
        return str;
    }
}
