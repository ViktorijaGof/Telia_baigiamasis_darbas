using NUnit.Framework;
using SeleniumFramework;



namespace SeleniumTests.Telia
{
    internal class Purchase
    {
        [SetUp] 
        
        public void SetUp() 
        { 
        Driver.InitializeDriver();
        SeleniumFramework.Pages.Telia.Open();
        } 
        
        [Test]

        public void PurchaseAnItem()
        {

            string expectedResult = "Samsung Galaxy S23+";
            //kodėl SeleniumFramework.Pages yra baltas? o jeigu neįrašau šių žodių, tada Telia klasės neatpažysta? 
            SeleniumFramework.Pages.Telia.clickEParduotuve();
           // SeleniumFramework.Pages.Telia.clickTelefonai(); 
           // SeleniumFramework.Pages.Telia.selectFirstItem();
           // SeleniumFramework.Pages.Telia.checkBePlano();
            //SeleniumFramework.Pages.Telia.clickUzsakytiTelefonaBePlano();
            //SeleniumFramework.Pages.Telia.clickUzsakytiUzsakymoSuvestine();
           // string actualResult = SeleniumFramework.Pages.Telia.GetText();
          //  Assert.AreEqual(expectedResult, actualResult);
           
            //Driver.ShutdownDriver();
            
        }
    }
}
