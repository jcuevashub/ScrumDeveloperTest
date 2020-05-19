using MorseCode;
using NUnit.Framework;
using System;
using System.Runtime.CompilerServices;

namespace MorseCodeTest
{
    /*
     * PO Test Cases:
     * [TestCase("", "")] DONE
     * [TestCase("E", ".")] DONE
        [TestCase("SOS", "...|---|...")]
        [TestCase("SOS SOS", "...|---|... ...|---|...")]
        c
        [TestCase("WILSON Y OMAR", ".--|.|.-..|...|---|-. -.-- ---|--|.-|.-.")]
        [TestCase("JACKSON Y ROBERT", ".---|.-|-.-.|-.-|...|---|-. -.-- .-.|---|-...|.|.-.|-")]
        [TestCase("SCRUM DEVELOPER", "...|-.-.|.-.|..-|-- -..|.|...-|.|.-..|---|.--.|.|.-.")]
        [TestCase("ALOES PMS", ".-|.-..|---|.|... .--.|--|...")]
         [Test]

     */
    [TestFixture]
    public class MorseTranslatorTest
    {
        [TestCase(" ", "")]
        [TestCase("", "")]
        [TestCase("ALOES PMS", ".-|.-..|---|.|... .--.|--|...")]
        [TestCase("SCRUM DEVELOPER", "...|-.-.|.-.|..-|-- -..|.|...-|.|.-..|---|.--.|.|.-.")]
        [TestCase("JACKSON Y ROBERT", ".---|.-|-.-.|-.-|...|---|-. -.-- .-.|---|-...|.|.-.|-")]
        [TestCase("WILSON Y OMAR", ".--|.|.-..|...|---|-. -.-- ---|--|.-|.-.")]
        [TestCase("ADERLIS Y EDWIN", ".-|-..|.|.-.|.-..|.|... -.-- .|-..|.--|.|-.")]
        [TestCase("SOS SOS", "...|---|... ...|---|...")]
        [TestCase("SOS", "...|---|...")]
        [TestCase("E", ".")]
        public void String_Message_Return_Morse_Code(string message, string morseCode)
        {
            var translator = new MorseTranslator();

            string response = translator.Translate(message);

            Assert.That(response, Is.EqualTo(morseCode));
        }

        [Test]
        public void Null_Message_Return_ArgumentNullException()
        {
            var translator = new MorseTranslator();

            Assert.Throws(Is.TypeOf<ArgumentNullException>(), () => translator.Translate(null));
        }
    }
}
