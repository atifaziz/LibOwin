namespace LibOwin.Owin
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using FluentAssertions;
    using Shouldly;
    using Xunit;

    public class OwinRequestTests
    {
        [Fact]
        public void When_request_user_is_not_defined_should_get_null()
        {
            var environment = new Dictionary<string, object>();
            var owinRequest = new OwinRequest(environment);
            owinRequest.User.Should().BeNull();
        }

        [Fact]
        public void When_request_user_is_defined_can_get_value()
        {
            var environment = new Dictionary<string, object>
            {
                { "owin.RequestUser", new ClaimsPrincipal() }
            };
            var owinRequest = new OwinRequest(environment);
            owinRequest.User.Should().NotBeNull();
        }

        [Fact]
        public void When_server_user_is_defined_can_get_value()
        {
            var environment = new Dictionary<string, object>
            {
                { "server.User", new ClaimsPrincipal() }
            };
            var owinRequest = new OwinRequest(environment);
            owinRequest.User.Should().NotBeNull();
        }

        [Fact]
        public void Can_set_user()
        {
            var environment = new Dictionary<string, object>();
            var owinRequest = new OwinRequest(environment)
            {
                User = new ClaimsPrincipal()
            };

            environment.ShouldContainKey("owin.RequestUser");
        }
    }
}