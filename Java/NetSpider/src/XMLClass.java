/**
 * Created with IntelliJ IDEA.
 * User: Varzeshinews
 * Date: 10/11/14
 * Time: 4:57 PM
 * To change this template use File | Settings | File Templates.
 */

import com.thoughtworks.xstream.XStream;
import com.thoughtworks.xstream.io.xml.DomDriver;

import java.util.HashMap;

public class XMLClass {

    private XStream xstream = new XStream(new DomDriver());

    private FolderAndFileClass FFObject = new FolderAndFileClass();

    public void SaveMap(String Address,HashMap HashMap){
        this.FFObject.WriteFile(Address,this.xstream.toXML(HashMap));
    }
    public HashMap LoadMap(String Address){
        String TempText= this.FFObject.ReadFile(Address);
        HashMap OutputMap = (HashMap) xstream.fromXML(TempText);

        return OutputMap;
    }

}
