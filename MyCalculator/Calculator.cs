namespace MyCalculator
{
    internal class Calculator
    {
        public double Result { get; private set; }

        public Calculator()
        {
            ResetResult();
        }

        public void ResetResult()
        {
            Result = 0;
        }

        public double Add(double operand)
        {
            return Result += operand;
        }

        public double Subtract(double operand)
        {
            return Result -= operand;
        }

        public double Multiply(double operand)
        {
            return Result *= operand;
        }

        public double Divide(double operand)
        {
            // Prevent division by zero
            if (operand == 0)
            {
                return Result;
            }

            return Result /= operand;
        }
    }
}