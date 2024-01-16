using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.AdapterInterface
{
    //This is the interface that the client interacts with.
    public interface ITarget
    {
        void Request(int id);
    }
}
