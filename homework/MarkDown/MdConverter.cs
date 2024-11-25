using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarkDown.ConverterExtensions;

namespace MarkDown
{
    public class MdConverter
    {
        private static HashSet<char> _serviceSymbols = new HashSet<char> { '_', '#', '\n' };
        private HashSet<int> _occupiedIndexes = new();
        private Stack<(int, Tag)> _tags = new();
        private string _text;

        public string Convert(string text)
        {
            _text = text;
            for (var i = 0; i < _text.Length; i++)
            {
                CheckChar(i);
            }
            return _text;
        }

        private void CheckChar(int index)
        {
            var element = _text[index];
            if (_serviceSymbols.Contains(element))
                AddToStack(element.ToString().ToTag(), index);
        }

        private void AddToStack(Tag tag, int index)
        {
            if (tag - _tags.Last().Item2 == 1) //Значит, что это пара начало и конец
            {
                ConvertTag(_tags.Last().Item1, index, tag);
            }
        }

        private void ConvertTag(int start, int end, Tag tag) 
        {
        }
    }
}
