using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhytmixReload.Interfaces
{
    public interface ISong
    {
        string Name { get; }
        string Artist { get; }
        string Description { get; }
        int Likes { get; set; }
        string length {  get; }

    }
}
