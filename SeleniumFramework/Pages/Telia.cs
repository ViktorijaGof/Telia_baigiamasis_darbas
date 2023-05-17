using System;


namespace SeleniumFramework.Pages
{
    public class Telia
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.telia.lt/privatiems");
        }
        
        internal static void clickEParduotuve()
        {
            //string locator = "/html/body/header/div/div[1]/header/div/div/div/div[2]/div[2]/div/a"; kai nukopijuoju xpath adresą - rodo tokią nesąmonę... Rašau maždaug taup //*[@class='LinkItemstyles_LinkAnchor']", bet vieko neranda
            Common.Click(locator);
        }
        internal static void clickTelefonai()
        {
            //pvz.: string locator = "//*[@class='cb1-element']";
            Common.Click(locator);
        }
        internal static void checkBePlano()
        {
            //throw new NotImplementedException();
        }

        internal static string GetText()
        {
            //throw new NotImplementedException();
        }
             

        internal static void selectFirstItem()
        {
            //throw new NotImplementedException();
        }
    }
}
