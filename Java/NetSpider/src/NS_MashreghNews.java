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

    //Address of Pages that has title of all news
    public String FirstNewsPageAddress = "http://www.mashreghnews.ir/";

    public NS_MashreghNews (){
        //Set PageNews values
        //this.NewsPageValue.add("http://www.mashreghnews.ir/fa/news/350954");
        //this.NewsPageValue.add("http://www.mashreghnews.ir/fa/news/350954");

        //Set value of Prefix and postfix of news addresses
        this.NewsPrefixAddress="http://www.mashreghnews.ir/fa/news/";
        this.NewsPostfixAddress="";

        //Set Delimiter of news addresses codes
        this.NewsCodesDelimiters = "\"/fa/news/";

        //Set begin & end of body that we want to search news addresses codes
        this.NewsBeginCodesDelimiters = "l_content";
        this.NewsEndCodesDelimiters = "<!-- end -->";

        //Set Start & Length of text that have code of news
        this.CodeStartIndex=0;
        this.CodeLengthIndex=6;
    }
}

