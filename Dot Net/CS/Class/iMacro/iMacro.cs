using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class iMacro
{

    private static string iMacro_SaveAddress = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\iMacros\\Macros";

    public List<string> iMacro_VarzeshiNewsCreateTextCreator(int KindofNews_Index, int FeildofNews_Index, string Header_Content, string Lead_Content, string Main_Content, string Reference_Content, string Image_Addres)
    {
        List<string> Temp_01 = new List<string>();
        string Temp_02 = "ايجاد<SP>";

        Temp_01.Add("VERSION BUILD=8300326 RECORDER=FX");
        Temp_01.Add("TAB T=1");
        Temp_01.Add("URL GOTO=http://varzeshinews.ir/publish/main.php?mod=news");

        switch (KindofNews_Index)
        {
            case 1://خبر
                //                    Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_type CONTENT=%1-خبر");
                Temp_02 += "خبر<SP>در<SP>بخش<SP>";
                break;
            case 2://مقاله
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_type CONTENT=%2-مقاله");
                Temp_02 += "مقاله<SP>در<SP>بخش<SP>";
                break;
            case 3://یادداشت
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_type CONTENT=%6-يادداشت");
                Temp_02 += "يادداشت<SP>در<SP>بخش<SP>";
                break;
            case 4://گزارش
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_type CONTENT=%3-گزارش");
                Temp_02 += "گزارش<SP>در<SP>بخش<SP>";
                break;
            case 5://گفتگو
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_type CONTENT=%4-گفتگو");
                Temp_02 += "گفتگو<SP>در<SP>بخش<SP>";
                break;
            case 6://گزارش تصویری
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_type CONTENT=%5-گزارش<SP>تصويری");
                Temp_02 += "گزارش<SP>تصويری<SP>در<SP>بخش<SP>";
                break;
            case 7://فیلم
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_type CONTENT=%7-فیلم");
                Temp_02 += "فیلم<SP>در<SP>بخش<SP>";
                break;
        }

        switch (FeildofNews_Index)
        {
            case 1://فوتبال
                //                    Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_section CONTENT=%1-فوتبال-fa-فارسی");
                Temp_02 += "فوتبال";
                break;
            case 2://جودو
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_section CONTENT=%8-جودو-fa-فارسی");
                Temp_02 += "جودو";
                break;
            case 3://کشتی و ورزش های پهلوانی
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_section CONTENT=%10-کشتی<SP>و<SP>ورزش<SP>های<SP>پهلوانی-fa-فارسی");
                Temp_02 += "کشتی<SP>و<SP>ورزش<SP>های<SP>پهلوانی";
                break;
            case 4://جانبازات و معلولان
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_section CONTENT=%11-جانبازان<SP>و<SP>معلولان-fa-فارسی");
                Temp_02 += "جانبازان<SP>و<SP>معلولان";
                break;
            case 5://ورزش های رزمی
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=ACTION:?mod=news&action=create ATTR=NAME:create_section CONTENT=%12-ورزش<SP>های<SP>رزمی-fa-فارسی");
                Temp_02 += "ورزش<SP>های<SP>رزمی";
                break;
            case 6:
                Temp_01.Add("");
                Temp_02 += "";
                break;
            case 7:
                Temp_01.Add("");
                Temp_02 += "";
                break;
            case 8:
                Temp_01.Add("");
                Temp_02 += "";
                break;
            case 9:
                Temp_01.Add("");
                Temp_02 += "";
                break;
            case 10:
                Temp_01.Add("");
                Temp_02 += "";
                break;
            case 11:
                Temp_01.Add("");
                Temp_02 += "";
                break;
            case 12:
                Temp_01.Add("");
                Temp_02 += "";
                break;
            case 999://نا معلوم
                Temp_02 += "فوتبال";
                break;
        }
        Temp_01.Add("TAG POS=1 TYPE=BUTTON ATTR=TXT:" + Temp_02);//ساخت کار کاربرگ

        Temp_01.Add("TAG POS=1 TYPE=INPUT:TEXT FORM=NAME:newsForm ATTR=NAME:title CONTENT=" + iMacro_ContentAdaptor(Header_Content));
        Temp_01.Add("TAG POS=1 TYPE=TEXTAREA FORM=NAME:newsForm ATTR=NAME:lead CONTENT=" + iMacro_ContentAdaptor(Lead_Content));
        Temp_01.Add("TAG POS=1 TYPE=TEXTAREA FORM=NAME:newsForm ATTR=NAME:abstract CONTENT=" + iMacro_ContentAdaptor(Lead_Content));

        Temp_01.Add("FRAME F=1");
        Temp_01.Add("TAG POS=3 TYPE=IMG ATTR=SRC:http://varzeshinews.ir/publish/script/FCKeditor/editor/images/spacer.gif");
        Temp_01.Add("TAG POS=1 TYPE=TEXTAREA ATTR=* CONTENT=" + iMacro_ContentAdaptor(Main_Content));
        Temp_01.Add("TAG POS=3 TYPE=IMG ATTR=SRC:http://varzeshinews.ir/publish/script/FCKeditor/editor/images/spacer.gif");
        Temp_01.Add("FRAME F=0");

        Temp_01.Add("TAG POS=1 TYPE=DIV ATTR=TXT:مراجع");
        if (Main_Content.IndexOf("به نقل از") < 0)
        {
            Temp_01.Add("TAG POS=1 TYPE=INPUT:TEXT FORM=NAME:newsForm ATTR=NAME:source_name CONTENT=" + iMacro_ContentAdaptor(Reference_Content));
        }
        Temp_01.Add("TAG POS=1 TYPE=DIV ATTR=TXT:فايلها<SP>و<SP>تصاوير");
        Temp_01.Add("TAG POS=1 TYPE=INPUT:FILE FORM=NAME:newsForm ATTR=NAME:image_main_upload CONTENT=" + Image_Addres);

        Temp_01.Add("TAG POS=1 TYPE=DIV ATTR=TXT:چينش");
        Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=NAME:newsForm ATTR=NAME:main_featured_doc CONTENT=%16-50");
        switch (FeildofNews_Index )
        {
            case 1://فوتبال
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=NAME:newsForm ATTR=NAME:section_featured_doc CONTENT=%17-35");
                break;
            case 2://جودو
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=NAME:newsForm ATTR=NAME:section_featured_doc CONTENT=%17-30");
                break;
            case 3:
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=NAME:newsForm ATTR=NAME:section_featured_doc CONTENT=%17-30");
                break;
            case 4://جانبازان و معلولان
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=NAME:newsForm ATTR=NAME:section_featured_doc CONTENT=%17-30");
                break;
            case 5:
                Temp_01.Add("TAG POS=1 TYPE=SELECT FORM=NAME:newsForm ATTR=NAME:section_featured_doc CONTENT=%17-30");
                break;
        }
        Temp_01.Add("TAG POS=1 TYPE=DIV ATTR=TXT:عملیات<SP>نهائی");
        Temp_01.Add("TAG POS=1 TYPE=INPUT:RADIO FORM=NAME:newsForm ATTR=NAME:actions&&VALUE:6");
        Temp_01.Add("TAG POS=20 TYPE=SELECT FORM=NAME:newsForm ATTR=* CONTENT=%u_3");
        Temp_01.Add("ONDIALOG POS=1 BUTTON=OK CONTENT=");
        Temp_01.Add("TAG POS=1 TYPE=BUTTON ATTR=TXT:ارسال");
        Temp_01.Add("TAB T=1");
        Temp_01.Add("TAB CLOSE");


        return Temp_01;
    }

    public List<string> iMacro_VarzeshiNewsLoginTextCreator(string User,string Password)
    {
        List<string> Temp_01 =new List<string>();
        Temp_01.Add("VERSION BUILD=8300326 RECORDER=FX");
        Temp_01.Add("URL GOTO=http://varzeshinews.ir/publish/");
        Temp_01.Add("TAG POS=1 TYPE=INPUT:TEXT FORM=ACTION:login.php ATTR=NAME:user CONTENT=" + User);
        Temp_01.Add("SET !ENCRYPTION NO");
        Temp_01.Add("TAG POS=1 TYPE=INPUT:PASSWORD FORM=ACTION:login.php ATTR=NAME:pass CONTENT=" + Password);
        Temp_01.Add("TAG POS=1 TYPE=INPUT:SUBMIT FORM=ACTION:login.php ATTR=NAME:loginbutton&&VALUE:ورود");
        Temp_01.Add("TAB T=0");
        Temp_01.Add("TAB CLOSE");
        return Temp_01;
    }

    public string iMacro_ContentAdaptor(string Text)
    {
        string Temp_01 = "\"";
        Text = Text.Replace("\"", "'");
        Temp_01 += Text + "\"";

//        Text = Text.Replace(" ", "<SP>");
//        Text = Text.Replace(" ", "<SP>");
        Temp_01 = Temp_01.Replace("\n", "<BR>");
        Temp_01 = Temp_01.Replace("\r", "<BR>");
 
        return Temp_01;
    }

    public void iMacro_FileCreator(string FileName, List<string> Line)
    {
        int j;
        if (FileName.Substring(FileName.Length - 4) == ".iim")
        {
            if (File.Exists(iMacro_SaveAddress + "\\" + FileName) == true)
            {
                System.IO.StreamWriter file =
                    new System.IO.StreamWriter(iMacro_SaveAddress + "\\" + FileName);

                for (j = 0; j < Line.Count; j++)
                {
                    file.WriteLine(Line[j]);
                }

                //                    file.WriteLine(Line);
                file.Close();
            }
        }
        else
        {
            if (File.Exists(iMacro_SaveAddress + "\\" + FileName + ".iim") == true)
            {
                System.IO.StreamWriter file =
                       new System.IO.StreamWriter(iMacro_SaveAddress + "\\" + FileName + ".iim");

                for (j = 0; j < Line.Count; j++)
                {
                    file.WriteLine(Line[j]);
                }

                //                    file.WriteLine(Line);
                file.Close();
            }
        }
    }

    public void iMacro_Luncher(string FileName)
    {
        System.Diagnostics.Process proc = new System.Diagnostics.Process();
        proc.StartInfo.FileName = "C:/Program Files/Mozilla Firefox/firefox.exe";
        proc.StartInfo.Arguments = "iMacros://run/?m=" + FileName + ".iim";
        proc.Start();
        //proc.WaitForExit();
    }

    public void iMacro_CreatFile(string FileName)
    {
        if (FileName.Substring(FileName.Length - 4) == ".iim")
        {
            if (File.Exists(iMacro_SaveAddress + "\\" + FileName) == false)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(iMacro_SaveAddress + "\\" + FileName);
                file.Close();
            }
        }
        else
        {
            if (File.Exists(iMacro_SaveAddress + "\\" + FileName + ".iim") == false)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(iMacro_SaveAddress + "\\" + FileName + ".iim");
                file.Close();
            }
        }
    }
}
   

