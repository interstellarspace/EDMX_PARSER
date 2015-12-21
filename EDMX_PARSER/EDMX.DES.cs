using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDMX_PARSER.Wrapper;
using EDMX_PARSER.Serialize;

namespace EDMX_PARSER.DES
{
    class EDMX : EDMX_PARSER.Wrapper.Edmx
    {

        public EDMX() : base()
        {
            var EntityType = GetConceptualModelEntityType();
            var AssociationSet = GetStorageModelEntityContainer().AssociationSet;
            var Association = GetStorageModelSchema().Association;
            var SEntityType = GetStorageModelEntityType();

            var address = GetEntity("Address");

            var result = from nav in address.NavigationProperty
                         join assoc in AssociationSet
                         on StripLastName(nav.Relationship) equals assoc.Name
                         select new
                         {
                             address.Name,
                             nav.Relationship,
                             nav.FromRole,
                             nav.ToRole,
                             assoc.End
                         };

            var r = //from EntType in EntityType
                    from NavProp in GetEntity("Address").NavigationProperty
                    join EntAssoc in Association
                    on StripLastName(NavProp.Relationship) equals EntAssoc.Name
                    from Role in EntAssoc.End
                    join Db in SEntityType
                    on StripLastName(Role.Type) equals Db.Name
                    into res
                    select res;
        }

        
        public SchemaEntityType1 GetEntity(string name)
        {
            var entitytype = GetConceptualModelEntityType();

            var result = (from entity in entitytype
                          where entity.Name == name
                          select entity).First();

            return (EDMX_PARSER.Serialize.SchemaEntityType1)result;
        }

        /*public IEnumerable<SchemaEntityTypeNavigationProperty> GetRelatedEntity(string name)
        {
            var entity = GetEntity(name);
            var result = entity.NavigationProperty;

            return (IEnumerable<SchemaEntityTypeNavigationProperty>)result;
        }

        public SchemaAssociation GetRelatedEntityAssociation(string relationship)
        {
            string identifier = StripLastName(relationship);

            var association = (from assoc in this.Associations
                               where assoc.Name == identifier
                               select assoc).First();

            return association;
        }*/

        public string StripLastName(string relationship)
        {
            string[] names = relationship.Split('.');
            string identifier = names[names.Length - 1];
            return identifier;
        }
        

    }
}
