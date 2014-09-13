/**
 * Created with IntelliJ IDEA.
 * User: Babak
 * Date: 8/9/14
 * Time: 11:18 PM
 * To change this template use File | Settings | File Templates.
 */

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class NS_Temp extends javasandbox.NetSpider {

    public static String NewsPrefixAddress="";
    public static String NewsExtensionAddress="";

    public static String NewsCodesDelims = "";

    public static String NewsCenterCodesDelims = "";
    public static String NewsLeftCodesDelims = "";

    //__________ Address of Pages that has title of all news
    public static String FirstNewsPageAddress = "";


    public static List<String> getNewsLinksCodes(String PageAddress) throws IOException {
        List<String> LinksCodes = new ArrayList();
        String[] TokensTemp = getUrlSource(PageAddress).split(NewsCodesDelims);// Get Center News Codes to End

        for (int i = 1; i < TokensTemp.length; i++){
            LinksCodes.add(TokensTemp[i].substring(13, 25));
        }
        return  LinksCodes;
    }

}

