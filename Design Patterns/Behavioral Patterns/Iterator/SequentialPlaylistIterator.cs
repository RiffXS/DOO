namespace BehavioralPattern.Iterator
{
  class SequentialPlaylistIterator : Iterator
  {
    private readonly List<string> _originalSongs;
    private int _position = -1;

    public SequentialPlaylistIterator(List<string> songs)
    {
      _originalSongs = new List<string>(songs);
    }

    public override int Key()
    {
      return _position;
    }

    public override object Current()
    {
      try
      {
        return _originalSongs[_position];
      }
      catch (IndexOutOfRangeException)
      {
        throw new InvalidOperationException();
      }
    }

    public override bool MoveNext()
    {
      _position++;
      return _position < _originalSongs.Count;
    }

    public override void Reset()
    {
      _position = -1;
    }
  }
}