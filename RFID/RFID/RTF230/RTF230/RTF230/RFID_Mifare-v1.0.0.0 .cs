using System;
using System.Collections.Generic;
using System.Text;

namespace RFID
{
    class Mifare
    {
        public static Byte[] DLL_version = new Byte[32];
        public static Byte[] portN = new Byte[4];
        public static Byte[] Dver = new Byte[32];
        public static Byte Daddress = new Byte();
        public static Byte[] Dsn = new Byte[7];
        public static Byte[] cardT = new Byte[3];
        public static Byte[] cardSN = new Byte[5];
        public static Byte[] Ckey = new Byte[6];
        public static Byte[] databuffer = new Byte[16];
        public static Byte[] value = new Byte[3];
        public static Byte[] Dbuffer = new Byte[48];
        public static int hex2dec(string inpt)
        {
            //On Error Resume Next
            if (inpt.Length == 1)
            {
                inpt = "0" + inpt;
            }
            int temp = 0;
            switch (inpt.Substring(1, 1))
            {
                case "A": temp = temp + 10 * 16; break;
                case "a": temp = temp + 10 * 16; break;
                case "B": temp = temp + 11 * 16; break;
                case "b": temp = temp + 11 * 16; break;
                case "C": temp = temp + 12 * 16; break;
                case "c": temp = temp + 12 * 16; break;
                case "D": temp = temp + 13 * 16; break;
                case "d": temp = temp + 13 * 16; break;
                case "E": temp = temp + 14 * 16; break;
                case "e": temp = temp + 14 * 16; break;
                case "F": temp = temp + 15 * 16; break;
                case "f": temp = temp + 15 * 16; break;
                default: temp = temp + int.Parse((inpt.Substring(1, 1))) * 16; break;
            }

            switch (inpt.Substring(2, 1))
            {
                case "A": temp = temp + 10; break;
                case "a": temp = temp + 10; break;
                case "B": temp = temp + 11; break;
                case "b": temp = temp + 11; break;
                case "C": temp = temp + 12; break;
                case "c": temp = temp + 12; break;
                case "D": temp = temp + 13; break;
                case "d": temp = temp + 13; break;
                case "E": temp = temp + 14; break;
                case "e": temp = temp + 14; break;
                case "F": temp = temp + 15; break;
                case "f": temp = temp + 15; break;
                default: temp = temp + int.Parse((inpt.Substring(2, 1))); break;
            }
            return temp;
        }
    }
}
