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


public class NetSpider {
    //public string Web_Address = "";

    public static String getUrlSource(String url) throws IOException {

        Document doc = Jsoup.connect(url).get();
        String text = doc.body().text();
        text = doc.html();

        return text;
    }
    public static String sURL="www.google.com";
}
