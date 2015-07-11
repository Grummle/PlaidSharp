using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plaid.Tests.Unit
{
    using Newtonsoft.Json;

    using NUnit.Framework;

    using Should;

    [TestFixture]
    public class SerializationTests
    {
        [Test]
        public void should_serialize_add_user_mfa_response()
        {
           var result = @"{
                          ""type"": ""list"",
                          ""mfa"": [
                            {
                              ""mask"": ""xxx-xxx-5309"",
                              ""type"": ""phone""
                            },
                            {
                              ""mask"": ""t..t@plaid.com"",
                              ""type"": ""email""
                            }
                          ],
                          ""access_token"": ""test_chase""
                        }";

            var derp = JsonConvert.DeserializeObject<AddUserResponse>(result);
            derp.type.ShouldEqual("list");
            derp.mfa.Count().ShouldEqual(2);
        }
    }
}
