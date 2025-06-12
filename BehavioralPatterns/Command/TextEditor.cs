using System;
using System.Text;

namespace BehavioralPatterns.Command
{
    // Receiver - Editor de texto
    public class TextEditor
    {
        private StringBuilder _content = new StringBuilder();

        public void Write(string text)
        {
            _content.Append(text);
        }

        public void Delete(int length)
        {
            if (_content.Length >= length)
            {
                _content.Remove(_content.Length - length, length);
            }
        }

        public string GetContent()
        {
            return _content.ToString();
        }
    }
}