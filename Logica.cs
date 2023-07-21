// Operadores lógicos:Os operadores lógicos são de grande importância para a montagem da lógica dos
// algoritmosdesenvolvidos,pormeiodelesépossívelfazerexecuçãodedeterminados
// códigos apenas se todas as condições forem satisfeitas, ou caso desejado, se apenas
// uma das condições for satisfeita.


class Logica{
    static void Main(String [] args){
        var atividade1 = true;
        var atividade2 = false;
        var todasAtividades = atividade1 && atividade2;
        Console.WriteLine("Fez todas as atividades? {0}", todasAtividades);

        var umaApenas = atividade1 || atividade2;
        Console.WriteLine("Fez pelo menos uma das atividades? {0}", umaApenas);
        Console.WriteLine("Não fez nenhuma? {0}", !umaApenas);
    }
}