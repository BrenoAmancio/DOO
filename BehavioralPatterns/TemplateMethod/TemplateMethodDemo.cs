namespace BehavioralPatterns.TemplateMethod
{

    // Classe para demonstrar o uso
    public class TemplateMethodDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== TEMPLATE METHOD PATTERN ===");
            
            Console.WriteLine("PDF Report:");
            var pdfReport = new PdfReportGenerator();
            pdfReport.GenerateReport();

            Console.WriteLine("\nExcel Report:");
            var excelReport = new ExcelReportGenerator();
            excelReport.GenerateReport();
        }
    }
}