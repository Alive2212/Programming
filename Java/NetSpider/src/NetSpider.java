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

import javax.swing.*;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;


public class NetSpider {

    ///Define Default "sURL" Value
    public String sURL=new String();


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


    public static String getUrlSource(String url) throws IOException {

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

}
