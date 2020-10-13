import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class PasswordValidation {
    public static void main(String[] args) {
        Character[] allowedSpecialCharacters = new Character[]{'!', '@', '#', '$', '%', '&', '*'};
        List<Character> allowedSpecialCharactersList = Arrays.asList(allowedSpecialCharacters);
        System.out.println("Enter input password : ");
        Scanner scanner = new Scanner(System.in);
        String input_password = scanner.next();
        int numericLength = 0;
        int specialCharactersLength = 0;
        int totalPasswordLength = input_password.length();

        if (totalPasswordLength < 7) {
            System.out.println("Weak");
        } else {
            for (char ch : input_password.toCharArray()) {
                if (Character.isDigit(ch)) {
                    numericLength += 1;
                } else if (allowedSpecialCharactersList.contains(ch)) {
                    specialCharactersLength += 1;
                }
            }
            if (numericLength > 1 && specialCharactersLength > 1) {
                System.out.println("Strong");
            } else {
                System.out.println("Weak");
            }
        }
    }
}
