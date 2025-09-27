Console.Clear();

int AdultosComAlcool, AdultosSemAlcool, Criancas, Adultos, Pessoas;
double carne, Acompanhamentos, Cerveja, Refrigerante, Agua;

Console.WriteLine("---- Churrasco ----");

Console.Write("Adultos (que consomem alcool)....: ");
AdultosComAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Adultos (que não consomem alcool)..: ");
AdultosSemAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Crianças.............: ");
Criancas = Convert.ToInt32(Console.ReadLine());

Adultos = AdultosComAlcool + AdultosSemAlcool;
Pessoas = Adultos + Criancas;


carne = 0.4 * Adultos + 0.2 * Criancas; // em kg
Acompanhamentos = 0.2 * Pessoas; // em kg
Cerveja = 2 * AdultosComAlcool; // em litros
Refrigerante = 0.5 * (AdultosSemAlcool + Criancas); // em litros
Agua = 0.4 * Pessoas; // em litros

Console.WriteLine();
Console.WriteLine("---- Quantidades ----");
Console.WriteLine();

Console.WriteLine($"Carne.............: {carne:N1} kg");
Console.WriteLine($"Acompanhamentos...: {Acompanhamentos:N1} kg");
Console.WriteLine($"Cerveja...........: {Cerveja:N1} litros");
Console.WriteLine($"Refrigerante......: {Refrigerante:N1} litros");
Console.WriteLine($"Água..............: {Agua:N1} litros");