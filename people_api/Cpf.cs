using System;

public class Cpf
{
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



        throw new NotImplementedException();
    }
}