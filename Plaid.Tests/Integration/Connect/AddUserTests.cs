using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaid.Tests.Integration.AddUser
{
    using NUnit.Framework;

    using Should;

    [TestFixture]
    public class AddUserTests
    {
        private Plaid _client;

        [SetUp]
        public void Setup()
        {
            _client = new Plaid("test_id","test_secret");
        }

        [Test]
        public async void should_add_user_amex_no_mfa()
        {
            var r = await _client.Connect.AddUser("plaid_test", "plaid_good", "amex");

            r.accounts.Count().ShouldEqual(4);
        }

        [TestCase("chase")]
        [TestCase("bofa")]
        [TestCase("capone360")]
        [TestCase("citi")]
        [TestCase("pnc")]
        [TestCase("us")]
        [TestCase("usaa")]
        [TestCase("amex")]
        public async void should_have_mfa(string institution)
        {
            var r = await _client.Connect.AddUser("plaid_test", "plaid_good", institution);
            r.MfaRequired.ShouldBeTrue();
        }
    }

}
