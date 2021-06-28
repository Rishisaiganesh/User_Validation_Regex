using NUnit.Framework;

namespace Regex.Test
{
    public class Tests
    {
        public double PNumber { get; private set; }
        public double Name { get; private set; }
        public double Password { get; private set; }
        public double Mail { get; private set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivingDetails_OfthePersons()
        {
            Validattion val = new Validattion();
            string name = val.ValidatingName("Rishisaiganesh");
            string mail = val.ValidatingMail("Crazy67@Gamil.com");
            string Number = val.ValidatingPNumber("919840981202");
            string password = val.validatingPassword("Carazy67@");
            Assert.AreEqual(name, Name);
            Assert.AreEqual(Mail, Mail);
            Assert.AreEqual(Number, PNumber);
            Assert.AreEqual(password, Password);
        }
    }
}