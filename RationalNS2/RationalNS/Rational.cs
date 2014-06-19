using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Stephanie Goedde
//Rationals 2
//Programming 2
//10-25-11

namespace RationalNS
{
    public class Rational
    {
        private int intDenominator, intNumerator;
        private static int intCompare;

        //2-parameter constructor
        public Rational(int Numerator, int Denominator)
        {
            intNumerator = Numerator;
            intDenominator = Denominator;
        }

        //1-parameter constructor
        public Rational(int Numerator)
        {
            intNumerator = Numerator;
            intDenominator = 1;
        }

        //default constructor
        public Rational()
        {
            intNumerator = 0;
            intDenominator = 1;
        }

        //method to assign values to numerator and denominator
        public void Assign(int Numerator, int Denominator)
        {
            intNumerator = Numerator;
            intDenominator = Denominator;
        }

        //method to multiply fractions
        public static Rational operator *(Rational rationalOp1, Rational rationalOp2)
        {
            int intNum1, intDen1;
            Rational result;

            intNum1 = rationalOp1.Numerator * rationalOp2.Numerator;
            intDen1 = rationalOp1.Denominator * rationalOp2.Denominator;

            return result = new Rational(intNum1, intDen1);
        }

        //method to add fractions
        public static Rational operator +(Rational rationalOp1, Rational rationalOp2)
        {
            int intNum1, intDen1, intNum2, intDen2, intNum3;
            Rational result;

            intNum2 = rationalOp1.Numerator * rationalOp2.Denominator;
            intDen2 = rationalOp1.Denominator * rationalOp2.Denominator;
            intNum3 = rationalOp2.Numerator * rationalOp1.Denominator;

            intNum1 = intNum2 + intNum3;
            intDen1 = intDen2;

            return result = new Rational(intNum1, intDen1);
        }

        //method to find difference of fractions
        public static Rational operator -(Rational rationalOp1, Rational rationalOp2)
        {
            int intNum1, intDen1, intNum2, intDen2, intNum3;
            Rational result;

            intNum2 = rationalOp1.Numerator * rationalOp2.Denominator;
            intDen2 = rationalOp1.Denominator * rationalOp2.Denominator;
            intNum3 = rationalOp2.Numerator * rationalOp1.Denominator;

            intNum1 = intNum2 - intNum3;
            intDen1 = intDen2;

            return result = new Rational(intNum1, intDen1);
        }

        //method to divide fractions
        public static Rational operator /(Rational rationalOp1, Rational rationalOp2)
        {
            int intNum1, intDen1;
            Rational result;

            intNum1 = rationalOp1.Numerator * rationalOp2.Denominator;
            intDen1 = rationalOp2.Numerator * rationalOp1.Denominator;

            return result = new Rational(intNum1, intDen1);
        }

