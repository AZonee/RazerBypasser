using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazerBypasser
{
    class Key
    {
        public int Scancode { get; set; }
        public int VirtualKey { get; set; }

        public static Key GetKey(string key)
        {
            //
            // THIS IS A HORRRRRIBLE WAY TO DO THIS.
            // NEVER DO THIS.
            // IT SUCKS.
            // IM DOING IT BECAUSE IM AN IDIOT AND DONT WANT TO DO IT THE RIGHT WAY.
            // ILL MAKE IT ACTUALLY GOOD ONCE I FINISH SOME OTHER PARTS OF THE PROGRAM.
            //
            switch (key.ToLower())
            {
                case "f13":
                    return new Key { Scancode = 100, VirtualKey = 124 };
                case "f14":
                    return new Key { Scancode = 101, VirtualKey = 125 };
                case "f15":
                    return new Key { Scancode = 102, VirtualKey = 126 };
                case "f16":
                    return new Key { Scancode = 103, VirtualKey = 127 };
                case "f17":
                    return new Key { Scancode = 104, VirtualKey = 128 };
                case "f18":
                    return new Key { Scancode = 105, VirtualKey = 129 };
                case "f19":
                    return new Key { Scancode = 106, VirtualKey = 130 };
                case "f20":
                    return new Key { Scancode = 107, VirtualKey = 131 };
                case "f21":
                    return new Key { Scancode = 108, VirtualKey = 132 };
                case "f22":
                    return new Key { Scancode = 109, VirtualKey = 133 };
                case "f23":
                    return new Key { Scancode = 110, VirtualKey = 134 };
                case "f24":
                    return new Key { Scancode = 118, VirtualKey = 135 }; // Because screw patterns.
                default:
                    return null;
            }
        }
    }
}
