// Operadores relacionais:Os operadores relacionais são responsáveis por retornar à relação entre duas
// variáveis. Essa relação é retornada na forma de verdadeiro ou falso, por exemplo,
// determinada variável é maior que outra, ou menor, dentre outras relações.


class Desenvolvimento{
    static void Main(String [] args){
        // double nota1 = 8.0;
        // double nota2 = 9.0;

        Console.WriteLine("Digite sua nota: ");
        double.TryParse(Console.ReadLine(), out double nota);
        
        Console.WriteLine("Nota maior que 7? {0}", nota > 7.0);
        Console.WriteLine("Tirou 10? {0}", nota == 10.0);
    }
}