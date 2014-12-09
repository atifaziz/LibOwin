namespace LibOwin.Owin
{
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit;

    public class RequestCookiesTests
    {
        [Fact]
        public void Can_get_request_cookies()
        {
            var requestCookies = new RequestCookiesCollection();
            requestCookies.Reparse("a=1; a=2");

            IList<string> values = requestCookies.GetValues("a");

            values.Count.Should().Be(2);
        }
    }
}