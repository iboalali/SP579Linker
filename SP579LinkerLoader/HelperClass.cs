using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SP579LinkerLoader
{
    class HelperClass
    {
        //This class contains general useful methods, such as methods for conversion from hex to decimal

        public static int ConvertHexToDecimalAddress(string numberToConvert)
        { 
            //numberToConvert should have the format XXXX, if it doesn't however it is padded with zeros to the left
            if (numberToConvert.Length < 4)
            {
                numberToConvert.PadLeft(4, '0');
            }

            return (int) (ConvertHexToDecimalCharacter(numberToConvert[0]) * Math.Pow(16, 3)
                + ConvertHexToDecimalCharacter(numberToConvert[1]) * Math.Pow(16,2)
                + ConvertHexToDecimalCharacter(numberToConvert[2]) * Math.Pow(16,1)
                + ConvertHexToDecimalCharacter(numberToConvert[3]) * Math.Pow(16, 0));
            
        }

        public static int ConvertHexToDecimalCharacter(char hexCharToConvert)
        {
            switch (hexCharToConvert)
            {
                case '0': 
                    { return 0;}
                case '1': 
                    {return 1;}
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5' :
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
                default:
                    throw new FormatException("Invalid hex character found");
                    

            }
        }

    }
}
