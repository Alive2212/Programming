extern "C" __declspec(dllexport) int _stdcall MF_GetDLL_Ver(char *VER);
extern "C" __declspec(dllexport) int _stdcall MF_InitComm(char *portname, long baud);//打开与读写器相联的端口
extern "C" __declspec(dllexport) int _stdcall MF_ExitComm();         //关闭与读写器相联的端口

extern "C" __declspec(dllexport) int _stdcall MF_SetRecvTimeout(unsigned int timeout);
extern "C" __declspec(dllexport) int _stdcall MF_GeneralCMD(int DeviceAddr, unsigned char *cData, unsigned char cLen, unsigned char *rData, unsigned char *rLen);

extern "C" __declspec(dllexport) int _stdcall MF_GetDevice_Ver(int DeviceAddr, char *ver);
extern "C" __declspec(dllexport) int _stdcall MF_ControlLED(int DeviceAddr, unsigned char LED1, unsigned char LED2);
extern "C" __declspec(dllexport) int _stdcall MF_ControlBuzzer(int DeviceAddr, unsigned char BeepTime);
extern "C" __declspec(dllexport) int _stdcall MF_SetDeviceBaud(int DeviceAddr, unsigned char baud);
extern "C" __declspec(dllexport) int _stdcall MF_SetDeviceAddr(int DeviceAddr, unsigned char addr);
extern "C" __declspec(dllexport) int _stdcall MF_GetDeviceAddr(int DeviceAddr, unsigned char *addr);		//!!!
extern "C" __declspec(dllexport) int _stdcall MF_SetDeviceSNR(int DeviceAddr, unsigned char *SNR);
extern "C" __declspec(dllexport) int _stdcall MF_GetDeviceSNR(int DeviceAddr, unsigned char *SNR);		// !!!
extern "C" __declspec(dllexport) int _stdcall MF_SetRF_ON(int DeviceAddr);
extern "C" __declspec(dllexport) int _stdcall MF_SetRF_OFF(int DeviceAddr);
extern "C" __declspec(dllexport) int _stdcall MF_DeviceReset(int DeviceAddr);
extern "C" __declspec(dllexport) int _stdcall MF_SetWiegandMode(int DeviceAddr, unsigned char mode, unsigned char alarm);

// mode=0: request all, mode=1: request idle   return: cardtype (2bytes);
extern "C" __declspec(dllexport) int _stdcall MF_Request(int DeviceAddr, unsigned char mode, unsigned char *CardType);
// return: snr (4 bytes)
extern "C" __declspec(dllexport) int _stdcall MF_Anticoll(int DeviceAddr, unsigned char *snr);
// input: snr(4 bytes)
extern "C" __declspec(dllexport) int _stdcall MF_Select(int DeviceAddr, unsigned char *snr);
extern "C" __declspec(dllexport) int _stdcall MF_Halt(int DeviceAddr);
// input: key (6 bytes)
extern "C" __declspec(dllexport) int _stdcall MF_LoadKey(int DeviceAddr, unsigned char *key);
// KeyType: 0=KeyA, 1=KeyB 	KeyNum: 0~15
extern "C" __declspec(dllexport) int _stdcall MF_LoadKeyFromEE(int DeviceAddr, unsigned char KeyType, unsigned char KeyNum);
// AuthType: 0=KeyA, 1=KeyB;
extern "C" __declspec(dllexport) int _stdcall MF_Authentication(int DeviceAddr, unsigned char AuthType, unsigned char block, unsigned char *snr);
extern "C" __declspec(dllexport) int _stdcall MF_Read(int DeviceAddr, unsigned char block, unsigned char numbers, unsigned char *databuff);
extern "C" __declspec(dllexport) int _stdcall MF_Write(int DeviceAddr, unsigned char block, unsigned char numbers, unsigned char *databuff);
// ValOption:0=dec, 1=inc, 2=restore;  block:0~15;  value (4 byte)
extern "C" __declspec(dllexport) int _stdcall MF_Value(int DeviceAddr, unsigned char ValOption, unsigned char block, unsigned char *value);
// block:0~15;
extern "C" __declspec(dllexport) int _stdcall MF_Transfer(int DeviceAddr, unsigned char block);
// KeyAB: 0=KeyA,1=KeyB; KeyAddr:0~15; key(6 bytes);
extern "C" __declspec(dllexport) int _stdcall MF_StoreKeyToEE(int DeviceAddr, unsigned char KeyAB, unsigned char KeyAddr, unsigned char *key);


extern "C" __declspec(dllexport) int _stdcall MF_General_ISO14443A(int DeviceAddr, unsigned char enable_crc, unsigned char *cData, unsigned char cLen, unsigned char *rData, unsigned char *rLen);
extern "C" __declspec(dllexport) int _stdcall MF_General_ISO14443B(int DeviceAddr, unsigned char *cData, unsigned char cLen, unsigned char *rData, unsigned char *rLen);
extern "C" __declspec(dllexport) int _stdcall MF_General_ISO15693(int DeviceAddr, unsigned char *cData, unsigned char cLen, unsigned char *rData, unsigned char *rLen);
extern "C" __declspec(dllexport) int __stdcall  MF_ISO15693_Inventory(int DeviceAddr,unsigned char flags, unsigned char AFI,unsigned char masklengh ,unsigned char *maskvalue,unsigned char*databuffer);


#define PICC_AUTHENT1A     0x60         //!< authentication using key A
#define PICC_AUTHENT1B     0x61         //!< authentication using key B

// error code define
#define MI_OK				0x00
#define MI_NOTAGERR			0x01
#define MI_COLLERR			0x02
#define MI_BITERR			0x03
#define MI_SAKERR			0x04
#define MI_AUTHERR			0x05
#define MI_Value			0x0D
#define MI_ACCESSERR 		0x0E
#define MI_ACCESSTIMEOUT	0x0F

#define MI_CommandErr		0x10
#define MI_OtherErr			0x11

#define Code_RetFrameErr    0x20
#define Code_TimeoutErr     0x21
#define Code_SetCommPortErr 0x22

