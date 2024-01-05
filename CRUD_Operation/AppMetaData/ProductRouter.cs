namespace CRUD_Operation.AppMetaData.BaseRouter
{
    public partial class Router
    {
        public class ProductRouter : Router
        {
            private const string Prefix = Rule + "Product";
            public const string Main = Prefix + "/";
            public const string MainId = Prefix + "/{id}";
        }
    }
}
