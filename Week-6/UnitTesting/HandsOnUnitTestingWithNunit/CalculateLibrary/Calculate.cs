namespace CalculateLibrary
{
    public class Calculate
    {
        public int Count { get; set; }
        public void IncrementCount()
        {
            Count++;
        }
        public int Add(int a,int b)
        {
            return a + b;
        }
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0.");
            }
            return a / b;
        }
    }
}
