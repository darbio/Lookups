using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darbio.Lookups.Core.Model.OrganizationTypes
{
    public class NotForProfitOrganizationType : OrganizationType
    {
        public override string Description
        {
            get
            {
                return "Not for profit";
            }
        }

        public override string Key
        {
            get
            {
                return "NFP";
            }
        }
    }
}
