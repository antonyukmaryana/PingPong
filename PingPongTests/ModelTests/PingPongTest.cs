using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingGame;

namespace PingGame.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsPingPong_NumberDivisibleByThree_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("ping", testPingPong.IsPingPong(3));
    }
    [TestMethod]
    public void IsPingPong_NumberDivisibleByFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("pong", testPingPong.IsPingPong(5));

    }
    [TestMethod]
    public void IsPingPong_NumberDivisibleByThreeAndFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("pingpong", testPingPong.IsPingPong(15));
    }

  }
}
