﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

   







        }
    }
}

class Cat
{
    //ToDo: finish this method
    public bool CatIsPlaying(bool isSummer, int temp)
    {





        return false;
    }
}
[TestClass]
public class UnitTest1
{
    public Cat cat = new Cat();

    [TestMethod]
    public void TestMethod_Summer_Temp_40()
    {
        bool result = cat.CatIsPlaying(true, 45);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestMethod_Winter_Temp_40()
    {
        bool result = cat.CatIsPlaying(false, 45);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_Summer_Temp_10()
    {
        bool result = cat.CatIsPlaying(true, 10);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_Winter_Temp_10()
    {
        bool result = cat.CatIsPlaying(false, 10);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestMethod_Winter_Temp_25()
    {
        bool result = cat.CatIsPlaying(false, 25);
        Assert.IsTrue(result);
    }
}