using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartyGame;
using Xunit;

namespace Test
{
    public class UniqGeneratorTest
    {
        [Fact]
        public void UniqGeneratorKeyNotEmptyOrNull()
        {
            var gen = new UniqGenerator();
            var key = gen.GenerateKey();
            Assert.False(string.IsNullOrEmpty(key));
        }

        [Fact]
        public void UniqGeneratorUserNameNotEmptyOrNull()
        {
            var gen = new UniqGenerator();
            var name = gen.GenerateUsername();
            Assert.False(string.IsNullOrEmpty(name));
        }
    }
}
