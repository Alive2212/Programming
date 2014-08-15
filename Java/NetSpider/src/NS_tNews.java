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

public class NS_tNews extends javasandbox.NetSpider {

    public static String NewsPrefixAddress="http://tnews.ir/news/";
    public static String NewsExtensionAddress=".html";

    public static String NewsCodesDelims = "\"Newslink\" target=\"_blank\"";

    public static String NewsCenterCodesDelims = "<div class=\"centercolumn\">";
    public static String NewsLeftCodesDelims = "<div class=\"leftcolumn\">";

    //__________ Address of Pages that has title of all news
    public static String SportNewsPageAddress = "http://tnews.ir/Groups/%D9%88%D8%B1%D8%B2%D8%B4%DB%8C/1";

    public static List<String> getNewsLinksCodes(String PageAddress) throws IOException {
        List<String> LinksCodes = new ArrayList();
        String[] TokensTemp = getUrlSource(PageAddress).split(NewsCodesDelims);// Get Center News Codes to End

        for (int i = 1; i < TokensTemp.length; i++){
            LinksCodes.add(TokensTemp[i].substring(13, 25));
        }
        return  LinksCodes;
    }

}

