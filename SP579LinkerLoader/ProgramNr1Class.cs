using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SP579LinkerLoader
{
    public class Program1
    {
        public bool isErrorFree = true;
        public Dictionary<int, string> listOfErrors = new Dictionary<int, string>(); //this dictionary store errors and a description.. Key: int Line number.. Value: string Error Text
        public List<string> rawLineOfCode = new List<string>();    //this list stores each line of code after removing all spaces to check for duplicates
        public Dictionary<int, string> codeLines = new Dictionary<int, string>();

        public void CheckForErrors()
        {
            string singleLine;
            int numberOfLines = codeLines.Count;

            #region Check if first record is not T record
            singleLine = rawLineOfCode.First();
            if (singleLine[0] != 'T')
            {
                listOfErrors.Add(1, "First Record Must Be of Type T");
                isErrorFree = false;
            }


            #endregion

            #region check if last record is not Y
            singleLine = rawLineOfCode.Last();
            if (singleLine[0] != 'Y')
            {
                isErrorFree = false;
                listOfErrors.Add(numberOfLines + 1, "Last record must be of type Y");
            }
            #endregion

            
                #region Check for any illegal record type
            for (int i = 2; i < numberOfLines - 1; i++ )
            {
                singleLine = "";
                //if (line[i] != 'N' || line[0] != 'Y' || line[0] != 'T')
                {

                }
            }
                #endregion
            
        }

    }
}
