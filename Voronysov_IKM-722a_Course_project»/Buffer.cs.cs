using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voronysov_IKM_722a_Course_project_
{
    [Serializable]
    internal class Buffer
    {
        public string Data { get; internal set; }
        public string Result { get; internal set; }
        public int Key { get; internal set; }
    }
}
