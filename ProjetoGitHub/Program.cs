﻿// See https://aka.ms/new-console-template for more information
using ProjetoGitHub;

Console.WriteLine("Hello, World!");

var produto = new Produto();
produto.Descricao = "Teclado";
produto.Id = 1;
Console.WriteLine($"Produto: {produto.Descricao}");