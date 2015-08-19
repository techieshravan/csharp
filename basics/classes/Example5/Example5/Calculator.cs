namespace Example5
{
    class Calculator
    {
        public double Add(int num1, int num2)
        {
            var sum = num1 + num2;
            return sum;
        }
    
        public double Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
       
        public int Subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            return num2 - num1;
        }
    }
}
