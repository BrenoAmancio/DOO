namespace BehavioralPatterns.Command
{

    // Classe para demonstrar o uso
    public class CommandDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== COMMAND PATTERN ===");
            
            var editor = new TextEditor();
            var commandManager = new CommandManager();

            commandManager.ExecuteCommand(new WriteTextCommand(editor, "Hello, "));
            commandManager.ExecuteCommand(new WriteTextCommand(editor, "world!"));
            Console.WriteLine($"Content: '{editor.GetContent()}'");

            commandManager.Undo();
            Console.WriteLine($"After undo: '{editor.GetContent()}'");
            
            commandManager.Undo();
            Console.WriteLine($"After second undo: '{editor.GetContent()}'");
            
            commandManager.Redo();
            Console.WriteLine($"After redo: '{editor.GetContent()}'");
        }
    }
}