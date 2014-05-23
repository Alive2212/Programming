using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class RFT230
{

    string oldsn;

    public void	RFT230_INIT()
	{
        Warranty1.API.MF_InitComm("USB", 9600);
    }

    private void rft230_GetID()
    {

        string Temp = "";
        int a = Warranty1.API.MF_Anticoll(0, ref Warranty1.Mifare.cardSN[0]);
        
        Warranty1.API.MF_Request(0, 0, ref Warranty1.Mifare.cardT[0]);
        for (int i = 0; i <= 2; i++)
        {
            Temp += Convert.ToString(Warranty1.Mifare.cardT[i]);
        }

        string x = "";
        for (int i = 0; i < 4; i++)
        {
            x += string.Format("{0:X}", Warranty1.Mifare.cardSN[i]);
        }

        textBox1.Text = x;

        if (a == 0)
        {
            if (oldsn != x)
            {
                oldsn = x;
            }
        }
    }
}
   

