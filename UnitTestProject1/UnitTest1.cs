using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public static bool CheckMark(string mark)
        {
            if (!Regex.IsMatch(mark, "^[ABEKMHOPCTYX]{1}[0-9]{3}[ABEKMHOPCTYX]{2}[0-9]{3}"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
