using System.Net;

namespace fu.Microservices.BisnesLogicalService;

public class BusinessLogicalService: IBusinessLogicalService
{
    private readonly string baseUrl;
    private readonly HttpClient httpClient; 
    
    public BusinessLogicalService(HttpClient httpClient)
    {
        baseUrl = "bi-service";
        this.httpClient = httpClient;
    }
    public async Task<string> Ping()
    {
        var response = await httpClient.GetAsync($"{baseUrl}/get123");

        return response.StatusCode != HttpStatusCode.OK ? "not pong" : "pong";
    }
}