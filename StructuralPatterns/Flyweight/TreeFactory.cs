namespace StructuralPatterns.Flyweight
{

    // Factory para gerenciar flyweights
    public class TreeFactory
    {
        private static Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            string key = $"{name}-{color}-{texture}";
            
            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color, texture);
                Console.WriteLine($"Created new TreeType: {key}");
            }
            
            return _treeTypes[key];
        }

        public static int GetCreatedTreeTypesCount()
        {
            return _treeTypes.Count;
        }
    }
}