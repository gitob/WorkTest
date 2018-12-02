using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkTest
{
    public class StringTry
    {
        private string _text;
        public string str;
        public StringTry(string text)
        {
            _text = text;
        }

        public int CountDistinct()
        {
            if (string.IsNullOrWhiteSpace(_text))
                _text = "MSLKFFPOKPOKAEMLE";

            var distinctCharactersCount = _text.GroupBy(x => x).Select(x => new
            {
                character = x.Key,
                count = x.Count()
            });

            var charactersCount = distinctCharactersCount.ToList();
            foreach (var it in charactersCount)
            {
                Console.WriteLine($"{it.character} count = {it.count}");
            }

            return charactersCount.Count;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
