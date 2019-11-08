namespace BlazorConnectFour.Data
{
    public class GameBoard
    {
        public GamePiece[,] Board { get; set; }

        public GameBoard()
        {
            Board = new GamePiece[7,6];

            //Populate with blank pieces
            for(var i = 0 ; i <= 6 ; i++)
            {
                for (var j = 0; j <= 5; j++)
                {
                    Board[i,j] = new GamePiece(PieceColor.Blank);
                }
            }
        }
    }
}