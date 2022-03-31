// See https://aka.ms/new-console-template for more information
using ClassLibrary1;

Console.WriteLine("Hello, TicTacToers!");

IRenderTheUI ui = new RealUI();

var game = new TicTacToe(ui);
game.PlayMove(0, 0);
Console.ReadLine();