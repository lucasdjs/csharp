﻿using Exercicios;

pessoas p1 = new pessoas();
pessoas p2 = new pessoas();

Console.WriteLine("Dados da pimeira pessoa:");

Console.Write("Nome:");
p1.nome = Console.ReadLine();
Console.Write("Idade: ");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa:");

Console.Write("Nome:");
p2.nome = Console.ReadLine();
Console.Write("Idade: ");
p2.idade = int.Parse(Console.ReadLine());

if (p1.idade > p2.idade)
{
    Console.WriteLine("Pessoa mais velha: " + p1.nome);
}
else { 
    Console.WriteLine("Pessoa mais velha: " + p2.nome) ; 
}


