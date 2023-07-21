class Program{
    static void Main(String [] args){
     //LEITURA DE DADOS:
      Console.WriteLine("QUal o seu nome? ");
      String nome = Console.ReadLine();
      Console.WriteLine("Quantos anos você tem? ");
      int idade = int.Parse(Console.ReadLine());

      Console.WriteLine("Seu nome é {0} e a sua idedade é de {1}", nome, idade);

    //Inferência:
      var idade1 = 24;
      var salario = 1285.76;

      Console.WriteLine("Idade {0}, Salario {1}", idade1, salario);

    }
}

