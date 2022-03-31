namespace ClassLibrary1;
public class TicTacToe
{
    private readonly IRenderTheUI _uiImplementation;
    private List<Move> moveRecord;

    public bool? IsOver { get; internal set; }


    public TicTacToe(IRenderTheUI uiImplementation)
    {
        _uiImplementation = uiImplementation;
        IsOver = false;
        moveRecord = new List<Move>();
    }


    public void PlayMove(int xCoOrd, int yCoOrd)
    {
        if (xCoOrd >= 3)
        {
            _uiImplementation.Update("Invalid Turn - outside of board");
        }
        else
        {
            if (moveRecord.Any(m => m.X == xCoOrd && m.Y == yCoOrd))
            {
                _uiImplementation.Update("Invalid Turn - space already used");
            }
            else
            {
                moveRecord.Add(new Move { X = xCoOrd, Y = yCoOrd });
                if (moveRecord.Count == 5)
                {
                    IsOver = true;
                    _uiImplementation.Update("Game Over");
                }
                else
                {
                    _uiImplementation.Update("Ready for next player");
                }
            }
        }
    }
}

internal record Move
{
    public int X;
    public int Y;
}