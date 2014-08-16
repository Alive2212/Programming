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
    public static NS_FarsNews iSpider = new NS_FarsNews();

    public static void main(String args[]) throws IOException{
        String text = iSpider.getUrlSource("http://farsnews.com/newsv.php?srv=4&title=1");

        //List<Long> LinksCodes = iSpider.getFirstPageLinksCodes();
        //List<Long> LinksCodes = iSpider.getTotalLinksCodes();
        List<Long> LinksCodes = iSpider.getCenterNewsLinksCodes(iSpider.TotalAddress);

        FFObject.WriteToTextFile("d://Test.txt",text);
    }
}