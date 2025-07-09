namespace BehavioralPattern.Iterator
{
  class ShuffledPlaylistIterator : Iterator
  {
    private readonly List<string> _originalSongs;
    private List<string> _shuffledSongs;
    private int _position = -1;
    private static readonly Random _random = new Random();

    public ShuffledPlaylistIterator(List<string> songs)
    {
      _originalSongs = new List<string>(songs);
      _shuffledSongs = new List<string>(songs);
      Shuffle();
    }

    public override int Key()
    {
      return _position;
    }

    public override object Current()
    {
      try
      {
        return _shuffledSongs[_position];
      }
      catch (IndexOutOfRangeException)
      {
        throw new InvalidOperationException();
      }
    }

    public override bool MoveNext()
    {
      _position++;
      return _position < _shuffledSongs.Count;
    }

    public override void Reset()
    {
      Shuffle();
      _position = -1;
    }

    private void Shuffle()
    {
      int n = _shuffledSongs.Count;
      while (n > 1)
      {
        n--;
        int k = _random.Next(n + 1);
        (_shuffledSongs[n], _shuffledSongs[k]) = (_shuffledSongs[k], _shuffledSongs[n]);
      }
    }
  }
}