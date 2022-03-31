// See https://aka.ms/new-console-template for more information
using ClassLibrary1;

internal class RealUI : IRenderTheUI
{
    public void Update(string message)
    {
        Console.WriteLine(message);
    }
}