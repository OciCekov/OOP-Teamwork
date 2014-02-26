namespace JustRPG
{
    using System;

    public class Fighter : Hero, IRenderable, IMovable
    {
        #region Fighter images
        private static readonly char[,] LeftMatrix = new char[HERO_IMAGE_HEIGHT, HERO_IMAGE_WIDTH]
            {
                {' ', ' ', ' ', 'H', ' ', ' ', ' '},
                {'\u0336', '\u00F7', '/', 'V', '\\', '/', '\\'},
                {' ',' ', '/', ' ', '\\', '\\', '/'},
                {' ',' ', '\u02E9', ' ', '\u02E9', ' ', ' '},
            };

        private static readonly char[,] LeftUpMatrix = new char[HERO_IMAGE_HEIGHT, HERO_IMAGE_WIDTH]
            {
                {' ', '|', ' ', 'H', ' ', ' ', ' '},
                {' ', 'I', '/', 'V', '\\', '/', '\\'},
                {' ', ' ', '/', ' ', '\\', '\\', '/'},
                {' ', ' ', '\u02E9', ' ', '\u02E9', ' ', ' '},
            };

        private static readonly char[,] LeftDownMatrix = new char[HERO_IMAGE_HEIGHT, HERO_IMAGE_WIDTH]
            {
                {' ', ' ', ' ', 'H', ' ', ' ', ' '},
                {' ', 'I', '/', 'V', '\\', '/', '\\'},
                {' ', '|', '/', ' ', '\\', '\\', '/'},
                {' ', ' ', '\u02E9', ' ', '\u02E9', ' ', ' '},
            };

        private static readonly char[,] RightMatrix = new char[HERO_IMAGE_HEIGHT, HERO_IMAGE_WIDTH]
            {
                {' ', ' ', ' ', 'H', ' ', ' ', ' '},
                {'/', '\\', '/', 'V', '\\', '\u00F7', '\u0336'},
                {'\\', '/', '/', ' ', '\\', ' ', ' '},
                {' ', ' ', 'L', ' ', 'L', ' ', ' '},
            };

        private static readonly char[,] RightUpMatrix = new char[HERO_IMAGE_HEIGHT, HERO_IMAGE_WIDTH]
            {
                {' ', ' ', ' ', 'H', ' ', '|', ' '},
                {'/', '\\', '/', 'V', '\\', 'I', ' '},
                {'\\', '/', '/', ' ', '\\', ' ', ' '},
                {' ', ' ', 'L', ' ', 'L', ' ', ' '},
            };

        private static readonly char[,] RightDownMatrix = new char[HERO_IMAGE_HEIGHT, HERO_IMAGE_WIDTH]
            {
                {' ', ' ', ' ', 'H', ' ', ' ', ' '},
                {'/', '\\', '/', 'V', '\\', 'I', ' '},
                {'\\', '/', '/', ' ', '\\', '|', ' '},
                {' ', ' ', 'L', ' ', 'L', ' ', ' '},
            };
        #endregion

        public Fighter(MatrixCoords position)
            : base(position)
        {
            this.CurrentImage = RightUpMatrix;
        }              

        public override char[,] GetImage()
        {
            if (this.DeltaPosition.Equals(MatrixCoords.LeftVector))
            {
                this.CurrentImage = LeftMatrix;
                return LeftMatrix;
            }
            else if (this.DeltaPosition.Equals(MatrixCoords.RightVector))
            {
                this.CurrentImage = RightMatrix;
                return RightMatrix;
            }
            else if (this.DeltaPosition.Equals(MatrixCoords.DownVector))
            {
                if (this.CurrentImage == RightDownMatrix || this.CurrentImage == RightUpMatrix || this.CurrentImage == RightMatrix)
                {
                    this.CurrentImage = RightDownMatrix;
                    return RightDownMatrix;
                }
                else
                {
                    this.CurrentImage = LeftDownMatrix;
                    return LeftDownMatrix;
                }
            }
            else
            {
                if (this.CurrentImage == RightDownMatrix || this.CurrentImage == RightUpMatrix || this.CurrentImage == RightMatrix)
                {
                    this.CurrentImage = RightUpMatrix;
                    return RightUpMatrix;
                }
                else
                {
                    this.CurrentImage = LeftUpMatrix;
                    return LeftUpMatrix;
                }
            }
        }        
    }
}
