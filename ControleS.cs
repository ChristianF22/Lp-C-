//Estruturas de controle - Switch: O ‘Switch’ é semelhante ao que é realizado pela estrutura ‘if’, mas com uma
// diferença que funciona a partir de “escolhas”. Essa estrutura retorna um valor, seja
// ele numérico ou outro, de acordo com a necessidade do programador.


class ControleS{
    static void Main(String [] args){
        Console.WriteLine("Qual a nota você dar para o novo carro? 0, 5, ou 10");
        int.TryParse(Console.ReadLine(), out int nota);

        switch(nota){
            case 0:
            Console.WriteLine("Carro muito feio!");
            break;

            case 5:
            Console.WriteLine("Carro ficou razoável.");
            break;

            case 10:
            Console.WriteLine("O carro ficou perfeito!!!");
            break;   
        }
    }
}