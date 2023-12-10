using System;

namespace api.tests;

public class UnitTest1
{
    [Fact]
    public void Throw()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void Pass()
    {
        Assert.True(true);
    }

    [Fact]
    public void Fail()
    {
        Assert.True(false);
    }
}