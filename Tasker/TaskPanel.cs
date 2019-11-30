using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Tasker
{
    abstract class TaskPanel:Panel
    {
        abstract public string GetMessage();
        abstract public string GetTitle();
        

    }
}
