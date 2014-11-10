namespace darbio.Lookups.Application
{
    using System;

    using darbio.Lookups.Core.Model.OrganizationTypes;
    using darbio.Lookups.Model;
    using darbio.Lookups.Persistence.Repositories;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Our repository
            var mongoConnectionString = "mongodb://localhost/lookups";
            var repository = new OrganizationRepository(mongoConnectionString);

            // Our organization
            var darbio = new Organization() { Name = "Darb.io", Type = new PrivateEnterpriseOrganizationType() };
            var fireService = new Organization() { Name = "Fire Service", Type = new GovernmentOrganizationType() };
            var charity = new Organization() { Name = "Salvatian Army", Type = new NotForProfitOrganizationType() };

            // Persist
            repository.Add(darbio);
            repository.Add(fireService);
            repository.Add(charity);

            // Get it back
            var organizations = repository.GetAll();

            // Prove the type conversion
            foreach (var organization in organizations)
            {
                Console.WriteLine("{0} is a\t{1} organization!", organization.Name, organization.Type.Description);
            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadKey();
        }
    }
}
