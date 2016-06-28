using Xunit;

namespace FizzbuzBrownBag
{
    public class Tests
    {
        [Fact]
        public void Given_series_starts_and_finishes_at_1_When_translated_Then_1_is_returned()
        {
            var sut = new Fizzbuzzer();
            var actual = sut.DummyMethod(1,1);
            Assert.Equal("1", actual);
        }
    }
}
