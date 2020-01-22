using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon
{

    enum VMSTATE
    {
        START,
        RUNNING,
        QUIT
    }

    class VM
    {
        public VMSTATE state { get; set; }
        string code;

        public VM(string code)
        {
            this.code = code;
        }

        public int start()
        {
            this.state = VMSTATE.START;

            // Load Instructions

            return 0;
        }

        public void run()
        {
            this.state = VMSTATE.RUNNING;
        }

        public void stop()
        {
            this.state = VMSTATE.QUIT;
        }

    }
}
