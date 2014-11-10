namespace darbio.Lookups.Persistence.Entities
{
    using darbio.Lookups.Core.Interfaces.Model;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    using MongoRepository;

    public class OrganizationEntity : IEntity, IOrganization
    {
        public OrganizationEntity()
        {
            this.Id = ObjectId.GenerateNewId().ToString();
        }
        public string Name { get; set; }

        public IOrganizationType Type { get; set; }

        [BsonId]
        public string Id { get; set; }
    }
}
