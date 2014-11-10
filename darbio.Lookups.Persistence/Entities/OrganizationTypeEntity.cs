namespace darbio.Lookups.Persistence.Entities
{
    using System;

    using darbio.Lookups.Core.Interfaces.Model;

    using MongoDB.Bson.Serialization.Attributes;

    /// <summary>
    /// The organization type entity. All organization types are persisted as this type, and then retyped on mapping to the domain object.
    /// </summary>
    public class OrganizationTypeEntity : IOrganizationType
    {
        /// <summary>
        /// Gets the description. This is not persisted.
        /// </summary>
        [BsonIgnore]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the key. This is not persisted.
        /// </summary>
        [BsonIgnore]
        public string Key { get; private set; }

        /// <summary>
        /// Gets or sets the type of the persisted object.
        /// </summary>
        public Type Type { get; set; }
    }
}
