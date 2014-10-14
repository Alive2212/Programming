/**
 * Created with IntelliJ IDEA.
 * User: Varzeshinews
 * Date: 11/07/14
 * Time: 19:29
 * To change this template use File | Settings | File Templates.
 */

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import java.io.*;
import java.util.HashMap;
import java.util.List;

public class Main {


    public static NS_JahanNews iSpider = new NS_JahanNews();
    public static XMLClass iXML = new XMLClass();

    public static void main(String args[]) throws IOException{
//        System.setProperty("proxySet", "true");
//        System.setProperty("http.proxyHost", "proxy.atlas.iri");
//        System.setProperty("http.proxyPort", "8080");
//
//        String text = iSpider.getUrlSource("www.google.com");

//        List<Long> LinksCodes = iSpider.getFirstPageLinksCodes();
//        List<Long> LinksCodes = iSpider.getTotalLinksCodes();
//        List<String> LinksCodes = iSpider.getNewsLinksCodes(iSpider.FirstNewsPageAddress);

        HashMap Temp = new HashMap();
        HashMap subTemp = new HashMap();
        subTemp.put("Address","http://farsnews.com/");
        subTemp.put("TitleNews","http://farsnews.com/allstories");

        Temp.put("Mashreghnews",subTemp);
        Temp.put("FarsNews",subTemp);
        iXML.SaveMap("d:/test.xml",Temp);
        Temp=iXML.LoadMap("d:/test.xml");
        subTemp=(HashMap) Temp.get("Mashreghnews");
//        iSpider.getNewsText(Temp);
//
//        FFObject.WriteToTextFile("d://Test.txt",text);
    }
}