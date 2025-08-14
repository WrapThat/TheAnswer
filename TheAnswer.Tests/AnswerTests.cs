using NUnit.Framework;

namespace WrapThat.Tests
{
    public class Tests
    {
        [Test]
        public void ThatTheAnswerIsWhatever()
        {
            Assert.That(YouKnow.TheAnswer, Is.EqualTo(42));
        }

        [Test]
        public void ThatSomethingHasAnAnswer()
        {
            var sut = 42;
            Assert.That(sut, Is.EqualTo(YouKnow.TheAnswer));
        }

        [Test]
        public void ThatMethodsAlsoWorks()
        {
            Assert.That(YouKnow.GiveMeTheAnswer(), Is.EqualTo(42));
        }
    }
}