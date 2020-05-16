using MorseCode;
using NUnit.Framework;

namespace MorseCodeTest
{
    /*
     * PO Test Cases:
     * [TestCase("", "")] DONE
     * [TestCase("E", ".")] DONE
        [TestCase("SOS", "...|---|...")]
        [TestCase("SOS SOS", "...|---|... ...|---|...")]
        [TestCase("ADERLIS Y EDWIN", ".-|-..|.|.-.|.-..|.|... -.-- .|-..|.--|.|-.")]
        [TestCase("WILSON Y OMAR", ".--|.|.-..|...|---|-. -.-- ---|--|.-|.-.")]
        [TestCase("JACKSON Y ROBERT", ".---|.-|-.-.|-.-|...|---|-. -.-- .-.|---|-...|.|.-.|-")]
        [TestCase("SCRUM DEVELOPER", "...|-.-.|.-.|..-|-- -..|.|...-|.|.-..|---|.--.|.|.-.")]
        [TestCase("ALOES PMS", ".-|.-..|---|.|... .--.|--|...")]
     */
    [TestFixture]
    public class MorseTranslatorTest
    {
        [Test]
        public void Empty_String_Returns_Empty_String() {
            var translator = new MorseTranslator();

            string response = translator.Translate("");

            Assert.That(response, Is.Empty);
        }

        [Test]
        public void String_With_E_Returns_Dot()
        {
            var translator = new MorseTranslator();

            string response = translator.Translate("E");

            Assert.That(response, Is.EqualTo("."));
        }
    }
}
