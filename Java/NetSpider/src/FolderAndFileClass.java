import java.io.*;

public class FolderAndFileClass {

    public static void WriteFile(String Address,String Text){
        try{
            BufferedWriter bw = new BufferedWriter(new FileWriter(Address));
            bw.write(Text);
            bw.close();
        }
        catch(Exception e){}
    } //main
    public static String ReadFile(String Address){
        String OutputText=new String();
        String TempText=new String();
        try{
            BufferedReader br = new BufferedReader(new FileReader(Address));
            while ((TempText = br.readLine()) != null) {
                OutputText += TempText;
            }
        }
        catch(Exception e){}
        return OutputText;
    } //main

}