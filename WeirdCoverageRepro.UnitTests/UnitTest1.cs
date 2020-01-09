using Shouldly;
using System;
using Xunit;

namespace WeirdCoverageRepro.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Throws_if_target_is_null()
        {
            var target = (string)null;
            Should.Throw<ArgumentNullException>(() => target.Foo());
        }

        [Fact]
        public void Returns_expected_string_if_target_is_not_null()
        {
            var target = "foo";
            var expected = "Hello World!";

            var result = target.Foo();

            result.ShouldBe(expected);
        }
    }
}
