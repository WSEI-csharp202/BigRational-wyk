namespace BigRationalLib;

public readonly partial struct BigRational : IEquatable<BigRational>
{
    public bool Equals(BigRational other)
    {
        return Numerator == other.Numerator &&
               Denominator == other.Denominator;
    }

    override public bool Equals(object? obj)
    {
        return obj is BigRational other && Equals(other);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Numerator, Denominator);
    }

    public static bool operator ==(BigRational left, BigRational right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(BigRational left, BigRational right)
    {
        return !left.Equals(right);
    }
}
