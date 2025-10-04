using DesafioPOO.Models;


List<Smartphone> listaTelefonesIphone = new List<Smartphone>();
List<Smartphone> listaTelefonesNokia = new List<Smartphone>();
bool continuarCadastroTelefone = true;

do
{
    Console.WriteLine("1 - Cadastrar novo Smartphone");
    Console.WriteLine("2 - Listar aparelhos");
    Console.WriteLine("3 - Instalar aplicativo");
    Console.WriteLine("4 - Sair");
    Console.Write("Opção: ");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Deseja Cadastrar qual aparelho\n1 - Nokia\n2 - Iphone\nOpção:  ");
            int opcaoAparelho = int.Parse(Console.ReadLine());
            Smartphone novoAparelho;

            Console.Write("Número: ");
            string numero = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("IMEI: ");
            string imei = Console.ReadLine();
            Console.Write("Memória: ");
            int memoria = int.Parse(Console.ReadLine());

            if (opcaoAparelho == 1)
            {
                novoAparelho = cadastrarNovoAparelhoNokia(numero, modelo, imei, memoria);
                listaTelefonesNokia.Add(novoAparelho);
            }
            else
            {
                novoAparelho = cadastrarNovoAparelhoIphone(numero, modelo, imei, memoria);
                listaTelefonesIphone.Add(novoAparelho);
            }
            break;
        case 2:
            if(listaTelefonesIphone.Count != 0 || listaTelefonesNokia.Count != 0)
            {
                int contPosicao = 1;
                foreach(Smartphone celphone in listaTelefonesIphone)
                {
                    Console.WriteLine($"Aparelho: {contPosicao++}");
                    celphone.MostrarModelo();
                }

                contPosicao = 1;
                foreach (Smartphone celphone in listaTelefonesNokia)
                {
                    Console.WriteLine($"Aparelho: {contPosicao++}");
                    celphone.MostrarModelo();
                }
            }
            else
            {
                Console.WriteLine("Não temos nenhum aparelho cadastrado");
            }
                break;
        case 3:
            if (listaTelefonesIphone.Count() <= 0 && listaTelefonesNokia.Count() <= 0)
            {
                Console.WriteLine("Não existe nenhum aparelho na lista com esse numero");
            }
            else
            {
                Console.Write("Em qual modelo deseja instalar o app 1.Nokia - 2.Iphone\nOpção: ");
                int opcaoInstalar = int.Parse(Console.ReadLine());
                if(opcaoInstalar == 1)
                {
                    Console.Write("Qual o numero da lista para instalar o app: ");
                    int idCelular = int.Parse(Console.ReadLine());
                    if (idCelular <= 0 || idCelular > listaTelefonesNokia.Count())
                    {
                        Console.WriteLine("Não temos nenhum aparelho com essa numeração na lista");
                    }
                    else
                    {
                        Console.Write("Qual app deseja instalar: ");
                        string nomeApp = Console.ReadLine();
                        listaTelefonesNokia[idCelular - 1].InstalarAplicativo(nomeApp);
                    }
                }
                else
                {
                    Console.Write("Qual o numero da lista para instalar o app: ");
                    int idCelular = int.Parse(Console.ReadLine());
                    if (idCelular <= 0 || idCelular > listaTelefonesNokia.Count())
                    {
                        Console.WriteLine("Não temos nenhum aparelho com essa numeração na lista");
                    }
                    else
                    {
                        Console.Write("Qual app deseja instalar: ");
                        string nomeApp = Console.ReadLine();
                        listaTelefonesNokia[idCelular - 1].InstalarAplicativo(nomeApp);
                    }
                }
            }                      
            break;
        case 4:
            Console.WriteLine("Saindo.....");
            continuarCadastroTelefone = false;
            break;
    }
} while (continuarCadastroTelefone);


Smartphone cadastrarNovoAparelhoNokia(string numero, string modelo, string imei, int memoria)
{
    Smartphone novoAparelho = new Nokia(numero, modelo, imei, memoria);
    return novoAparelho;
}
Smartphone cadastrarNovoAparelhoIphone(string numero, string modelo, string imei, int memoria)
{
    Smartphone novoAparelho = new Iphone(numero, modelo, imei, memoria);
    return novoAparelho;
}



// TODO: Realizar os testes com as classes Nokia e Iphone
/*
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("123456", "Modelo 1", "1111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("654321", "Modelo 2", "222222", 120);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");*/