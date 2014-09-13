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
import java.util.List;

public class Main {
    public static FolderAndFile FFObject = new FolderAndFile();
    public static NS_MashreghNews iSpider = new NS_MashreghNews();

    public static void main(String args[]) throws IOException{
        System.setProperty("proxySet", "true");
        System.setProperty("http.proxyHost", "proxy.atlas.iri");
        System.setProperty("http.proxyPort", "8080");

        //String text = iSpider.getUrlSource("www.google.com");

        //List<Long> LinksCodes = iSpider.getFirstPageLinksCodes();
        //List<Long> LinksCodes = iSpider.getTotalLinksCodes();
        List<String> LinksCodes = iSpider.getNewsLinksCodes(iSpider.FirstNewsPageAddress);

        //FFObject.WriteToTextFile("d://Test.txt",text);
    }
}