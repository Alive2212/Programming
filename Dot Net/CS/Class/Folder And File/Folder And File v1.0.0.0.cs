using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

class FolderAndFile
{
    public string ApplicationName = "aApp";
    public static string DocumentAddress = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    public string aDev_TempAddress = DocumentAddress + "\\Alive Co\\";

    public void WriteLineTextFile_aDev(string FileName, string Line)
    {
        if (FileName.Substring(FileName.Length - 4) == ".txt")
        {
            if (File.Exists(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName) == true)
            {
                System.IO.StreamWriter file =
                       new System.IO.StreamWriter(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName);
                file.WriteLine(Line);
                file.Close();
            }
        }
        else
        {
            if (File.Exists(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName + ".txt") == true)
            {
                System.IO.StreamWriter file =
                       new System.IO.StreamWriter(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName + ".txt");
                file.WriteLine(Line);
                file.Close();
            }
        }
    }

    public string ReadLineTextFile_aDev(string FileName)
    {
        string StringTemp = "";
        if (FileName.Substring(FileName.Length - 4) == ".txt")
        {
            if (File.Exists(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName) == true)
            {
                System.IO.StreamReader file =
                       new System.IO.StreamReader(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName);
                StringTemp = file.ReadLine();
                file.Close();
            }
        }
        else
        {
            if (File.Exists(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName + ".txt") == true)
            {
                System.IO.StreamReader file =
                       new System.IO.StreamReader(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName + ".txt");
                StringTemp = file.ReadLine();
                file.Close();
            }
        }
        if (StringTemp == "") StringTemp = "0";
        return StringTemp;
    }

    public void CreatTextFile_aDev(string FileName)
    {
        if (FileName.Substring(FileName.Length - 4) == ".txt")
        {
            if (File.Exists(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName) == false)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName);
                file.Close();
            }
        }
        else
        {
            if (File.Exists(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName + ".txt") == false)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName + ".txt");
                file.Close();
            }
        }
    }

    public void CreatFolder_aDev()
    {
        if (Directory.Exists(aDev_TempAddress + ApplicationName + "\\Temp") == false) Directory.CreateDirectory(aDev_TempAddress + ApplicationName + "\\Temp");
    }

    /// <summary>
    /// Save information on Data list to Text file who name is "FileName" in Alive Co. Directory 
    /// </summary>
    /// <param name="sender">object sending the event</param>
    /// <param name="e">event arguments</param>
    public void SaveInformation_aDev(string FileName, List<string> Data)
    {
        for (int i = Data.Count; i > 0; i--) this.WriteLineTextFile_aDev(FileName, Data[i]);
    }

}


