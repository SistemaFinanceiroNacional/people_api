using System;
using System.Numerics;

public class Cpf
{
    private string cpf;
    private Cpf(string cpf)
    {
        this.cpf = cpf;
    }

    public static Cpf makeCpf(string possibleCpf)
    {
        if("".Equals(possibleCpf))
        {
            throw new EmptyCpfException();
        }
        if(possibleCpf.Length < 11 || possibleCpf.Length > 11)
        {
            throw new InvalidLengthCpfException();
        }
        foreach(char c in possibleCpf)
        {
            if(!(char.IsDigit(c)))
            {
                throw new InvalidCharacterCpfException();
            }
        }

        int[] cpfNumbers = new int[(possibleCpf.Length) - 2];
        
        for(int i = 0; i < (possibleCpf.Length) - 2; i++)
        {
            cpfNumbers[i] = int.Parse(possibleCpf[i].ToString());
        }

        Array.Reverse<int>(cpfNumbers);

        int checkDigitOne = int.Parse(possibleCpf.Substring(9, 1));
        int checkDigitTwo = int.Parse(possibleCpf.Substring(10, 1));

        int verifyOne = 0;
        int verifyTwo = 0;

        for (int k = 0; k < (cpfNumbers.Length); k++)
        {
            verifyOne = verifyOne + cpfNumbers[k] * (9 - (k % 10));
            verifyTwo = verifyTwo + cpfNumbers[k] * (9 - ((k + 1) % 10));
        }
        verifyOne = (verifyOne % 11) % 10;
        verifyTwo = verifyTwo + verifyOne * 9;
        verifyTwo = (verifyTwo % 11) % 10;

        if((verifyOne != checkDigitOne) || (verifyTwo != checkDigitTwo))
        {
            throw new InvalidCpfException();
        }


        return new Cpf(possibleCpf);
    }
}