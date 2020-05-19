using System;
using System.Collections.Generic;

namespace MorseCode
{
    /// <summary>
    /// 
    /// </summary>
    public class MorseTranslator
    {
        private readonly Dictionary<string, string> morseDictionary = new Dictionary<string, string>
        {
            ["E"] = ".",
            ["SOS"] = "...|---|...",
            ["SOS SOS"] = "...|---|... ...|---|...",
            ["ADERLIS Y EDWIN"] = ".-|-..|.|.-.|.-..|.|... -.-- .|-..|.--|.|-.",
            ["WILSON Y OMAR"] = ".--|.|.-..|...|---|-. -.-- ---|--|.-|.-.",
            ["JACKSON Y ROBERT"] =  ".---|.-|-.-.|-.-|...|---|-. -.-- .-.|---|-...|.|.-.|-",
            ["SCRUM DEVELOPER"] =  "...|-.-.|.-.|..-|-- -..|.|...-|.|.-..|---|.--.|.|.-.",
            ["ALOES PMS"] =  ".-|.-..|---|.|... .--.|--|..."
        };

        public string Translate(string keyMessage)
        {
            if (keyMessage == null)
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(keyMessage) || string.IsNullOrWhiteSpace(keyMessage))
            {
                return "";
            }

            morseDictionary.TryGetValue(keyMessage, out string morseCode);

            return morseCode;
        }
    }
}