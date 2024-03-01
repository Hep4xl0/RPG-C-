void main(String[] args)
{
    int vidaH = 25;
    int vidaM = 50;

    int energiaH = 12;
    int poçao = 5;


    int danoH = 8;
    int danoM = 3;

    string acão;




    while (vidaH > 0 && vidaM > 0)
    {


        Console.WriteLine("- Vida Monstro: " + vidaM + "/50");
        Console.WriteLine($"- Vida Personagem: {vidaH}/25 | Energia = {energiaH}/12 | Poção = {poçao}/5");


        Console.WriteLine("\n[+] Turno Heroi");
        Console.Write($"* Ataque digitando - Ataque  \n* Cure-se digitando - Cura  \n* Restaure energia digitando - Meditar\n\n>");


        acão = Console.ReadLine();
        Console.WriteLine("");
        int danoCurado = 5;
        switch (acão)
        {
            case "ataque":
                if (energiaH >= 4)
                {
                    vidaM = vidaM - danoH;
                    energiaH = energiaH - 3;
                    Console.WriteLine("- Voce causa 5 pontos de dano");


                }
                else { Console.WriteLine("- Não possui energia suficiente"); }
                break;
            case "cura":
                if (vidaH + danoCurado <= 25 && poçao > 0)
                {
                    vidaH += danoCurado;
                    Console.WriteLine("Voce se cura 5 pontos");
                    poçao = poçao - 1;
                }
                else
                {

                    Console.WriteLine("Vida Maxima");
                }
                break;
            case "meditar":
                energiaH = energiaH + 6;
                Console.WriteLine("Você medita e restaura 6 de energia"); break;

        }




        Console.WriteLine(" ");
        Console.WriteLine("[-] Turno Monstro");
        Console.WriteLine("- O Monstro te bate e causa: " + danoM + " de dano");
        vidaH -= danoM;
        Console.WriteLine(" ");
        Console.Write("Clique enter para continuar...");
        string a = Console.ReadLine();
        Console.Clear();

        if (vidaM < 0) { Console.WriteLine("[=] Você Ganhou"); }
        else if (vidaH < 0) { Console.WriteLine("[=] Você Perdeu KKKKKKKKKKKKKK"); };

    }




}







main(args);