using target_project.code;

Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine("Olá, bem vindos(as) ao meu projeto do desafio para a Target Sistemas!");
Console.WriteLine("Aqui você encontrará um conjunto de exercícios que resolvi para demonstrar minhas habilidades.");
Console.WriteLine("Vamos começar?");
Console.WriteLine("Pressione enter para continuar...");
// Console.WriteLine("---------------------------------------------------------------------------");
bool done = true;
    Console.ReadLine();
while (done){
    Console.Clear();
    Console.WriteLine("---------------------------------------------------------------------------");
    Console.WriteLine("Digite o número de dos exercícios abaixo para executar:");
    Console.WriteLine("1 - Exercício 1");
    Console.WriteLine("2 - Exercício 2");
    Console.WriteLine("3 - Exercício 3");
    Console.WriteLine("4 - Exercício 4");
    Console.WriteLine("5 - Exercício 5");
    int exercise = Convert.ToInt16(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("---------------------------------------------------------------------------");
    switch (exercise)
    {
        case 1:
            exercise1 ex1 = new exercise1();
            ex1.Exercise1();
            break;
        case 2:
            exercise2 ex2 = new exercise2();
            ex2.Exercise2();
            break;
        case 3:
            exercise3 ex3 = new exercise3();
            ex3.Exercise3();
            break;
        case 4:
            exercise4 ex4 = new exercise4();
            ex4.Exercise4();
            break;
        case 5:
            exercise5 ex5 = new exercise5();
            ex5.Exercise5();
            break;
        default:
            Console.WriteLine("Exercício não encontrado");
            break;
    }
    Console.WriteLine("---------------------------------------------------------------------------");
    bool done2 = true;
    while (done2){
        Console.WriteLine("Deseja executar outro exercício? (s/n)");
        string answer = Console.ReadLine() ?? "";
        if (answer == "n"){
            done2 = false;
            done = false;
        } else if (answer == "s"){
            done2 = false;
        }else{
            Console.WriteLine("Opção inválida");
        }
    }
    Console.Clear();

}