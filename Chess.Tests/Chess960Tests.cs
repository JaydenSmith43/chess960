using Chess.Core;
using Chess.Core.Pieces;

namespace Chess.Tests
{
	public class Chess960
	{
		[Fact]
		public void ClassicAndChess960ChessBoardCreation()
		{
			Board classicBoard = new Board(8, true); // true for default board

			//check back board
			Assert.True(classicBoard.GetTile(0, 0).Piece is Rook);
			Assert.True(classicBoard.GetTile(0, 1).Piece is Knight);
			Assert.True(classicBoard.GetTile(0, 2).Piece is Bishop);
			Assert.True(classicBoard.GetTile(0, 3).Piece is Queen);
			Assert.True(classicBoard.GetTile(0, 4).Piece is King);
			Assert.True(classicBoard.GetTile(0, 5).Piece is Bishop);
			Assert.True(classicBoard.GetTile(0, 6).Piece is Knight);
			Assert.True(classicBoard.GetTile(0, 7).Piece is Rook);

			for (int i = 0; i < 8; i++)
			{
				Assert.True(classicBoard.GetTile(1, i).Piece is Pawn);
			}

			var chess960Board = new Board(8, true); // false for chess960 board

			bool differenceInBoards = false;
			for (int i = 0; i < 8; i++)
			{
				if (classicBoard.GetTile(1, i).Piece != chess960Board.GetTile(1, i).Piece)
				{
					differenceInBoards = true;
				}
			}

			Assert.True(differenceInBoards == true);
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
			int darkSpaces = 0;
			int lightSpaces = 0;

			// count bishop dark spaces
			for (int i = 0; i < 4; i++)
			{
				int darkSpaceCheck = i * 2; // 0, 2, 4, 6

				if (board.GetTile(0, darkSpaceCheck).Piece is Bishop) darkSpaces++;
			}

			// count bishop light spaces
			for (int i = 0; i < 4; i++)
			{
				int lightSpaceCheck = (i * 2) + 1; // 1, 3, 5, 7

				if (board.GetTile(0, lightSpaceCheck).Piece is Bishop) lightSpaces++;
			}

			Assert.True(darkSpaces == 1);
			Assert.True(lightSpaces == 1);
			Assert.True(darkSpaces == 1 && lightSpaces == 1);
		}

		[Fact]
		public void Chess960KingBetweenRooks()
		{
			var board = new Board(8, false); // false for Chess960 board
			int leftRookSpace = 0;
			int rightRookSpace = 0;
			int kingSpace = 0;
			bool rookChecked = false;

			for (int i = 0; i < 8; i++)
			{
				if (!rookChecked && board.GetTile(0, i).Piece is Rook)
				{
					leftRookSpace = i;
					rookChecked = true;
				}
				else if (rookChecked && board.GetTile(0, i).Piece is Rook)
				{
					rightRookSpace = i;
				}
				else if (board.GetTile(0, i).Piece is King)
				{
					kingSpace = i;
				}
			}

			Assert.True(leftRookSpace < kingSpace);
			Assert.True(kingSpace < rightRookSpace);
		}
	}
}