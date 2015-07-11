using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaid.Tests.Unit
{
    using System.Net.Http;

    using NUnit.Framework;

    using Should;

    [TestFixture]
    public class Basic
    {
        [Test]
        public async void should_have_accept_header()
        {
            var fake = new FakeResponseHandler();
            var client = new HttpClient(fake);
            var plaid = new Plaid("fakeId","fakeKey",client);

            var insitutions = plaid.GetInstitutionsTask().Result;

            insitutions.Count.ShouldBeGreaterThan(1);
        }

    }
}
