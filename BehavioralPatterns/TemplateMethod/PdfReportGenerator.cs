namespace BehavioralPatterns.TemplateMethod
{

    // Implementações concretas
    public class PdfReportGenerator : ReportGenerator
    {
        protected override void GenerateBody()
        {
            Console.WriteLine("Generating PDF report body...");
        }

        protected override void Export()
        {
            Console.WriteLine("Exporting to PDF...");
        }
    }
}