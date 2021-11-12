//1.	Install the latest IronPython (Currently 3.4.1)
//2.    Add Iropython.dll & Microsoft.Scripting.dll reference
//3. 	Install-Package DynamicLanguageRuntime using NuGet

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using IronPython.Runtime;
using IronPython;
using Microsoft.Scripting.Hosting;

namespace Integrate_Python_into_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            
            ScriptEngine PythinScript = Python.CreateEngine(); //Create an instance of the IronPython scripting engine
            dynamic PythinScriptscope = PythinScript.CreateScope(); //Create a ScriptScope or ScriptSource and store it as a dynamic variable.

            //creating a dynamic variable of the script scope allows execution or manipulation of the scopes from C#
            PythinScriptscope.Add = new Func<int, int, int>((x, y) => x + y);
            txtOutput.Text =Convert.ToString((PythinScriptscope.Add(2, 3))); //show the script scope ouotput
            
            //var ipy = Python.CreateRuntime(); //set var
        }
    }
}
