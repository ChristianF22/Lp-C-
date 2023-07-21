// Estruturas de controle - If/else: são estruturas que servem para o controle da execução
// do seu algoritmo, ou seja, por meio delas é possível fazer a organização e condições
// para que determinada parte do código seja executada.


class Controle{
    static void Main(string [] args){
       var n1 = 5;
       var n2 = 6;
       var n3 = 10;

       if(n1 < n2){
         Console.WriteLine("Condição 1 é satisfeita !!");
         Console.WriteLine("Resultado da soma é {0}", n1 + n2);
       }
       if(n3 < n2){
         Console.WriteLine(n3 - n2);
       } else{
         Console.WriteLine("Condição 2 não é satisfeita !!");
       }
    }
}