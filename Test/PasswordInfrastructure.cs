using Database;
using Xunit;

namespace Test
{
    public class PasswordInfrastructure
    {
        [Theory]
        [InlineData("password")]
        [InlineData("testaASD")]
        [InlineData("asda789Wac1")]
        [InlineData("@#4as12c1?_!/")]
        [InlineData("zxczxc,./@.,")]
        public void PasswordHashingAndVerificationEqualsTrue(string pass)
        {
            var hash = HashInfrastructure.Hash(pass);
            Assert.True(HashInfrastructure.Verify(hash, pass));
        }

        [Theory]
        [InlineData("password", "asd")]
        [InlineData("testaASD", "asdw4234")]
        [InlineData("asda789Wac1", "asda789Wac2")]
        [InlineData("@#4as12c1?_!/", "asda3we4")]
        [InlineData("zxczxc,./@.,", "asdw1qe64")]
        public void WrongPasswordVerification(string pass, string bad)
        {
            var hash = HashInfrastructure.Hash(pass);
            Assert.False(HashInfrastructure.Verify(hash, bad));
        }
    }
}
