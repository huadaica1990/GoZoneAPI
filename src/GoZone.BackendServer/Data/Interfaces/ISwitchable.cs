using GoZone.BackendServer.Data.Enums;

namespace GoZone.BackendServer.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}
