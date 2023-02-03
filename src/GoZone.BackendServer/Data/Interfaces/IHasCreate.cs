namespace GoZone.BackendServer.Data.Interfaces
{
    public interface IHasCreate
    {
        string CreateBy { get; set; }
        string CreateUpdate { get; set; }
    }
}
