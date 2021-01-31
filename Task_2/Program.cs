using DataLayer;
using Models.Entities;

namespace Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new HomeContext())
            {
                context.ArticleCommonTable.Add(new ArticleCommon
                {
                    Type = "Any",
                    ArticleTitle = "Any",
                    ArticleFirstType = new ArticleFirstType
                    {
                        ArticleFirstTypeProperty = "Any2"
                    },
                    ArticleSecondType = new ArticleSecondType
                    {
                        ArticleSecondTypeProperty = "Any3"
                    }
                });

                context.SaveChanges();
            }
        }
    }
}