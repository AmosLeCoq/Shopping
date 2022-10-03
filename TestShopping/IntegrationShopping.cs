using Shopping;

namespace TestShopping
{
    public class IntegrationShopping
    {
        #region private attributes
        private Cart _cart = new Cart();
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Shopping_NominalCase_Success()
        {
            //Checkout Process

            //Foreach article in cart
                //1. Remove it from cart

                //2. Deposit it in checkout's belt

                    //2.1 Update Checkout's articles

                    //2.1 Update Checkout's balance

                //3. Add it in Shopping Bag

            //
        }
    }
}