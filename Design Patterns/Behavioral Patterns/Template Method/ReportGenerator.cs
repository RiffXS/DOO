namespace BehavioralPattern.TemplateMethod
{
  public abstract class ReportGenerator
  {
    public void GenerateReport()
    {
      GenerateHeader();
      Export();
    }

    protected virtual void GenerateHeader()
    {
      Console.WriteLine("Generating report header...");
    }

    protected abstract void Export();
  }
}