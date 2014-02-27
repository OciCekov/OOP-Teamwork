namespace LuboTheHero
{
    interface IMovable
    {
        MatrixCoords DeltaPosition { get; set; }

        void Move();
    }
}
