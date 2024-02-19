namespace fu.Microservices.BisnesLogicalService;

public interface IBusinessLogicalService
{
    Task<string> Ping();
}