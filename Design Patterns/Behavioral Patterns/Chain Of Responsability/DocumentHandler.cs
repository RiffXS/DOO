namespace BehavioralPattern.ChainOfResponsability
{
  public abstract class DocumentHandler
  {
    protected DocumentHandler? Next;

    public DocumentHandler SetNext(DocumentHandler next)
    {
      Next = next;
      return next;
    }

    public void Handle(string documentType)
    {
      if (!Process(documentType) || Next != null)
      {
        Next?.Handle(documentType);
      }
      else if (Next == null)
      {
        Console.WriteLine($"Cannot process {documentType}.");
      }
    }

    protected abstract bool Process(string documentType);
  }
}