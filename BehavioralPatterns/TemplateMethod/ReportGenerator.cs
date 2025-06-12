namespace BehavioralPatterns.TemplateMethod
{
    // Classe template
    public abstract class ReportGenerator
    {
        // Template method
        public void GenerateReport()
        {
            GenerateHeader();
            GenerateBody();
            GenerateFooter();
            Export();
        }

        protected void GenerateHeader()
        {
            Console.WriteLine("Generating report header...");
        }

        protected abstract void GenerateBody();

        protected void GenerateFooter()
        {
            Console.WriteLine("Generating report footer...");
        }

        protected abstract void Export();
    }
}