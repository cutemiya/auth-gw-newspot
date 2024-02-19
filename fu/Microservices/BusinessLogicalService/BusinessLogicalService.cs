using System.Net;

namespace fu.Microservices.BisnesLogicalService;

public class BusinessLogicalService: IBusinessLogicalService
{
    private readonly string baseUrl = "http://bi-service";
    private readonly HttpClient httpClient = new();
    public async Task<string> Ping()
    {
        var response = await httpClient.GetAsync(new Uri($"{baseUrl}/get123"));

        if (response.StatusCode == HttpStatusCode.OK) return "pong";
        
        Console.WriteLine(response);
        Console.WriteLine(response.Content);
        return "not pong";

    }
}