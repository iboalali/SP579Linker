using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SP579LinkerLoader
{
    public partial class Form1 : Form
    {
        string fileName;
        private string path;
        Program1 prog1 = new Program1();
        Program1 prog2 = new Program1();
        GEST GESTtable;

        public Form1()
        {
            InitializeComponent();
            //lvGEST.Items.Add(new ListViewItem(new string[]{"1","2","3","4"}));
            //lvGEST.Show();
            GESTtable = new GEST(this);
        }

        private void btnLinkLoad_Click(object sender, EventArgs e)
        {
            #region Check For input Error
            try
            {
                if (txtStartAddress.Text == string.Empty)
                {
                    MessageBox.Show("You must specify the start address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtStartAddress.Text.Length < 4 || txtStartAddress.Text.Length > 4)
                {
                    MessageBox.Show("Starting address format is invalid, it should have the format \"XXXX\" only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (HelperClass.ConvertHexToDecimalAddress(txtStartAddress.Text) < 0 || (HelperClass.ConvertHexToDecimalAddress(txtStartAddress.Text) > 64511))
                {
                    MessageBox.Show("Starting address is in an invalid range, it should be in range 0x0000 - 0xFFBF only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GESTtable.Generate(prog1, prog2, txtStartAddress.Text);
                    MessageBox.Show("Success", "Sick!"); //set a boolean variable here to true to indicate that you can proceed with usage
                }
            }

            catch (FormatException exception)
            { MessageBox.Show(exception.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            #endregion

            if (prog1.isErrorFree && prog2.isErrorFree)
            {
                LinkAndLoad(prog1, prog2);
            }
            else
                MessageBox.Show("There was an error in the loaded programs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnErrorCheck_Click(object sender, EventArgs e)
        {
            prog1.CheckForErrors();
            prog2.CheckForErrors();

            
        }

        private void program1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile(txtProgram1, prog1);
        }

        private void openFile(TextBox txtbox, Program1 prog)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr;

            ofd.Filter = "Text File|*.txt|Any File|*.*";
            ofd.Multiselect = false;
            ofd.DereferenceLinks = true;
            ofd.Title = "Open File";
            if (path == string.Empty)
            {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            else
            {
                ofd.InitialDirectory = path;
            }

            dr = ofd.ShowDialog();
            StreamReader sr;


            if (dr == DialogResult.OK)
            {
                fileName = ofd.FileName;
                path = fileName.Substring(0, fileName.LastIndexOf('\\'));
                sr = new StreamReader(fileName);
                string temp;
                int lineNum = 1;
                while ((temp = sr.ReadLine()) != null)
                {
                    txtbox.Text += lineNum + "- " + temp;
                    prog.rawLineOfCode.Add(temp);
                    prog.codeLines.Add(lineNum++, temp);
                }
                sr.Close();
             }

            
            
        }

        private void program2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile(txtProgram2, prog2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }









#region Our Methods
        public void LinkAndLoad(Program1 firstProgram, Program1 secondProgram)
        {
            string finalResult = string.Empty; //here we iteratively store the resulting linked/loaded program

            string tempLineStorage = string.Empty; //here we store the line to modify it as we iterate over the code

            #region Getting the start address for the first record type-1
            tempLineStorage = firstProgram.rawLineOfCode.Last();
            tempLineStorage = tempLineStorage.TrimStart('Y', ' ');

            UInt16 startAddress = Convert.ToUInt16(tempLineStorage, 16);    //contains the start address to be placed in the object file, after relocation



            #endregion

            foreach (string currentLine in firstProgram.rawLineOfCode)
            {
                if (currentLine[0] == 'Y' || currentLine[0] == 'T')
                {
                    //do nothing
                }

                else 
                { 
                    
                }


            }


        
        }
#endregion
    }
}
