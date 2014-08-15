/**
 * Created with IntelliJ IDEA.
 * User: Babak
 * Date: 8/9/14
 * Time: 11:18 PM
 * To change this template use File | Settings | File Templates.
 */

import java.io.*;
import java.util.*;

public class NS_FarsNews extends javasandbox.NetSpider {

    public static String NewsPrefixAddress="http://farsnews.com/newstext.php?nn=";
    public static String NewsExtensionAddress="";

    public static String NewsCodesDelims = "newstext\\.php\\?nn=";

    public static String NewsCenterCodesDelims = "<div class=\"centercolumn\">";
    public static String NewsLeftCodesDelims = "<div class=\"leftcolumn\">";

    //__________ Address of Pages that has title of all news
    public static String FirstPageAddress = "http://farsnews.com/";
    public static String TotalNewsPageAddress = "http://farsnews.com/newsv.php?title=1";
    public static String TopNewsPageAddress = "http://farsnews.com/topnews.php";
    public static String SportNewsPageAddress = "http://farsnews.com/newsv.php?srv=4&title=1";


    public static List<Long> getCenterNewsLinksCodes(String PageAddress) throws IOException {
        List<Long> LinksCodes = new ArrayList();
        String[] TokensTemp1 = getUrlSource(PageAddress).split(NewsCenterCodesDelims);// Get Center News to End Source
        String[] TokensTemp2;

        if(TokensTemp1.length>1)
            TokensTemp2 = TokensTemp1[1].split(NewsLeftCodesDelims);// Get Center News Source
        else
            TokensTemp2 = TokensTemp1[0].split(NewsLeftCodesDelims);// Get Center News Source

        String[] TokensTemp3 = TokensTemp2[0].split(NewsCodesDelims);// Get Center News Codes to End

        for (int i = 1; i < TokensTemp3.length; i++){
            if(((TokensTemp3[i].length()>14)) && (TokensTemp3[i].substring(0, 14).equals(TokensTemp3[i-1].substring(0, 14)))){
                LinksCodes.add(Long.parseLong( TokensTemp3[i].substring(0, 14)));
            }
        }
        return  LinksCodes;
    }

}

