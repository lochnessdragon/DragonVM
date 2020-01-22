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
        int[] instructions;

        public VM(int[] instructions)
        {
            this.instructions = instructions;
        }

        public int start()
        {
            this.state = VMSTATE.START;

            // Load Instructions into memory

            return 0;
        }

        public void run()
        {
            // Run through instructions

            this.state = VMSTATE.RUNNING;
        }

        public void stop()
        {
            // End state unload mem
            this.state = VMSTATE.QUIT;
        }

    }
}
