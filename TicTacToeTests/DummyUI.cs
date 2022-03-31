using ClassLibrary1;
using System.Collections.Generic;

namespace TicTacToeTests
{
    internal class DummyUI : IRenderTheUI
    {
        public List<string> Output { get; internal set; }

        public DummyUI()
        {
            Output = new List<string>();
        }

        public void Update(string message)
        {
            Output.Add(message);
        }
    }
}