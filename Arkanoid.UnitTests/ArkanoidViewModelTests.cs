using Arkanoid.Model;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Arkanoid.UnitTests
{
    public class UnitTests
    {
        public static string file = @"D:\\BRUDNOPIS\\testujemy\\Arkanoid\\bin\\Debug\\\\file.txt";

        [Test]
        public void TestFileContent()
        {
            if (new FileInfo(file).Length > 0)
            {
                Console.WriteLine("FILE IS NOT EMPTY");
            }
            else
            {
                Console.WriteLine("FILE IS EMPTY");
            }
        }
        [Test]
        public void TestingMock()
        {

            var author = new Mock<IRectangleItem>();
            author.SetupGet(p => p.X).Returns(1);
            author.SetupGet(p => p.Y).Returns(2);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1, author.Object.X);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(2, author.Object.Y);
        }


        [Test]
        public void TestingNUnit()
        {
            var a = new ViewModel.ArkanoidViewModel();


            var result = a.Test();


            NUnit.Framework.Assert.AreEqual("Helolo world!!", result);
        }

    }
}
