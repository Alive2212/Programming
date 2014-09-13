/**
 * Created with IntelliJ IDEA.
 * User: Babak
 * Date: 8/9/14
 * Time: 11:18 PM
 * To change this template use File | Settings | File Templates.
 */

public class NS_JahanNews extends javasandbox.NetSpider {

    //Address of Pages that has title of all news
    public String FirstNewsPageAddress = "http://jahannews.com/";

    public NS_JahanNews(){
        //Set value of Prefix and postfix of news addresses
        this.NewsPrefixAddress="http://jahannews.com/";
        this.NewsPostfixAddress="";

        //Set Delimiter of news addresses codes
        this.NewsCodesDelimiters = "mnDiv8Title";

        //Set begin & end of body that we want to search news addresses codes
        this.NewsBeginCodesDelimiters = "not needed 132456789";
        this.NewsEndCodesDelimiters = "not needed 132456789";

        //Set Start & Length of text that have code of news
        this.CodeStartIndex=11;
        this.CodeLengthIndex=26;

    }
}

