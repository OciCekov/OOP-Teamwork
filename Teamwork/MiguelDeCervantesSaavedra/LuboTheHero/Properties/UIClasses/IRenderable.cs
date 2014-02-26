namespace LuboTheHero.UIClasses
{
    public interface IRenderable
    {         
        MatrixCoords GetTopLeft();

        char[,] GetImage();
    }
}
