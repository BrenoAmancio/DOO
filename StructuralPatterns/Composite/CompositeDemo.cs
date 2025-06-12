namespace StructuralPatterns.Composite
{

    public class CompositeDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== COMPOSITE PATTERN ===");
            
            var mainMenu = new Menu("Main Menu");
            
            var appetizers = new Menu("Appetizers");
            appetizers.Add(new MenuItem("Caesar Salad", 8.50m));
            appetizers.Add(new MenuItem("Soup of the Day", 6.00m));
            
            var mainCourses = new Menu("Main Courses");
            mainCourses.Add(new MenuItem("Grilled Salmon", 18.99m));
            mainCourses.Add(new MenuItem("Beef Steak", 22.50m));
            
            mainMenu.Add(appetizers);
            mainMenu.Add(mainCourses);
            mainMenu.Add(new MenuItem("Coffee", 3.50m));
            
            mainMenu.Display();
        }
    }
}