using System;
public class Cnpj
{
    private string cnpj;

    private Cnpj(string cnpj)
    {
        this.cnpj = cnpj;
    }

    public override bool Equals(Object obj)
    {
        if (obj is null)
        {
            return false;
        }

        Cnpj objCnpj = (Cnpj)obj;
        if (objCnpj is null)
        {
            return false;
        }

        return objCnpj.cnpj == this.cnpj;
    }

    public static Cnpj makeCnpj(string possibleCnpj)
    {
        if("".Equals(possibleCnpj))
        {
            throw new EmptyCnpjException();
        }

        if(possibleCnpj.Length < 14 || possibleCnpj.Length > 14)
        {
            throw new InvalidLengthCnpjException();
        }

        foreach (char c in possibleCnpj)
        {
            if (!(char.IsDigit(c)))
            {
                throw new InvalidCharacterCnpjException();
            }
        }

        int[] cnpjNumbers = new int[(possibleCnpj.Length)];

        for (int i = 0; i < (possibleCnpj.Length); i++)
        {
            cnpjNumbers[i] = int.Parse(possibleCnpj[i].ToString());
        }

        int checkDigitOne = int.Parse(possibleCnpj.Substring(12, 1));
        int checkDigitTwo = int.Parse(possibleCnpj.Substring(13, 1));

        int verifyOne = 0;
        int verifyTwo = 0;

        verifyOne = 5 * cnpjNumbers[0] + 4 * cnpjNumbers[1] + 3 * cnpjNumbers[2] + 2 * cnpjNumbers[3];
        verifyOne += 9 * cnpjNumbers[4] + 8 * cnpjNumbers[5] + 7 * cnpjNumbers[6] + 6 * cnpjNumbers[7];
        verifyOne += 5 * cnpjNumbers[8] + 4 * cnpjNumbers[9] + 3 * cnpjNumbers[10] + 2 * cnpjNumbers[11];
        verifyOne = 11 - verifyOne % 11;
        if(verifyOne >= 10)
        {
            verifyOne = 0;
        }

        verifyTwo = 6 * cnpjNumbers[0] + 5 * cnpjNumbers[1] + 4 * cnpjNumbers[2] + 3 * cnpjNumbers[3];
        verifyTwo += 2 * cnpjNumbers[4] + 9 * cnpjNumbers[5] + 8 * cnpjNumbers[6] + 7 * cnpjNumbers[7];
        verifyTwo += 6 * cnpjNumbers[8] + 5 * cnpjNumbers[9] + 4 * cnpjNumbers[10] + 3 * cnpjNumbers[11];
        verifyTwo += 2 * cnpjNumbers[12];
        verifyTwo = 11 - verifyTwo % 11;
        if(verifyTwo >= 10)
        {
            verifyTwo = 0;
        }

        if((verifyOne != checkDigitOne) || (verifyTwo != checkDigitTwo))
        {
            throw new InvalidCnpjException();
        }


        return new Cnpj(possibleCnpj); 
    }
        
}


