// Operadores unários: Na programação em C#, ainda há a possibilidade de utilização dos operadores
// unários, que funcionam com apenas um operando, ou seja, não necessita ser
// inseridoentredois termos.Algunsdeles sãomuitoutilizadosduranteaprogramação:
// como os operadores unários de incremento e decremento. Porém, este tipo de
// operador pode não ser recomendado, pois sua utilização em alguns casos torna o
// entendimento do código mais complicado.

class Unarios{
    static void Main(String [] args){
         var x = false;
         var n1 = 8;
         var n2 = 6;
         var n3 = 9;
         var n4 = 5;

         Console.WriteLine(!x);
         n3++;
         Console.WriteLine(n3);

         n4--;
         Console.WriteLine(n4);

         Console.WriteLine(n2 == --n1);
         Console.WriteLine(n2-- == ++n1);

    }
}