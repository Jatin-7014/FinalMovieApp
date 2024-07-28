using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Exceptions
{
    public class MemorySpaceFullException:Exception
    {
        public MemorySpaceFullException(string message):base(message)
        { 
        
        }
    }
}
