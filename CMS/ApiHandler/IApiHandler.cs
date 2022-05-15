namespace CMS.ApiHandler
{
    public interface IApiHandler
    {
        string GetAPI(string Url);
        string PostWithModel(dynamic dynamicModel, string Url);
    }
}
