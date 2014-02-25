namespace JustRPG
{
    using System;
    using System.IO;
    using System.Text;

    public class ConsoleRenderer : IRenderer
    {
        private const int PLAY_FIELD_TOP = 0;
        private const int PLAY_FIELD_LEFT = 1;

        int renderContextMatrixRows;
        int renderContextMatrixCols;
        char[,] renderContextMatrix;

        public ConsoleRenderer(int playFieldConsoleRows, int playFieldConsoleCols)
        {
            renderContextMatrix = new char[playFieldConsoleRows, playFieldConsoleCols];

            this.renderContextMatrixRows = renderContextMatrix.GetLength(0);
            this.renderContextMatrixCols = renderContextMatrix.GetLength(1);

            this.ClearQueue();
        }

        public void EnqueueForRendering(IRenderable obj)
        {
            char[,] objImage = obj.GetImage();

            int imageRows = objImage.GetLength(0);
            int imageCols = objImage.GetLength(1);

            MatrixCoords objTopLeft = obj.GetTopLeft();
            objTopLeft.Col -= 2; //Compensate for room wall width and HUD
            objTopLeft.Row -= 1; //Compensate for room wall width

            int lastRow = Math.Min(objTopLeft.Row + imageRows, this.renderContextMatrixRows);
            int lastCol = Math.Min(objTopLeft.Col + imageCols, this.renderContextMatrixCols);

            for (int row = objTopLeft.Row; row < lastRow; row++)
            {
                for (int col = objTopLeft.Col; col < lastCol; col++)
                {
                    if (row >= 0 && row < renderContextMatrixRows &&
                        col >= 0 && col < renderContextMatrixCols)
                    {
                        renderContextMatrix[row, col] = objImage[row - objTopLeft.Row, col - objTopLeft.Col];
                    }
                }
            }
        }

        public void RenderAll()
        {
            Console.SetCursorPosition(PLAY_FIELD_LEFT + Castle.WALL_WIDTH, PLAY_FIELD_TOP + Castle.WALL_WIDTH);

            StringBuilder scene = new StringBuilder();
            int rowIncrease = 0;

            for (int row = 0; row < this.renderContextMatrixRows; row++)
            {
                for (int col = 0; col < this.renderContextMatrixCols; col++)
                {
                    scene.Append(this.renderContextMatrix[row, col]);
                }
                Console.Write(scene.ToString());
                rowIncrease++;
                Console.SetCursorPosition(PLAY_FIELD_LEFT + Castle.WALL_WIDTH, PLAY_FIELD_TOP + Castle.WALL_WIDTH + rowIncrease);
                scene.Clear();
            }            
        }

        public void ClearQueue()
        {
            for (int row = 0; row < this.renderContextMatrixRows; row++)
            {
                for (int col = 0; col < this.renderContextMatrixCols; col++)
                {
                    this.renderContextMatrix[row, col] = ' ';
                }
            }
        }

        public static void DrawFromCharacterTxt(string textFilePath, MatrixCoords cursorPosition)
        {
            Console.SetCursorPosition(cursorPosition.Col, cursorPosition.Row);
            StreamReader reader = new StreamReader(textFilePath);

            using (reader)
            {
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    Console.WriteLine(currentLine);
                }
            }
        }

        public static void DrawFromCharacterMatrix(char[,] matrix, MatrixCoords cursorPosition)
        {
            Console.SetCursorPosition(cursorPosition.Col, cursorPosition.Row);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.SetCursorPosition(cursorPosition.Col, ++cursorPosition.Row);
            }
        }     
    }
}
