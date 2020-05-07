


namespace TestNinja.Fundamentals
{
    public class Math_Lab1
    {
        //Var 1
        public bool AgreaterThanB(int a, int b)
        {
            if (a > b)
                return true;
            if (a < b)
                return false;
            return true;
        }
        //Var 2
        public bool AlessThanB(int a, int b)
        {
            if (a < b)
                return true;
            if (a > b)
                return false;
            return true;
        }
        //Var 3
        public bool SumGreaterThan10(int a, int b)
        {
            if (a + b > 10)
                return true;
            if (a + b < 10)
                return false;
            return true;
        }
        //Var 4
        public bool SumLessThan10(int a, int b)
        {
            if (a + b < 10)
                return true;
            if (a + b > 10)
                return false;
            return true;
        }
        //Var 5
        public bool MultiplicationGreaterThan10(int a, int b)
        {
            if (a * b > 10)
                return true;
            if (a * b < 10)
                return false;
            return true;
        }
        //Var 6
        public bool MultiplicationLessThan10(int a, int b)
        {
            if (a * b < 10)
                return true;
            if (a * b > 10)
                return false;
            return true;
        }
        //Var 7
        public bool DifferenceGreaterThan10(int a, int b)
        {
            if (a - b > 10)
                return true;
            if (a - b < 10)
                return false;
            return true;
        }
        //Var 8
        public bool DifferenceLessThan10(int a, int b)
        {
            if (a - b < 10)
                return true;
            if (a - b > 10)
                return false;
            return true;
        }
        //Var 9
        public bool IsSumDivisibleBy3(int a, int b)
        {
            if (a + b % 3 == 0)
                return true;
            if (a + b % 3 != 0)
                return false;
            return true;
        }
        //Var 10
        public bool IsSumDivisibleBy4(int a, int b)
        {
            if (a + b % 4 == 0)
                return true;
            if (a + b % 4 != 0)
                return false;
            return true;
        }

        //Var 11
        public bool IsDifferenceDivisibleBy3(int a, int b)
        {
            if (a - b % 3 == 0)
                return true;
            if (a - b % 3 != 0)
                return false;
            return true;
        }
        //Var 12
        public bool IsDifferenceDivisibleBy4(int a, int b)
        {
            if (a - b % 4 == 0)
                return true;
            if (a - b % 4 != 0)
                return false;
            return true;
        }
        //Var 13
        public bool LogicalAND(bool a, bool b)
        {
            if (a && b)
                return true;
            if (!(a && b))
                return false;
            return true;
        }
        //Var 14
        public bool LogicalOR(bool a, bool b)
        {
            if (a || b)
                return true;
            if (!(a || b))
                return false;
            return true;
        }
        //Var 15
        public bool LogicalXOR(bool a, bool b)
        {
            if ((a && b)|| (!a && !b))
                return true;
            if (!((a && b) || (!a && !b)))
                return false;
            return true;
        }
        //Var 16
        public bool IsDifferenceDivisibleBy10(int a, int b)
        {
            if (a - b % 10 == 0)
                return true;
            if (a - b % 10 != 0)
                return false;
            return true;
        }
        //Var 17
        public bool IsSumDivisibleBy10(int a, int b)
        {
            if (a + b % 10 == 0)
                return true;
            if (a + b % 10 != 0)
                return false;
            return true;
        }

        //Var 18
        public bool IsSumDivisibleBy11(int a, int b)
        {
            if (a + b % 11 == 0)
                return true;
            if (a + b % 11 != 0)
                return false;
            return true;
        }
        //Var 19
        public bool IsSumDivisibleBy8(int a, int b)
        {
            if (a + b % 8 == 0)
                return true;
            if (a + b % 8 != 0)
                return false;
            return true;
        }
        //Var 20
        public bool IsSumDivisibleBy9(int a, int b)
        {
            if (a + b % 9 == 0)
                return true;
            if (a + b % 9 != 0)
                return false;
            return true;
        }
        //Var 21
        public bool IsSumDivisibleBy13(int a, int b)
        {
            if (a + b % 13 == 0)
                return true;
            if (a + b % 13 != 0)
                return false;
            return true;
        }
        //Var 22
        public bool IsSumDivisibleBy27(int a, int b)
        {
            if (a + b % 27 == 0)
                return true;
            if (a + b % 27 != 0)
                return false;
            return true;
        }
        //Var 23
        public bool IsDifferenceDivisibleBy13(int a, int b)
        {
            if (a - b % 13 == 0)
                return true;
            if (a - b % 13 != 0)
                return false;
            return true;
        }
        //Var 24
        public bool IsDifferenceDivisibleBy7(int a, int b)
        {
            if (a - b % 7 == 0)
                return true;
            if (a - b % 7 != 0)
                return false;
            return true;
        }
        //Var 25
        public bool IsSumDivisibleBy7(int a, int b)
        {
            if (a + b % 7 == 0)
                return true;
            if (a + b % 7 != 0)
                return false;
            return true;
        }


    }
}
