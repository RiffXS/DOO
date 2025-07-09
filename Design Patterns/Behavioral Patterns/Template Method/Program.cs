using System;

namespace BehavioralPattern.TemplateMethod
{
  public class Program
  {
    public static void Main()
    {
      var pdfReport = new PdfReportGenerator();
      pdfReport.GenerateReport();

      Console.WriteLine();

      var excelReport = new ExcelReportGenerator();
      excelReport.GenerateReport();
    }
  }
}
