namespace BehavioralPatterns.Command
{

    public class DeleteTextCommand : ICommand
    {
        private TextEditor _editor;
        private int _length;
        private string _deletedText;

        public DeleteTextCommand(TextEditor editor, int length)
        {
            _editor = editor;
            _length = length;
        }

        public void Execute()
        {
            string content = _editor.GetContent();
            if (content.Length >= _length)
            {
                _deletedText = content.Substring(content.Length - _length);
                _editor.Delete(_length);
            }
        }

        public void Undo()
        {
            if (_deletedText != null)
            {
                _editor.Write(_deletedText);
            }
        }
    }
}