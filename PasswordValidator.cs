using System;
using System.Text;
using System.Linq;

/* Write a program that takes in a string as input and evaluates it as a valid password.
The password is valid if it has at a minimum 2 numbers,
2 of the following special characters ('!', '@', '#', '$', '%', '&', '*'), and a length of at least 7 characters.*/

class PasswordValidator {
  
  private static string checkPassword(string password) {
    int numberCount = 0;
    int symbolCount = 0;
    if(password.Length <= 6) {
        return "Weak";
    }
    int[] symbols = {33, 64, 35, 36, 37, 38, 42};
    
    // Convert characters to ASCII
    byte[] asciiBytes = Encoding.ASCII.GetBytes(password.ToLower());
    
    // separate the symbols
    byte[] userSymbols = new byte[asciiBytes.Length];
    int count = 0;
    for (int i=0; i<asciiBytes.Length; i++) {
        if (!(asciiBytes[i] >= 48 && asciiBytes[i] <= 57 || asciiBytes[i] >= 97 && asciiBytes[i] <= 122)) {
            userSymbols[count] = asciiBytes[i];
            count += 1;
        }
    }
    
    // Check the user symbols with default symbols
    bool symbolCheck = false;
    int tempCount = 0;
    foreach (byte i in userSymbols) {
        if (i != 0) {
            foreach (int j in symbols) {
                if (i == j) {
                    symbolCheck = true;
                    symbolCount += 1;
                    break;
                } else {
                    symbolCheck = false;
                }
            }
            tempCount += 1;
            if (symbolCheck == false && symbolCount != tempCount) {
                break;
            }
        }
    }

    // Count the numbers in the password
    for(int i=0; i<password.Length; i++) {
        if(Char.GetNumericValue(password[i]) != -1) {
            numberCount += 1;
        }
    }

    // Final check to validate the password
    if(numberCount >= 2 && symbolCount >= 2 && symbolCheck) {
        return "Strong";
    }
    return "Weak";
  }
  
  static void Main() {
    Console.WriteLine("Enter password to check: ");
    string password = Console.ReadLine();
    Console.WriteLine(password + " : " + checkPassword(password));
    // Console.WriteLine(checkPassword("&%$#@@##")); // No numbers : Weak
    // Console.WriteLine(checkPassword("78%#$@#%)()()")); // required numbers, required symbols, but additional symbols : Weak
    // Console.WriteLine(checkPassword("893829#%@$")); // required numbers, required symbols : Strong
  }
  
}


