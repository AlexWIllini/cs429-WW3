using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ArmyTest
{
    [TestMethod]
    public void TestConstruction()
    {
        var a = new Army(new Pos(0, 3), 100);
        Assert.AreEqual(100, a.Health);
        Assert.AreEqual(0, a.Position.X);
        Assert.AreEqual(3, a.Position.Y);
    }

    [TestMethod]
    public void TestUpdateResources()
    {
        var army = new Army(new Pos(0, 0), 0);
        var province = new Province();
        province.Tick();
        army.UpdateResources(province);
        Assert.AreEqual(10, army.Health);
    }
}
