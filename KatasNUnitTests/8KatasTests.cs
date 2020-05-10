using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Katas.Katas;
using Katas.Katas._8kyu.DecibelScale;

namespace KatasNUnitTests
{
    [TestFixture]
    public class _8KatasTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1e-12).Returns(0);

            }
        }
        [Test,TestCaseSource("testCases")]
        public double Test(double intensity)
            =>Math.Round(DecibelScale.DbScale(intensity),MidpointRounding.AwayFromZero);
    }
}
