/**
 * Created with IntelliJ IDEA.
 * User: Varzeshinews
 * Date: 11/07/14
 * Time: 19:40
 * To change this template use File | Settings | File Templates.
 */

package javasandbox;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import java.io.IOException;
import java.util.ArrayList;
import java.util.*;
import java.util.List;

public class NetSpider {


    ///Define Default "sURL" Value
    public String sURL=new String();

    public HashMap WebSiteValue = new HashMap();


    //Define value of Prefix and postfix of news addresses
    public String NewsPrefixAddress=new String();
    public String NewsPostfixAddress=new String();

    //Define Delimiter of news addresses codes
    public String NewsCodesDelimiters = new String();

    //Define begin & end of body that we want to search news addresses codes
    public String NewsBeginCodesDelimiters = new String();
    public String NewsEndCodesDelimiters = new String();

    //Define Start & Length of text that have code of news
    public int CodeStartIndex = 0;
    public int CodeLengthIndex = 0;

    //XStream MagicAPI = new XStream();

    public String getUrlSource(String url) throws IOException {

        Document doc = Jsoup.connect(url)
                .userAgent("Mozilla/5.0 (Windows NT 6.1; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0")
                .get();
        String text = doc.body().text();
        text = doc.html();

        return text;
    }

    public List<String> getNewsLinksCodes(String PageAddress) throws IOException {
        List<String> LinksCodes = new ArrayList();
        //String TokensTemp = getUrlSource("http://www.mashreghnews.ir/fa/politic");

        String[] TokensTemp1 = getUrlSource(PageAddress).split(this.NewsBeginCodesDelimiters);// Get Center News to End Source
        String[] TokensTemp2;
        if(TokensTemp1.length>1)
            TokensTemp2 = TokensTemp1[1].split(this.NewsEndCodesDelimiters);// Get Center News Source
        else
            TokensTemp2 = TokensTemp1[0].split(this.NewsEndCodesDelimiters);// Get Center News Source

        String[] TokensTemp3 = TokensTemp2[0].split(this.NewsCodesDelimiters);// Get Center News Codes to End
        int n=TokensTemp3.length;
        for (int i = 1; i < n; i++){
            LinksCodes.add(TokensTemp3[i].substring(CodeStartIndex, CodeStartIndex+CodeLengthIndex));
        }
        return  LinksCodes;
    }

    public HashMap getNewsText(HashMap NewsPageValue) throws IOException {

//        Input List details
//        Web Address,
//        Type of news begin code,Type of news end code
//        HeadTitle of news begin code,HeadTitle of news end code
//        Title of news begin code,Title of news end code
//        SubTitle of news begin code,SubTitle of news end code
//        Lead of news begin code,Lead of news end code
//        Summary of news begin code,Summary of news end code
//        SoTitle of news begin code,SoTitle of news end code
//        Content of news begin code,Content of news end code
//        Source of news begin code,Source of news end code
//        Stick of news begin code,Stick of news end code
//        RelatedLink of news begin code,RelatedLink of news end code

        HashMap NewsPageDataMap = new HashMap();
        NewsPageDataMap.put("Content", "123");
        System.out.println("123");

        //MagicAPI.toXML(NewsPageDataMap);
        return  NewsPageDataMap;

    }

    public HashMap MapSpider(HashMap KeyMap,HashMap ValueMap) throws IOException {

        HashMap OutputMap = new HashMap();
        String TempHTML =new String(this.getUrlSource((String) ValueMap.get("Address")));
        int i;
        for (i=0;i< KeyMap.size();i++){
            //:)
        }
        return  OutputMap;

    }


}
