using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace RFT230
{
    class API
    {        
        [DllImport("MF_API.dll")]
        public static extern short MF_GetDLL_Ver(ref Byte rVER);
        [DllImport("MF_API.dll")]
        public static extern int MF_InitComm(String portname, int baud);
        //public static extern int MF_ControlBuzzer Lib "MF_API.dll" (ByVal DeviceAddr As short, ByRef BeepTime As short) As Integer
        //public static extern int MF_DeviceReset Lib "MF_API.dll" (ByVal DeviceAddr As short) As Integer
        [DllImport("MF_API.dll")]
        public static extern int MF_ExitComm();
        //public static extern short MF_GetDevice_Ver Lib "MF_API.dll" (ByVal DeviceAddr As short, ByRef ver As Byte) As Integer
        //public static extern short MF_SetDeviceBaud Lib "MF_API.dll" (ByVal DeviceAddr As short, ByVal baud As Integer) As Integer
        //public static extern short MF_SetDeviceAddr Lib "MF_API.dll" (ByVal DeviceAddr As short, ByVal addr As short) As Integer
        //public static extern short MF_ControlLED Lib "MF_API.dll" (ByVal DeviceAddr As short, ByVal LED1 As short, ByVal LED2 As short) As Integer
        //public static extern short MF_GetDeviceAddr Lib "MF_API.dll" (ByVal DeviceAddr As short, ByRef addr As Byte) As Integer
        //public static extern short MF_SetDeviceSNR Lib "MF_API.dll" (ByVal DeviceAddr As short, ByVal snr As String) As Integer
        //public static extern short MF_GetDeviceSNR Lib "MF_API.dll" (ByVal DeviceAddr As short, ByRef snr As Byte) As Integer
        //public static extern short MF_SetRF_ON Lib "MF_API.dll" (ByVal DeviceAddr As short) As Integer
        //public static extern short MF_SetRF_OFF Lib "MF_API.dll" (ByVal DeviceAddr As short) As Integer
        //public static extern short MF_SetWiegandMode Lib "MF_API.dll" (ByVal DeviceAddr As short, ByVal mode As short, ByVal alarm As short) As Integer
        //
        //'''''''''''''''''''''''''''''''''''card reading functions''''''''''''''''''''''''''''''''''''''''''
        [DllImport("MF_API.dll")]
        public static extern int MF_Request(short DeviceAddr, short mode, ref Byte CardType);
        [DllImport("MF_API.dll")]
        public static extern int MF_Anticoll(short DeviceAddr, ref Byte snr);
        //public static extern short MF_Halt Lib "MF_API.dll" (ByVal DeviceAddr As short);
        [DllImport("MF_API.dll")]
        public static extern int MF_Select(short DeviceAddr, ref Byte snr);
        [DllImport("MF_API.dll")]
        public static extern int MF_LoadKey(short DeviceAddr, ref Byte key);
        [DllImport("MF_API.dll")]
        public static extern int MF_LoadKeyFromEE(short DeviceAddr, short KeyType, short KeyNum);
        //public static extern int MF_StoreKeyToEE Lib "MF_API.dll" (ByVal DeviceAddr As short, ByVal KeyAB As short, ByVal KeyAdd As short, ByRef key As Byte);
        [DllImport("MF_API.dll")]
        public static extern int MF_Authentication(short DeviceAddr, short AuthType, short block, ref Byte snr);
        [DllImport("MF_API.dll")]
        public static extern int MF_Read(short DeviceAddr, short block, short numbers, ref Byte databuff);
        [DllImport("MF_API.dll")]
        public static extern int MF_Write(short DeviceAddr, short block, short numbers, ref Byte databuff);
        [DllImport("MF_API.dll")]
        public static extern int MF_Value(short DeviceAddr, short valoption, ref Byte value);
        [DllImport("MF_API.dll")]
        public static extern int MF_transfer(short DeviceAddr, short block);
        [DllImport("MF_API.dll")]
        public static extern int MF_ControlBuzzer(short DeviceAddr, short BeepTime);

    }
}
