namespace Example7ConstructorParams
{
    class Taxi
    {
        public bool IsInitialized { set; get; }

        public Taxi(bool isInitialized)
        {
            IsInitialized = isInitialized;
        }
    }
}
