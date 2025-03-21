using System.Numerics;

namespace BigRationalLib;

// immutable
public readonly partial struct BigRational
{
    public BigInteger Numerator { get; }
    public BigInteger Denominator { get; } // always positive

    #region ctor's
    public BigRational(BigInteger numerator, BigInteger denominator)
    {
        if (denominator.Sign == 0)
            throw new DivideByZeroException("Denominator is zero");
        if (denominator.Sign < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }
        BigInteger gcd = BigInteger.GreatestCommonDivisor(numerator, denominator);
        Numerator = numerator / gcd;
        Denominator = denominator / gcd;
    }

    public BigRational(BigInteger numerator)
    {
        Numerator = numerator;
        Denominator = BigInteger.One;
    }

    public BigRational() : this(BigInteger.Zero) { }
    #endregion

    override public string ToString() => 
        Denominator == 1 ? Numerator.ToString() : $"{Numerator}/{Denominator}";
}

