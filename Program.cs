int AdultosComAlcool, AdultosSemAlcool, Criancas, Adultos, Pessoas;
double carne, cerveja, refrigerante, agua, acompanhamentos;

Console.WriteLine("Churrasco\n");

Console.WriteLine("Adultos (que consomem alcool):");
AdultosComAlcool = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Adultos (que não consomem alcool):");
AdultosSemAlcool = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Crianças:");
Criancas = Convert.ToInt32(Console.ReadLine());

Adultos = AdultosComAlcool + AdultosSemAlcool;
Pessoas = Criancas + Adultos;

carne = 0.4 * Adultos + 0.2 * Criancas;
acompanhamentos = 0.2 * Pessoas;
cerveja = 2 * AdultosComAlcool;
refrigerante = 0.5 * (AdultosSemAlcool + Criancas);
agua = 0.4 * Pessoas;

Console.WriteLine();

Console.WriteLine($"Carne: {carne:N1}kg");
Console.WriteLine($"Acompnhamentos: {acompanhamentos:N1}kg");
Console.WriteLine($"Cerveja: {cerveja:N1}L");
Console.WriteLine($"Refrigerante: {refrigerante:N1}L");
Console.WriteLine($"Água: {agua:N1}L");