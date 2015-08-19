namespace Example8ConstructorParams
{
    class Coordinates
    {
        public int x, y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", x, y);
        }
    }
}
