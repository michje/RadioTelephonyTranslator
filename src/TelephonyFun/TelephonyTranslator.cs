using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TelephonyFun
{
    public class TelephonyTranslator
    {
        private readonly List<TelephoneTranslation> _translations = new List<TelephoneTranslation>();

        public TelephonyTranslator()
        {
            _translations.Add(new TelephoneTranslation() { Letter = 'A', Telephony = "ALFA" });
            _translations.Add(new TelephoneTranslation() { Letter = 'B', Telephony = "BRAVO" });
            _translations.Add(new TelephoneTranslation() { Letter = 'C', Telephony = "CHARLIE" });
            _translations.Add(new TelephoneTranslation() { Letter = 'D', Telephony = "DELTA" });
            _translations.Add(new TelephoneTranslation() { Letter = 'E', Telephony = "ECHO" });
            _translations.Add(new TelephoneTranslation() { Letter = 'F', Telephony = "FOXTROT" });
            _translations.Add(new TelephoneTranslation() { Letter = 'G', Telephony = "GOLF" });
            _translations.Add(new TelephoneTranslation() { Letter = 'H', Telephony = "HOTEL" });
            _translations.Add(new TelephoneTranslation() { Letter = 'I', Telephony = "INDIA" });
            _translations.Add(new TelephoneTranslation() { Letter = 'J', Telephony = "JULIET" });
            _translations.Add(new TelephoneTranslation() { Letter = 'K', Telephony = "KILO" });
            _translations.Add(new TelephoneTranslation() { Letter = 'L', Telephony = "LIMA" });
            _translations.Add(new TelephoneTranslation() { Letter = 'M', Telephony = "MIKE" });
            _translations.Add(new TelephoneTranslation() { Letter = 'N', Telephony = "NOVEMBER" });
            _translations.Add(new TelephoneTranslation() { Letter = 'O', Telephony = "OSCAR" });
            _translations.Add(new TelephoneTranslation() { Letter = 'P', Telephony = "PAPA" });
            _translations.Add(new TelephoneTranslation() { Letter = 'Q', Telephony = "QUEBEC" });
            _translations.Add(new TelephoneTranslation() { Letter = 'R', Telephony = "ROMEO" });
            _translations.Add(new TelephoneTranslation() { Letter = 'S', Telephony = "SIERRA" });
            _translations.Add(new TelephoneTranslation() { Letter = 'T', Telephony = "TANGO" });
            _translations.Add(new TelephoneTranslation() { Letter = 'U', Telephony = "UNIFORM" });
            _translations.Add(new TelephoneTranslation() { Letter = 'V', Telephony = "VICTOR" });
            _translations.Add(new TelephoneTranslation() { Letter = 'W', Telephony = "WHISKEY" });
            _translations.Add(new TelephoneTranslation() { Letter = 'X', Telephony = "XRAY" });
            _translations.Add(new TelephoneTranslation() { Letter = 'Y', Telephony = "YANKEE" });
            _translations.Add(new TelephoneTranslation() { Letter = 'Z', Telephony = "ZULU" });
            _translations.Add(new TelephoneTranslation() { Letter = '0', Telephony = "ZERO" });
            _translations.Add(new TelephoneTranslation() { Letter = '1', Telephony = "ONE" });
            _translations.Add(new TelephoneTranslation() { Letter = '2', Telephony = "TWO" });
            _translations.Add(new TelephoneTranslation() { Letter = '3', Telephony = "THREE" });
            _translations.Add(new TelephoneTranslation() { Letter = '4', Telephony = "FOUR" });
            _translations.Add(new TelephoneTranslation() { Letter = '5', Telephony = "FIVE" });
            _translations.Add(new TelephoneTranslation() { Letter = '6', Telephony = "SIX" });
            _translations.Add(new TelephoneTranslation() { Letter = '7', Telephony = "SEVEN" });
            _translations.Add(new TelephoneTranslation() { Letter = '8', Telephony = "EIGHT" });
            _translations.Add(new TelephoneTranslation() { Letter = '9', Telephony = "NINE" });
        }

        public IList<TelephoneTranslation> Translate(string text)
        {
            if (string.IsNullOrEmpty(text)) return new List<TelephoneTranslation>();

            var translations = new List<TelephoneTranslation>();

            foreach (var letter in text.ToUpper())
            {
                var telephony = _translations.FirstOrDefault(x => x.Letter.Equals(letter));

                translations.Add(telephony ?? new TelephoneTranslation() { Letter = letter, Telephony = letter.ToString() });
            }

            return translations;
        }

    }
}
