using Xunit;

namespace Empty;

public class UnitTest
{
    [Fact] public void Passing1() { }
    [Fact] public void Passing2() { }
    [Fact] public void Passing3() { }
    [Fact] public void Passing4() { }
    [Fact] public void Failing1() => Assert.Fail("I'm a failing test");
    [Fact] public void Passing5() { }
    [Fact] public void Passing6() { }
    [Fact] public void Passing7() { }
    [Fact] public void Passing8() { }
    [Fact] public void Failing2() => Assert.Fail("I'm a failing test");
    [Fact] public void Passing9() { }
    [Fact] public void Passing10() { }
    [Fact] public void Passing11() { }
    [Fact] public void Passing12() { }
    [Fact] public void Failing3() => Assert.Fail("I'm a failing test");
    [Fact] public void Passing13() { }
    [Fact] public void Passing14() { }
    [Fact] public void Passing15() { }
    [Fact] public void Passing16() { }
    [Fact] public void Failing4() => Assert.Fail("I'm a failing test");
    [Fact] public void Passing17() { }
    [Fact] public void Passing18() { }
    [Fact] public void Passing19() { }
    [Fact] public void Passing20() { }
    [Fact] public void Failing5() => Assert.Fail("I'm a failing test");
}