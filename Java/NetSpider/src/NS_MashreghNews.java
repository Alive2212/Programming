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

import java.net.*;
import java.io.*;

public class NS_MashreghNews extends javasandbox.NetSpider {

    public static String NewsPrefixAddress="http://www.mashreghnews.ir/fa/news/";
    public static String NewsExtensionAddress="";

    public static String NewsCodesDelims = "\"/fa/news/";

    public static String NewsCenterCodesDelims = "l_content";
    public static String NewsLeftCodesDelims = "<!-- end -->";

    ///__________ Address of Pages that has title of all news
    public static String FirstNewsPageAddress = "http://www.mashreghnews.ir/";


    public static List<String> getNewsLinksCodes(String PageAddress) throws IOException {
        List<String> LinksCodes = new ArrayList();
        //String TokensTemp = getUrlSource("http://www.mashreghnews.ir/fa/politic");

        URL oracle = new URL("http://www.mashreghnews.ir/fa/");
        BufferedReader in = new BufferedReader(
                new InputStreamReader(oracle.openStream()));



        String[] TokensTemp1 = getUrlSource(PageAddress).split(NewsCenterCodesDelims);// Get Center News to End Source
        String[] TokensTemp2;
        if(TokensTemp1.length>1)
            TokensTemp2 = TokensTemp1[1].split(NewsLeftCodesDelims);// Get Center News Source
        else
            TokensTemp2 = TokensTemp1[0].split(NewsLeftCodesDelims);// Get Center News Source

        String[] TokensTemp3 = TokensTemp2[0].split(NewsCodesDelims);// Get Center News Codes to End
        int n=TokensTemp3.length;
        for (int i = 1; i < n; i++){
            LinksCodes.add(TokensTemp3[i].substring(13, 25));
        }
        return  LinksCodes;
    }

}

