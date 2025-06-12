namespace BehavioralPatterns.Command
{

    // Comandos concretos
    public class WriteTextCommand : ICommand
    {
        private TextEditor _editor;
        private string _text;

        public WriteTextCommand(TextEditor editor, string text)
        {
            _editor = editor;
            _text = text;
        }

        public void Execute()
        {
            _editor.Write(_text);
        }

        public void Undo()
        {
            _editor.Delete(_text.Length);
        }
    }
}