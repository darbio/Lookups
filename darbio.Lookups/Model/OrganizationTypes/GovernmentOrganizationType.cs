namespace darbio.Lookups.Core.Model.OrganizationTypes
{
    public class GovernmentOrganizationType : OrganizationType
    {
        public override string Description
        {
            get
            {
                return "Government";
            }
        }

        public override string Key
        {
            get
            {
                return "GOV";
            }
        }
    }
}
