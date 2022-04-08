using NUnit.Framework;
using Prime.Services;
using System;

namespace PrimeService.Tests;

[TestFixture]
public class PrimeServiceTests
{
    private PrimeServiceClass _primeService;
    [SetUp]
    public void Setup()
    {
        _primeService = new PrimeServiceClass();
    }

    [Test]
    [TestCase(2, ExpectedResult = true)]
    [TestCase(1, ExpectedResult = false)]
    [TestCase(-1, ExpectedResult = false)]
    public bool TestPrimeFunction(int value)
    {
        return _primeService.IsPrime(value);
    }

    [Test]
    public void TestPrimeDivideByZero()
    {
        var ex = Assert.Throws<DivideByZeroException>(() => _primeService.IsPrime(0));
        Assert.That(ex.Message, Is.EqualTo("Attempted to divide by zero."));
    }
}