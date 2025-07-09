namespace BehavioralPattern.TemplateMethod
{
  public class ExcelReportGenerator : ReportGenerator
  {
    protected override void Export()
    {
        Console.WriteLine("Exporting to Excel...");
    }
  }
}