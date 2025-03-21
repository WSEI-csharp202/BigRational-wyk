using BigRationalLib;

namespace BigRationalTests;

[TestClass]
public sealed class Test1
{
    [DataTestMethod]
    [DataRow(1, 2, 1, 2)]
    [DataRow(1, -2, -1, 2)]
    [DataRow(-1, 2, -1, 2)]
    [DataRow(-1, -2, 1, 2)]
    [DataRow(0, 2, 0, 1)]
    [DataRow(0, -2, 0, 1)]
    [DataRow(-0, -2, 0, 1)]
    [DataRow(1, 1, 1, 1)]
    [DataRow(-3, 3, -1, 1)]
    [DataRow(6, 20, 3, 10)]
    public void Konstruktor_dwuargumentowy_danePoprawne(
            int l, int m, int l_expected, int m_expected
    )
    {
        // Arrange

        // Act
        var a = new BigRational(l, m);

        // Assert
        Assert.AreEqual(l_expected, a.Numerator);
        Assert.AreEqual(m_expected, a.Denominator);
    }

    [TestMethod]
    public void Konstruktor_dwuargumentowy_mianownikZero()
    {
        // Arrange
        // Act
        // Assert
        Assert.ThrowsException<DivideByZeroException>(
            () => new BigRational(1, 0));
    }
}

