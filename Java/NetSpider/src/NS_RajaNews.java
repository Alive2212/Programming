/**
 * Created with IntelliJ IDEA.
 * User: Babak
 * Date: 8/9/14
 * Time: 11:18 PM
 * To change this template use File | Settings | File Templates.
 */

public class NS_RajaNews extends javasandbox.NetSpider {

    //Address of Pages that has title of all news
    public String FirstNewsPageAddress = "http://rajanews.com/";

    public NS_RajaNews(){
        //Set value of Prefix and postfix of news addresses
        this.NewsPrefixAddress="http://rajanews.com/detail.asp?id=";
        this.NewsPostfixAddress="";

        //Set Delimiter of news addresses codes
        this.NewsCodesDelimiters = "href=\"detail.asp";

        //Set begin & end of body that we want to search news addresses codes
        this.NewsBeginCodesDelimiters = "Akhbar.gif";
        this.NewsEndCodesDelimiters = "Resaneha.gif";

        //Set Start & Length of text that have code of news
        this.CodeStartIndex=4;
        this.CodeLengthIndex=6;

    }
}

