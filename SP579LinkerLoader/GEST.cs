using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SP579LinkerLoader
{
    public struct GESTrow
    {
        public string symbol, relativeAddress, loadAddress;
        public int length;
        
    }

    public class GEST
    {
        Form1 form;
        public GEST(Form1 form)
        { 
            this.form = form;
            GESTlist = new List<GESTrow>();
        
        }

        public List<GESTrow> GESTlist{ get; private set; }

        public void AddToGESTlist(string symbol, string relativeAddress, string loadAddress,int length)
        {
            GESTrow G;
            G.symbol = symbol;
            G.relativeAddress = relativeAddress;
            G.loadAddress = loadAddress;
            G.length = length;

            GESTlist.Add(G);
        }

        public void Generate(Program1 prog1, Program1 prog2, string loadAddress)
        {
            string temp;
            string[] tempList;
            int ra;
            int fpl;
            GESTrow tempG;

            temp = prog1.rawLineOfCode.First();
            tempList = temp.Split(new char[] { ',', '_', '/', ' ' }, StringSplitOptions.RemoveEmptyEntries);


            //First ORG in Program1
            tempG.symbol = tempList[2];
            tempG.relativeAddress = "0000";
            ra = HelperClass.ConvertHexToDecimalAddress(tempList[3]);
            tempG.loadAddress = loadAddress;
            fpl = tempG.length = HelperClass.ConvertHexToDecimalAddress(tempList[1]);

            GESTlist.Add(tempG);
            form.lvGEST.Items.Add(new System.Windows.Forms.ListViewItem(new string[] { tempG.symbol, tempG.relativeAddress, tempG.loadAddress, tempG.length.ToString("X4") }));

            for (int i = 4; i < tempList.Length; i += 2)
            {
                tempG.symbol = tempList[i];
                tempG.relativeAddress = (HelperClass.ConvertHexToDecimalAddress(tempList[i + 1]) - ra).ToString("X4");
                tempG.loadAddress = loadAddress;
                tempG.length = 0;

                GESTlist.Add(tempG);
                form.lvGEST.Items.Add(new System.Windows.Forms.ListViewItem(new string[] { tempG.symbol, tempG.relativeAddress, tempG.loadAddress, tempG.length == 0 ? "" : tempG.length.ToString("X4") }));
            }


            //end of Program 1

            //First ORG for Program 2
            temp = prog2.rawLineOfCode.First();
            tempList = temp.Split(new char[] { ',', '_', '/', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            tempG.symbol = tempList[2];
            tempG.relativeAddress = "0000";
            ra = HelperClass.ConvertHexToDecimalAddress(tempList[3]);
            tempG.loadAddress = (HelperClass.ConvertHexToDecimalAddress(loadAddress) + fpl).ToString("X4");
            loadAddress = tempG.loadAddress;
            tempG.length = HelperClass.ConvertHexToDecimalAddress(tempList[1]);

            GESTlist.Add(tempG);
            form.lvGEST.Items.Add(new System.Windows.Forms.ListViewItem(new string[] { tempG.symbol, tempG.relativeAddress, tempG.loadAddress, tempG.length.ToString("X4") }));

            for (int i = 4; i < tempList.Length; i += 2)
            {
                tempG.symbol = tempList[i];
                tempG.relativeAddress = (HelperClass.ConvertHexToDecimalAddress(tempList[i + 1]) - ra).ToString("X4");
                tempG.loadAddress = loadAddress;
                tempG.length = 0;

                GESTlist.Add(tempG);
                form.lvGEST.Items.Add(new System.Windows.Forms.ListViewItem(new string[] { tempG.symbol, tempG.relativeAddress, tempG.loadAddress, tempG.length == 0 ? "" : tempG.length.ToString("X4") }));
            }
                


        }
          
    }
}
