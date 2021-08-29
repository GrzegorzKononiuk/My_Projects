using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arkanoid.UnitTests
{
    class ArkanoidViewModelTests
    {
        [Test]
        public void Testing()
        {
            var a = new ViewModel.ArkanoidViewModel();


            var result = a.Test();

            
            Assert.AreEqual("Helolo world!!", result);
        }

    }
}
