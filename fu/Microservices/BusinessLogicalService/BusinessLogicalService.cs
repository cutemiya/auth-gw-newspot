using System.Net;

namespace fu.Microservices.BisnesLogicalService;

public class BusinessLogicalService: IBusinessLogicalService
{
    private readonly string baseUrl = "bi-service";
    private readonly HttpClient httpClient = new();
    public async Task<string> Ping()
    {
        var response = await httpClient.GetAsync($"{baseUrl}/get123");

        return response.StatusCode != HttpStatusCode.OK ? "not pong" : "pong";
    }
}