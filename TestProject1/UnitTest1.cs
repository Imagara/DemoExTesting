namespace TestProject1;
using ConsoleApp1;
public class Tests
{
    [Test]
    public void MinFromTwoNumbersTest()
    {
        Assert.That(Program.MinFromTwoNumbers(2, 5), Is.EqualTo(2));
    }
    [Test]
    public void IsMaxNumberTest()
    {
        Assert.IsTrue(Program.IsMaxNumber(5, 2));
        Assert.IsFalse(Program.IsMaxNumber(1, 555));
    } 
    [Test]
    public void MetrInSmTest()
    {
        Assert.AreEqual(Program.MetrInSm(5), 500);
        Assert.AreEqual(Program.MetrInSm(2), 200);
    }
    [Test]
    public void CheckDateTest()
    {
        Assert.IsTrue(Program.CheckDate("15.02.2000"));
        Assert.IsFalse(Program.CheckDate(""));
    }
    [Test]
    public void TryAuthTest()
    {
        Assert.IsTrue(Program.TryAuth("valera","lalka"));
        Assert.IsFalse(Program.TryAuth("valera",""));
        Assert.IsFalse(Program.TryAuth("VAL",""));
    }
    [Test]
    public void TryRegTest()
    {
        Assert.IsTrue(Program.TryReg("valera","lalka","qqweqkw@gmail.com","16.05.2000"));
        Assert.IsFalse(Program.TryReg("valera","   ","qqweqkw@gmail.com","16.05.2000"));
        Assert.IsFalse(Program.TryReg("valera"," ","qqweqkw@gmail.com","16.05.2000"));
        Assert.IsFalse(Program.TryReg("qwe","qwe","qqweqkw@gmail.com","16.05.2000"));
        Assert.IsFalse(Program.TryReg("w","qqweqwe","qqweqkw@gmail.com","16.05.2000"));
        Assert.IsFalse(Program.TryReg("valera","qqweqwe","qqweqkw@gmail","16.05.2000"));
        Assert.IsFalse(Program.TryReg("valera","qqweqwe","qqweqkwmail.dl","16.05.2000"));
        Assert.IsFalse(Program.TryReg("valera","lalka","qqweqkwmail.dl",""));
    }
}