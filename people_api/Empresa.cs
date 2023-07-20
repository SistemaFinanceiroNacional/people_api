using System;
using System.Collections.Generic;

public class Empresa
{
    private string nome { get; set; }
    private List<Person> empregados { get; set; }
    private Cnpj cnpj;
    private Person dono { get; set; }
    

    public Empresa(string nome, Cnpj cnpj, Person dono, List<Person> empregados)
    {
        this.nome = nome;
        this.cnpj = cnpj;
        this.dono = dono;
        this.empregados = empregados;

    }

    public static Empresa searchEmpresa(Cnpj cnpj,List<Empresa> empresas)
    {
        foreach (Empresa empresa in empresas)
        {
            if (empresa.cnpj.Equals(cnpj))
            {
                return empresa;
            }
        }
        return null;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("CNPJ: " + this.cnpj);
        Console.WriteLine("Dono: " + this.dono);
    }

    public void NewEmployee(Person empregado)
    {
        empregados.Add(empregado);
        empregado.Trabalha(this);
    }


}
