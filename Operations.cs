using System;

class Operations{

    static void Main(string[] args)
    {
        bool run = true;

        Console.WriteLine("Que tipo de operação você gostaria de fazer:\nPessoa física: 1\nPessoa Juridica: 2\nSair: 3");
        int option = int.Parse(Console.ReadLine());

        if(option == 1){

           MenuOne(); 
         
        }else if(option == 2){

            MenuTwo();

        }else if(option == 3)
        {
            Console.WriteLine("Obrigado e volte sempre!");

        }else
        {
            Console.WriteLine("Opção invalida");
        }
         
            
    }

    void MenuOne()
    {
        bool run = true;

        while(run)
            {
                Console.WriteLine("O que gostaria de fazer:\nListar dados de uma pessoa: 1\nRegistrar uma nova pessoa: 2\nSair: 3");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:


                        break;
                    case 2:


                        break;
                    case 3:

                        Console.WriteLine("Obrigado e volte sempre!");
                        run = false;
                        break;

                    default:

                        Console.WriteLine("Opção invalida, tente outra");
                        break;
                }
            }

    }

    void MenuTwo()
    {
        bool run = true;

        while(run)
            {
                Console.WriteLine("O que gostaria de fazer:\nListar dados de uma pessoa juridica: 1\nRegistrar uma nova pessoa juridica: 2\nRegistrar um novo funionario: 3\nSair: 4");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:


                        break;
                    case 2:


                        break;
                    case 3:

                        
                        break;

                    case 4:

                        Console.WriteLine("Obrigado e volte sempre!");
                        run = false;
                        break;

                    default:

                        Console.WriteLine("Opção invalida, tente outra");
                        break;
                }
            }
        
    }

}