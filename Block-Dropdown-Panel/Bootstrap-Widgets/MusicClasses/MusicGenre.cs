using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplesData
{
  public class MusicGenre
  {
    public MusicGenre()
    {
      GenreId = 0;
      Genre = string.Empty;
      IsSelected = false;
    }

    public MusicGenre(int id, string genre)
    {
      GenreId = id;
      Genre = genre;
      IsSelected = false;
    }

    public int GenreId { get; set; }
    public string Genre {get;set;}
    public bool IsSelected { get; set; }

    public override string ToString()
    {
      return Genre;
    }
  }
}
