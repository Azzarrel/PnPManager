using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnpManager.Elements.Interfaces
{
    public interface ISuggestionProvider
    {

        IEnumerable GetSuggestions(string filter);


    }
}
