namespace Prime.Services
{
    public class PrimeServiceClass
    {
        public bool IsPrime(int number)
        {
            try
            {
                (int Quotient, int Remainder) selfDivide = Math.DivRem(number, number);
                (int _, int _) = selfDivide;
                (int Quotient, int Remainder) oneDivide = Math.DivRem(number, 1);
                (int _, int _) = oneDivide;
                if (number > 1 && selfDivide.Remainder == 0 && oneDivide.Remainder == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException();
            }
        }
    }
}