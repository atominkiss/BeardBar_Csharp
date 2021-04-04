using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BeardBar.Domain.Entities;

namespace BeardBar.Domain.Abstract
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> Beers { get; }
    }
}
