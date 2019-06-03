using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazerBypasser
{
    public class Device
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public List<Profile> Profiles = new List<Profile>();
        public Profile Profile { get; set; }
    }
}
