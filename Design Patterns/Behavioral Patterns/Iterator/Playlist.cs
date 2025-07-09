using System.Collections;

namespace BehavioralPattern.Iterator
{
  public class Playlist : IteratorAggregate
  {
    private List<string> _songs = new List<string>();
    private bool _shuffle = false;

    public void SetShuffle(bool shuffle)
    {
      _shuffle = shuffle;
    }

    public void Add(string song)
    {
      _songs.Add(song);
    }

    public override IEnumerator GetEnumerator()
    {
      if (_shuffle)
      {
        return new ShuffledPlaylistIterator(_songs);
      }
      return new SequentialPlaylistIterator(_songs);
    }
  }
}