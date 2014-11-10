namespace darbio.Lookups.Model
{
    using darbio.Lookups.Core.Interfaces.Model;

    public class Organization : IOrganization
    {
        public string Name { get; set; }

        public IOrganizationType Type { get; set; }
    }
}