        //method to determine if less than
        public static bool operator <(Rational rationalOp1, Rational rationalOp2)
        {
            Compare(rationalOp1, rationalOp2);

            if (intCompare == -1)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        //method to determine if greater than
        public static bool operator >(Rational rationalOp1, Rational rationalOp2)
        {
            Compare(rationalOp1, rationalOp2);

            if (intCompare == 1)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        //method to determine if equal to
        public static bool operator ==(Rational rationalOp1, Rational rationalOp2)
        {
            Compare(rationalOp1, rationalOp2);

            if (intCompare == 0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        //method to determine if not equal to
        public static bool operator !=(Rational rationalOp1, Rational rationalOp2)
        {
            return ((rationalOp1.Fraction != rationalOp2.Fraction ? true : false));
        }

        //method to determine if equal to-uses current == method
        public override bool Equals(object rationalOp2)
        {
            int intNum1 = this.Numerator;
            int intNum2 = ((Rational)rationalOp2).Numerator;
            int intDen1 = this.Denominator;
            int intDen2 = ((Rational)rationalOp2).Denominator;

            intNum1 *= ((Rational)rationalOp2).Denominator;
            intNum2 *= this.Denominator;
            intDen1 *= ((Rational)rationalOp2).Denominator;
            intDen2 *= this.Denominator;

            if (intNum1 == intNum2)
            {
                intCompare = 0;
                return (true);
            }
            else
            {
                if (intNum1 < intNum2)
                {
                    intCompare = -1;
                    return (false);
                }
                else
                {
                    if (intNum1 > intNum2)
                    {
                        intCompare = 1;
                        return (false);
                    }
                    else
                    {
                        intCompare = 1;
                        return (false);
                    }
                }
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //method that acually compares values and returns value to bool operators
        public static int Compare(Rational rationalOp1, Rational rationalOp2)
        {
            int intNum1 = rationalOp1.Numerator;
            int intNum2 = rationalOp2.Numerator;
            int intDen1 = rationalOp1.Denominator;
            int intDen2 = rationalOp2.Denominator;

            intNum1 *= rationalOp2.Denominator;
            intNum2 *= rationalOp1.Denominator;
            intDen1 *= rationalOp2.Denominator;
            intDen2 *= rationalOp1.Denominator;

            if (intNum1 == intNum2)
            {
                intCompare = 0;
            }
            else 
            {
                if (intNum1 < intNum2)
                {
                    intCompare = -1;
                }
                else
                {
                    if (intNum1 > intNum2)
                    {
                        intCompare = 1;
                    }
                    else
                    {
                        intCompare = 1;
                    }
                }
            }

            return intCompare;
        }

        //property that returns fractions as string
        public string Fraction
        {
            get
            {
                return Numerator.ToString() + "/" + Denominator.ToString();
            }
        }

        //property that returns fractions as mixed fraction string
        public string MixedFraction
        {
            get
            {
                int intNum1, intDen1, intNum2, intDen2, intWhole, Num;

                if (Numerator < 0)
                {
                    intNum1 = -Numerator;
                    intDen1 = Denominator;
                }
                else
                {
                    intNum1 = Numerator;
                    intDen1 = Denominator;
                }

                while (intNum1 != 0 && intDen1 != 0)
                {
                    if (intNum1 > intDen1)
                        intNum1 %= intDen1;
                    else
                        intDen1 %= intNum1;
                }

                if (intNum1 == 0)
                {
                    if (Numerator < 0)
                    {
                        intNum2 = -Numerator / intDen1;
                        intDen2 = Denominator / intDen1;

                        intNum2 = -intNum2;
                    }
                    else
                    {
                        intNum2 = Numerator / intDen1;
                        intDen2 = Denominator / intDen1;
                    }

                    return intNum2.ToString() + "/" + intDen2.ToString();
                }
                else
                {
                    if (Numerator < 0)
                    {
                        intNum2 = -Numerator / intNum1;
                        intDen2 = Denominator / intNum1;
                        intWhole = intNum2 / intDen2;

                        Num = -(intNum2 - (intDen2 * intWhole));
                    }
                    else
                    {
                        intNum2 = Numerator / intNum1;
                        intDen2 = Denominator / intNum1;
                        intWhole = intNum2 / intDen2;

                        Num = intNum2 - (intDen2 * intWhole);
                    }

                    return intWhole.ToString() + " " + Num.ToString() + "/" + intDen2.ToString(); 
                }
            }
        }

        //property that returns reduced fraction as string
        public string ReducedFraction
        {
            get
            {
                int intNum1, intDen1, intNum2, intDen2;

                if (Numerator < 0)
                {
                    intNum1 = -Numerator;
                    intDen1 = Denominator;
                }
                else
                {
                    intNum1 = Numerator;
                    intDen1 = Denominator;
                }

                while (intNum1 != 0 && intDen1 != 0)
                {
                    if (intNum1 > intDen1)
                        intNum1 %= intDen1;
                    else
                        intDen1 %= intNum1;
                }

                if (intNum1 == 0)
                {
                    if (Numerator < 0)
                    {
                        intNum2 = -Numerator / intDen1;
                        intDen2 = Denominator / intDen1;

                        intNum2 = -intNum2;
                    }
                    else
                    {
                        intNum2 = Numerator / intDen1;
                        intDen2 = Denominator / intDen1;
                    }

                    return intNum2.ToString() + "/" + intDen2.ToString();
                }
                else
                {
                    if (Numerator < 0)
                    {
                        intNum2 = -Numerator / intNum1;
                        intDen2 = Denominator / intNum1;

                        intNum2 = -intNum2;
                    }
                    else
                    {
                        intNum2 = Numerator / intNum1;
                        intDen2 = Denominator / intNum1;
                    }
                    
                    return intNum2.ToString() + "/" + intDen2.ToString();
                }
            }
        }

        //property that gets and sets numerator
        public int Numerator
        {
            get
            {
                return intNumerator;
            }
            set
            {
                intNumerator = value;
            }
        }

        //property that gets and sets denominator
        public int Denominator
        {
            get
            {
                return intDenominator;
            }
            set
            {
                intDenominator = value;
            }
        }
    }
}
