using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MTMover
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); //Activates some visual affects that can be used for buttons as example: http://stackoverflow.com/questions/6764100/does-application-enablevisualstyles-do-anything
            Application.SetCompatibleTextRenderingDefault(false); //Rendering the text visualy better and support for localisation:http://stackoverflow.com/questions/2341728/application-setcompatibletextrenderingdefaultfalse  
            Application.Run(new Form1());
            
            //Begin of my code

            //Begin: scan the folder with downloaded files
            //http://www.dotnetperls.com/path
            string locationfilepath = @"H:\Chrom Downloads\C#\For testing\locationfile";
            string[] listofallfiles= Directory.GetFiles (locationfilepath, ".", SearchOption.AllDirectories); // First argument: Path; Second: Filter; Third: Directory level
            string tempvariable = string.Join(Environment.NewLine, listofallfiles ); // Changes a string array into regular string with seperator (in this caase new line)
            MessageBox.Show (tempvariable); // Shows the output as user message







            
        }
    }
}
