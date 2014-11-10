namespace darbio.Lookups.Core.Model.OrganizationTypes
{

    public class PrivateEnterpriseOrganizationType : OrganizationType
    {
        public override string Description
        {
            get
            {
                return "Private Enterprise";
            }
        }

        public override string Key
        {
            get
            {
                return "PVE";
            }
        }
    }
}
