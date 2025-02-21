using Chess.Core;
using Chess.Core.Pieces;

namespace Chess.Tests
{
	public class Chess960
	{

		[Fact]
		public void ClassicChessBoardCreation()
		{
			var board = new Board(8, true); // true for default board

			//check back board
			Assert.True(board.GetTile(0, 0).Piece is Rook); 
			Assert.True(board.GetTile(0, 1).Piece is Knight);
			Assert.True(board.GetTile(0, 2).Piece is Bishop);
			Assert.True(board.GetTile(0, 3).Piece is Queen);
			Assert.True(board.GetTile(0, 4).Piece is King);
			Assert.True(board.GetTile(0, 5).Piece is Bishop);
			Assert.True(board.GetTile(0, 6).Piece is Knight);
			Assert.True(board.GetTile(0, 7).Piece is Rook);

			for (int i = 0; i < 8; i++)
			{
				Assert.True(board.GetTile(1, i).Piece is Pawn);
			}
		}

		[Fact]
		public void Chess960BoardCreation()
		{
			var board = new Board(8, false); // false for Chess960 board

			Assert.NotNull(board);
		}

		[Fact]
		public void Chess960SecondRowCheck()
		{
			var board = new Board(8, false); // false for Chess960 board

			for (int i = 0; i < 8; i++)
			{
				Assert.True(board.GetTile(1, i).Piece is Pawn); // check that pawns don't get changed
			}
		}

		[Fact]
		public void Chess960BishopOpposites()
		{
			var board = new Board(8, false); // false for Chess960 board

			for (int i = 0; i < 4; i++)
			{
				int lightSpaceCheck = i * 2; // 0, 2, 4, 6

			}
		}

		//check for king is between rooks

		//check rooks on opposite
	}
}