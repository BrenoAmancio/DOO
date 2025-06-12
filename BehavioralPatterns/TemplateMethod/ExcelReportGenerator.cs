namespace BehavioralPatterns.TemplateMethod
{

    public class ExcelReportGenerator : ReportGenerator
    {
        protected override void GenerateBody()
        {
            Console.WriteLine("Generating Excel report body...");
        }

        protected override void Export()
        {
            Console.WriteLine("Exporting to Excel...");
        }
    }
}