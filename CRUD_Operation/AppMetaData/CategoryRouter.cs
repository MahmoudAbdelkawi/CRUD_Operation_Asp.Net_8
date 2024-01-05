namespace CRUD_Operation.AppMetaData.BaseRouter
{
    public partial class Router
    {
        public class CategoryRouter : Router
        {
            private const string Prefix = Rule + "Category";
            public const string Main = Prefix + "/";
            public const string MainId = Prefix + "/{id}";
        }
    }
  
}
