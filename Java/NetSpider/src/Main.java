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
    public static NS_tNews iSpider = new NS_tNews();

    public static void main(String args[]) throws IOException{
        //String text = iSpider.getUrlSource("www.google.com");

        //List<Long> LinksCodes = iSpider.getFirstPageLinksCodes();
        //List<Long> LinksCodes = iSpider.getTotalLinksCodes();
        List<String> LinksCodes = iSpider.getNewsLinksCodes(iSpider.SportNewsPageAddress);

        //FFObject.WriteToTextFile("d://Test.txt",text);
    }
}