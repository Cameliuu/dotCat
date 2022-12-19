using dotCat.Requests;
using RestSharp;

namespace dotCat;

public sealed class CatClient
{
    private static CatClient? _instsance;
    private RestClient _client = new RestClient();
    private CatClient()
    {
    }

    public static CatClient Instace
    {
        get
        {
            if (_instsance is null)
                _instsance = new CatClient();
            return _instsance;
        }
    }

    public ImageRequestBuilder GetRequestBuilder()
    {
        return new ImageRequestBuilder();
    }

    public RestResponse GetResponse(RestRequest request)
    {
        return _client.GetAsync(request).Result;
    }

    
}
