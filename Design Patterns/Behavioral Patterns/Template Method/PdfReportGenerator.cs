namespace BehavioralPattern.TemplateMethod
{
  public class PdfReportGenerator : ReportGenerator
  {
    protected override void Export()
    {
        Console.WriteLine("Exporting to PDF...");
    }
  }
}