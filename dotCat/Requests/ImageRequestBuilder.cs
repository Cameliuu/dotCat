using RestSharp;

namespace dotCat.Requests;

public class ImageRequestBuilder
{
    private static string _baseUrl = "https://api.thecatapi.com/v1/images/search";
    private static RestRequest _request = new RestRequest(_baseUrl);

    public ImageRequestBuilder WithLimit(int limit)
    {
        _request.AddParameter("limit", limit);
        return this;
    }
    public  ImageRequestBuilder WithBreed(string breeds)
    {
        _request.AddParameter("breed_ids", breeds);
        return this;
    }

    public ImageRequestBuilder HasBreeds(bool b)
    {
        _request.AddParameter("has_breeds",getIntFromBool(b));
        return this;
    }

    public short getIntFromBool(bool b)
    {
        return (short)((b) ? 0 : 1);
    }

    public RestRequest Build()
    {
        return _request;
    }
}
