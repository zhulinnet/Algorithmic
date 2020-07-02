using Microsoft.VisualStudio.TestTools.UnitTesting;
using algorithmStudy.Services.Security;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace algorithmStudy.Services.Security.Tests
{
    [TestClass()]
    public class DiffieHellmanTests
    {
        [TestMethod()]
        public void GetKeyTest()
        {
            int p = 23;
            DiffieHellman dh = new DiffieHellman();
            Assert.AreEqual(dh.IsPrime(p), true);
            dh.P = p;
            dh.G = dh.GetPrimitiveRoot(p).FirstOrDefault();
            int SA = dh.GetS();
            double P_SA = dh.GetCalculation(SA);
            int SB = dh.GetS();
            double P_SB = dh.GetCalculation(SB);
            double P_SA_SB = dh.GetKey(P_SB, SA);
            double P_SB_SA = dh.GetKey(P_SA, SB);
            Assert.AreEqual(P_SA_SB, P_SB_SA);

        }
    }
}