
int adultoAlcool, adultosemAlcool, adulto, crianca, pessoas;
double carne, acompanhamentos, cerveja, refrigerante, agua;


Console.WriteLine("--- Churrasco ---\n");

Console.Write("Adultos que consomem bebidas alcoólicas.......: ");
adultoAlcool = Convert.ToInt32(Console.ReadLine());


Console.Write("Adultos que não consomem bebidas alcoólicas...: ");
adultosemAlcool = Convert.ToInt32(Console.ReadLine());


Console.Write("Quantidade de crianças........................: ");
crianca = Convert.ToInt32(Console.ReadLine());

adulto = adultoAlcool + adultosemAlcool;
pessoas = crianca + adulto;

carne = 0.4 * adulto + 0.2 * crianca;
acompanhamentos = 0.2 * pessoas;
cerveja = 2 * adultoAlcool;
refrigerante = 0.4 * adultosemAlcool + crianca;
agua = 0.4 * pessoas;

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Carne.............: {carne:N1} kg");
Console.WriteLine($"Acompanhamentos...: {acompanhamentos:N1} kg");
Console.WriteLine($"Cerveja...........: {cerveja:N1} L");
Console.WriteLine($"Refrigerante......: {refrigerante:N1} L");
Console.WriteLine($"Água..............: {agua:N1} L");
Console.ResetColor();