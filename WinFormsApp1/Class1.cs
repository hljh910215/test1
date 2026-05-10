using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace WinFormsApp1
{
    public interface ISmartControl
    {
        string GetValue();
    }
    public class WATextBox : TextBox , ISmartControl
    {
        public string GetValue()
        {
            return this.Text;
        }
    }
    public class WACheckBox : CheckBox, ISmartControl
    {
        public string GetValue()
        {
            return this.Checked ? "1":"0";
        }
    }
}
