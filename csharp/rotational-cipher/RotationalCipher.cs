using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        //cending each character into a second function to be evaluates 
        string encryptedText = string.Empty;

        
        foreach(char ch in text)  
        encryptedText += cipher(ch, shiftKey);  

        return encryptedText;
    }

    public static char cipher(char ch, int shiftKey) {  
            if (!char.IsLetter(ch)) {  
  
                return ch;  
            }  
  
            char d = char.IsUpper(ch) ? 'A' : 'a';  

            // investigate
            return (char)(
                (
                    (
                        (ch + shiftKey) - d) % 26) + d);  
  
        }  
  

}