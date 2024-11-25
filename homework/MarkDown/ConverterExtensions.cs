using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MarkDown
{
    public static class ConverterExtensions
    {
        private static Dictionary<Tag, string> _tagToString =
            new Dictionary<Tag, string>()
            {
                { Tag.HeadStart, "#" },
                { Tag.HeadEnd, "\n" },
                { Tag.StrongStart, "__" },
                { Tag.StrongEnd, "__" },
                { Tag.ItalicStart, "_" },
                { Tag.ItalicEnd, "_" }

            };

        private static Dictionary<string, Tag> _stringToTag =
            new Dictionary<string, Tag>()
            {
                { "#", Tag.HeadStart },
                { "\n", Tag.HeadEnd },
                { "__", Tag.StrongStart },
                { "__", Tag.StrongEnd },
                { "_", Tag.ItalicStart },
                { "_", Tag.ItalicEnd }

            };

        private static Dictionary<Tag, string> _tagToHtml =
            new Dictionary<Tag, string>()
            {
                { Tag.HeadStart, "\\<h1>" },
                { Tag.HeadEnd, "\\</h1>" },
                { Tag.StrongStart, "\\<strong>" },
                { Tag.StrongEnd, "\\</strong>" },
                { Tag.ItalicStart, "\\<em>" },
                { Tag.ItalicEnd, "\\</em>" }

            };

        public static string ToString(this Tag tag)
        {
            return _tagToString[tag];
        }

        public static Tag ToTag(this string element)
        {
            return _stringToTag[element];
        }

        public static string ToHtml(this Tag tag)
        {
            return _tagToHtml[tag];
        }
    }
}
