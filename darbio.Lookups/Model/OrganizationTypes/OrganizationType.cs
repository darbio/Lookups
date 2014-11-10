namespace darbio.Lookups.Core.Model.OrganizationTypes
{
    using darbio.Lookups.Core.Interfaces.Model;

    public abstract class OrganizationType : IOrganizationType
    {
        public abstract string Description { get; }

        public abstract string Key { get; }
    }
}
