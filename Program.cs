Console.WriteLine("--- Imitando Dory ---\n");

Console.Write("Digite uma frase...: ");
string frase = Console.ReadLine()!;

string fraseEmBaleies = frase
    .Replace("a", "continue a nadar")
    .Replace("A", "coontinuuee aa naadarr")
    .Replace("e", "continue a nadar")
    .Replace("E", "coontinuuee aa naadarr")
    
;
Console.WriteLine($"\nEm baleiês:\n\n{fraseEmBaleies}");
