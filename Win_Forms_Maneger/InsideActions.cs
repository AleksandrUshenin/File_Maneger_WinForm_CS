using Library_File_Maneger.User_Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Forms_Maneger
{
    internal class InsideActions
    {
        UserCommandInfo command;

        internal int PressKeyCommand(int key)
        {
            switch (key)
            {
                case 116://копировать 
                    return 1;
                case 117://созать 
                    return 2;
                case 119://удолить
                    return 3;
            }
            return 0;
        }
        private void DoKeyCommand() { }
    }
}
