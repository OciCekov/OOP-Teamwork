using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public struct MatrixCoords
    {
        public static readonly MatrixCoords UP_VECTOR = new MatrixCoords(-1, 0);
        public static readonly MatrixCoords DOWN_VECTOR = new MatrixCoords(1, 0);
        public static readonly MatrixCoords LEFT_VECTOR = new MatrixCoords(0, -1);
        public static readonly MatrixCoords RIGHT_VECTOR = new MatrixCoords(0, 1);

        public int Row { get; set; }
        public int Col { get; set; }

        public MatrixCoords(int row, int col)
            : this()
        {
            this.Row = row;
            this.Col = col;
        }

        public static MatrixCoords operator +(MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.Row + b.Row, a.Col + b.Col);
        }

        public static MatrixCoords operator -(MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.Row - b.Row, a.Col - b.Col);
        }

        public static int CalculateDistance(MatrixCoords a, MatrixCoords b)
        {
            int yDistance = b.Row - a.Row;
            int xDistance = b.Col - a.Col;

            return (int)Math.Sqrt(yDistance * yDistance + xDistance * xDistance);
        }

        public override bool Equals(object obj)
        {
            MatrixCoords objAsMatrixCoords = (MatrixCoords)obj;

            return objAsMatrixCoords.Row == this.Row && objAsMatrixCoords.Col == this.Col;
        }

        public override int GetHashCode()
        {
            return this.Row.GetHashCode() * 7 + this.Col;
        }
    }
}
