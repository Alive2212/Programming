using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RFT230
{

    public class Base
    {
        public static string oldsn;

        public static void RFT230_INIT()
        {
            RFT230.API.MF_InitComm("USB", 9600);
        }

        public static bool IsRFT230Connect()
        {
            bool Temp = true;
            if (RFT230.API.MF_Anticoll(0, ref RFID.Mifare.cardSN[0]) == 33)
            {
                Temp = false;
            }
            return Temp;
        }
        public static string rft230_GetID()
        {
            string Temp = "";
            string x = "N/A";

            if (IsRFT230Connect())
            {
                x = "";
                int a = RFT230.API.MF_Anticoll(0, ref RFID.Mifare.cardSN[0]);
                RFT230.API.MF_Request(0, 0, ref RFID.Mifare.cardT[0]);
                for (int i = 0; i <= 2; i++)
                {
                    Temp += Convert.ToString(RFID.Mifare.cardT[i]);
                }

                for (int i = 0; i < 4; i++)
                {
                    x += string.Format("{0:X}", RFID.Mifare.cardSN[i]);
                }
                for (int j = 0; j < RFID.Mifare.cardSN.Length; j++)
                    RFID.Mifare.cardSN[j] = 0;

                if (a == 0)
                {
                    if (oldsn != x)
                    {
                        oldsn = x;
                    }
                }
            }
            return x;
        }
    }
}


