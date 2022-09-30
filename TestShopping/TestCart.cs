using Shopping;

namespace TestShopping
{
    public class TestCart
    {
        #region private attributes
        private Cart _cart = null;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _cart = new Cart();
        }

        [Test]
        public void Add_FirstArticle_Success()
        {
            //given
            //refer to Setup
            Assert.AreEqual(0, _cart.Articles.Count());
            List<Article> articlesToAdd = new List<Article>();
            Article articleToAdd = new Article();
            articlesToAdd.Add(articleToAdd);

            //when
            _cart.Add(articlesToAdd);

            //then
            Assert.AreEqual(1, _cart.Articles.Count());
        }
    }
}