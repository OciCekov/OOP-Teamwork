namespace JustRPG
{
    public interface IMovable
    {
        MatrixCoords DeltaPosition { get; set; }

        void Move();
    }
}
