using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    interface IEditor
    {
        public Article FindArticle(List<Article> articles);

        public List<string> GetAllTags(List<Article> articles);

    }
}
