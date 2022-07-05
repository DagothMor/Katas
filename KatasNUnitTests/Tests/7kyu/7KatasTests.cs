using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Katas.Katas;
using Katas.Katas._7kyu.LargestFiveDigitNumberInASeries;
using Katas.Katas._8kyu.DecibelScale;

namespace KatasNUnitTests
{
    [TestFixture]
    public class _7KatasTests
    {
        [Test]
        public void FirstTest()
        {
            string text = "1234567898765";
            Assert.AreEqual("98765",LargestFiveDigitNumberInASeries.GetNumber(text));
        }
    }
}
