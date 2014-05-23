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

    public void WriteLineTextFile_aDev(string FileName, string Line,bool Append)
    {
        if (FileName.Substring(FileName.Length - 4) == ".txt")
        {
            if (File.Exists(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName) == true)
            {
                System.IO.StreamWriter file =
                       new System.IO.StreamWriter(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName,Append);
                file.WriteLine(Line);
                file.Close();
            }
        }
        else
        {
            if (File.Exists(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName + ".txt") == true)
            {
                System.IO.StreamWriter file =
                       new System.IO.StreamWriter(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName + ".txt",Append);
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
    /// <param name="FileName">String file name who want to save</param>
    /// <param name="Data">Data with List Type who want to save</param>
    public void SaveInformation_aDev(string FileName, List<string> Data)
    {
        this.WriteLineTextFile_aDev(FileName, Data[0], false);
        //        for (int i = Data.Count - 1; i >= 0; i--) 
        for (int i = 1; i < Data.Count; i++) 
        this.WriteLineTextFile_aDev(FileName, Data[i], true);
    }

    /// <summary>
    /// Load information to Data list to Text file who name is "FileName" in Alive Co. Directory 
    /// </summary>
    /// <param name="FileName">String file name who want to save</param>
    public List<string> LoadInformation_aDev(string FileName)
    {
        List<string> Result = new List<String>();
        string Temp;

        if (FileName.Substring(FileName.Length - 4) == ".txt")
        {
            if (File.Exists(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName) == true)
            {
                System.IO.StreamReader file =
                       new System.IO.StreamReader(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName);

                while ((Temp = file.ReadLine()) != null)
                    Result.Add(Temp);

                file.Close();
            }
        }
        else
        {
            if (File.Exists(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName + ".txt") == true)
            {
                System.IO.StreamReader file =
                       new System.IO.StreamReader(aDev_TempAddress + ApplicationName + "\\Temp" + "\\" + FileName + ".txt");

                while ((Temp = file.ReadLine()) != null)
                    Result.Add(Temp);

                file.Close();
            }
        }


        if (Result.Count() == 0)
            Result = null;
        return Result;
    }

}


