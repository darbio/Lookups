namespace darbio.Lookups.Persistence.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using AutoMapper;

    using darbio.Lookups.Core.Interfaces.Model;
    using darbio.Lookups.Core.Model.OrganizationTypes;
    using darbio.Lookups.Model;
    using darbio.Lookups.Persistence.Entities;

    using MongoDB.Driver;

    using MongoRepository;

    public class OrganizationRepository
    {
        private readonly MongoRepository<OrganizationEntity> repository;

        public OrganizationRepository(string connectionString)
        {
            // Validations
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("Connection string must not be null or empty.");
            }

            var mongoUrl = new MongoUrl(connectionString);
            if (string.IsNullOrEmpty(mongoUrl.DatabaseName))
            {
                throw new ArgumentException("Connection string must specify a database.");
            }

            // Create the mappings
            // First our organization -> entity
            Mapper.CreateMap<Organization, OrganizationEntity>();
            Mapper.CreateMap<OrganizationEntity, Organization>();

            // And then our organization type -> entity
            Mapper.CreateMap<OrganizationType, OrganizationTypeEntity>().ForMember(a => a.Type, a => a.MapFrom(b => b.GetType()));

            // Now all of our types in the model using our custom type converter
            var organizationTypes = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(a => a.IsClass && a.Namespace == typeof(OrganizationType).Namespace);

            foreach (var type in organizationTypes)
            {
                Mapper.CreateMap(typeof(OrganizationTypeEntity), type);
            }

            // Create our underlying repository
            this.repository = new MongoRepository<OrganizationEntity>(mongoUrl);
        }

        public IEnumerable<IOrganization> GetAll()
        {
            return Mapper.Map<IEnumerable<Organization>>(this.repository.ToList());
        }

        public IOrganization Add(IOrganization organization)
        {
            return this.repository.Add(Mapper.Map<OrganizationEntity>(organization));
        }
    }
}
