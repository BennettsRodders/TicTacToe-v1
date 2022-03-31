using ClassLibrary1;
using System.Linq;
using Xunit;

namespace TicTacToeTests
{
    public class Tests
    {

        [Fact]
        public void FirstMoveNeverWins()
        {
            // Arrange
            DummyUI uiImplementation = new DummyUI();
            var game = new TicTacToe(uiImplementation);

            // Act
            game.PlayMove(0, 0);


            // Assert
            Assert.False(game.IsOver);
            Assert.Equal("Ready for next player", uiImplementation.Output.Last());
        }

        [Fact]
        public void TopRowWin() // I didn't like this choice of test, it's getting too far ahead of myself
        {
            // Arrange
            DummyUI uiImplementation = new DummyUI();
            var game = new TicTacToe(uiImplementation);

            // Act
            game.PlayMove(0, 0);
            game.PlayMove(1, 0);
            game.PlayMove(0, 1);
            game.PlayMove(1, 1);
            game.PlayMove(0, 2);

            // Assert
            Assert.True(game.IsOver);
            Assert.Equal("Game Over", uiImplementation.Output.Last());
        }

        [Fact]
        public void MoveCannotReuseSpace() // this forces my implementation to start tracking the moves!
        {
            // Arrange
            DummyUI uiImplementation = new DummyUI();
            var game = new TicTacToe(uiImplementation);

            // Act
            game.PlayMove(0, 0);
            game.PlayMove(0, 0);

            // Assert
            Assert.False(game.IsOver);
            Assert.Equal("Invalid Turn - space already used", uiImplementation.Output.Last());
        }

        [Fact]
        public void MovesMustBeValid()
        {
            // Arrange
            DummyUI uiImplementation = new DummyUI();
            var game = new TicTacToe(uiImplementation);


            // Act
            game.PlayMove(3, 0);


            // Assert
            Assert.False(game.IsOver);
            Assert.Equal("Invalid Turn - outside of board", uiImplementation.Output.Last());
        }
    }
}