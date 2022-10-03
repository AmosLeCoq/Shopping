using Shopping;

namespace TestShopping
{
    public static class ArticleGenerator
    {
        public static List<Article> Generate(int amountOfArticles)
        {
            {
                List<Article> articles = new List<Article>();
                for (int i = 0; i < amountOfArticles; i++)
                {
                    articles.Add(new Article());
                }
                return articles;
            }
        }
    }
}
