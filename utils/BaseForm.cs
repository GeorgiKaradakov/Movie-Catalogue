using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Database.utils
{
    public interface BaseForm
    {
        //void SetParentForm(Form f);
        Form ParentForm { get; set; }
    }
}
