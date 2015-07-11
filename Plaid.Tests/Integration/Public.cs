using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaid.Tests.Integration
{
    using NUnit.Framework;

    using Should;

    [TestFixture]
    public class Public
    {
        private Plaid _p;

        [SetUp]
        public void Setup()
        {
            _p = new Plaid("herp","derp");
        }

        [Test]
        public async void Categories()
        {
            var c = await _p.GetCategoriesTask();

            c.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public async void Institutions()
        {
            var i = await _p.GetInstitutionsTask();

            i.Count.ShouldBeGreaterThan(0);
        }


    }
}
