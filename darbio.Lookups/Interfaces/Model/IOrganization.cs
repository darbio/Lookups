namespace darbio.Lookups.Core.Interfaces.Model
{
    public interface IOrganization
    {
        string Name { get; set; }

        IOrganizationType Type { get; set; }
    }
}
