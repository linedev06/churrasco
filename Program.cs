
int adultoAlcool, adultosemAlcool, adulto, crianca, pessoas;
double carne, acompanhamentos, cerveja, refrigerante, agua;


Console.WriteLine("--- Churrasco ---");

Console.Write("Adultos que consomem bebidas alcoólicas: ");
adultoAlcool = Convert.ToInt32(Console.ReadLine());


Console.Write("Adultos que não consomem bebidas alcoólicas: ");
adultosemAlcool = Convert.ToInt32(Console.ReadLine());


Console.Write("Crianças: ");
crianca = Convert.ToInt32(Console.ReadLine());

adulto = adultoAlcool + adultosemAlcool;
pessoas = crianca + adulto;

carne = 0.5 * adulto + 0.2 * crianca;
acompanhamentos = 0.2 * pessoas;
cerveja = 2 * adultoAlcool;
refrigerante = 0.5 * adultosemAlcool + crianca;
agua = 0.4 * pessoas;


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Carne: {carne}kg");
Console.WriteLine($"Acompanhamentos: {acompanhamentos}kg");
Console.WriteLine($"Cerveja: {cerveja}L");
Console.WriteLine($"Refrigerante: {refrigerante}L");
Console.WriteLine($"Água: {agua}L");
Console.ResetColor();