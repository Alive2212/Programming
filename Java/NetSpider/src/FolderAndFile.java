import java.io.*;

public class FolderAndFile {
    public static void WriteToTextFile(String Address,String Text){
        try{
            BufferedWriter bw = new BufferedWriter(new FileWriter(Address));
            bw.write(Text);
            bw.close();
        }
        catch(Exception e){}
    } //main
}