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

    public static String NewsCodesDelims = "newstext\\.php\\?nn=";

    public static String NewsCenterCodesDelims = "<div class=\"centercolumn\">";
    public static String NewsLeftCodesDelims = "<div class=\"leftcolumn\">";

    public static String FirstPageAddress = "http://farsnews.com/";
    public static String TotalAddress = "http://farsnews.com/newsv.php?title=1";
    public static String TopNewsAddress = "http://farsnews.com/topnews.php";


    public static List<Long> getFirstPageLinksCodes() throws IOException {
        List<Long> LinksCodes = new ArrayList();
        String[] tokensTemp = getUrlSource(FirstPageAddress).split(NewsCodesDelims);
        for (int i = 1; i < tokensTemp.length; i++){
            if(((tokensTemp[i].length()>14))&& (tokensTemp[i].substring(0, 14).equals(tokensTemp[i-1].substring(0, 14)))){
                //System.out.println(tokensTemp[i].substring(0, 14));
                LinksCodes.add(Long.parseLong( tokensTemp[i].substring(0, 14)));
            }
        }
        return  LinksCodes;
    }

    public static List<Long> getTotalLinksCodes() throws IOException {
        List<Long> LinksCodes = new ArrayList();
        String[] tokensTemp = getUrlSource(TotalAddress).split(NewsCodesDelims);
        for (int i = 1; i < tokensTemp.length; i++){
            if(((tokensTemp[i].length()>14)) && (tokensTemp[i].substring(0, 14).equals(tokensTemp[i-1].substring(0, 14)))){
                //System.out.println(tokensTemp[i].substring(0, 14));
                LinksCodes.add(Long.parseLong( tokensTemp[i].substring(0, 14)));

            }
        }
        return  LinksCodes;
    }

    public static List<Long> getTopNewsLinksCodes() throws IOException {
        List<Long> LinksCodes = new ArrayList();
        String[] tokensTemp = getUrlSource(TopNewsAddress).split(NewsCodesDelims);
        for (int i = 1; i < tokensTemp.length; i++){
            if(((tokensTemp[i].length()>14)) && (tokensTemp[i].substring(0, 14).equals(tokensTemp[i-1].substring(0, 14)))){
                LinksCodes.add(Long.parseLong( tokensTemp[i].substring(0, 14)));
            }
        }
        return  LinksCodes;
    }

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

