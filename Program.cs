double peso, altura;

do{
    
    Console.Clear();

    Console.WriteLine("======Calcule seu IMC======\n");

    Console.Write("Digite seu peso(kg): ");
    peso = Convert.ToDouble(Console.ReadLine());

    if(peso == 0)
    {
        break;
    }

    Console.Write("Digite sua altura(m): ");
    altura = Convert.ToDouble(Console.ReadLine());

    CalcIMC.CalculoIMC(peso, altura);

    Console.Write("\nPressione Enter para continuar...");
    Console.ReadKey();

}while(peso != 0);


