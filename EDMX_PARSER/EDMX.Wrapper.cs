using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using EDMX_PARSER;
using System.Configuration;
using EDMX_PARSER.Serialize;

namespace EDMX_PARSER.Wrapper
{
    public partial class Edmx
    {
        public EDMX_PARSER.Serialize.Edmx edmx;

        public Edmx()
        {
            String fullFileName = ConfigurationManager.AppSettings["FullFilePath"];
            XmlSerializer deserializer = new XmlSerializer(typeof(EDMX_PARSER.Serialize.Edmx));
            TextReader reader = new StreamReader(fullFileName);
            object obj = deserializer.Deserialize(reader);
            this.edmx = (EDMX_PARSER.Serialize.Edmx)obj;
            reader.Close();
        }

        #region Level 1 - edmx

        public EdmxDesigner GetDesigner()
        {
            return edmx.Designer;
        }

        public EdmxRuntime GetRuntime()
        {
            return edmx.Runtime;
        }

        #endregion
        
        #region Level 2 - models and mappings

        public EdmxRuntimeStorageModels GetStorageModel()
        {
            return GetRuntime().StorageModels;
        }

        public EdmxRuntimeConceptualModels GetConceptualModel()
        {
            return GetRuntime().ConceptualModels;
        }

        public EdmxRuntimeMappings GetMappings()
        {
            return GetRuntime().Mappings;
        }

        #endregion

        #region Level 3 - schema and mapping

        public Schema GetStorageModelSchema()
        {
            return GetStorageModel().Schema;
        }

        public Schema1 GetConceptualModelSchema()
        {
            return GetConceptualModel().Schema;
        }

        public Mapping GetMappingsMapping()
        {
            return GetMappings().Mapping;
        }

        #endregion

        #region Level 4 - Model Contents

        //Level 4 - Storage Model
        public SchemaEntityContainer GetStorageModelEntityContainer()
        {
            return GetStorageModelSchema().EntityContainer;
        }

        public SchemaEntityType[] GetStorageModelEntityType()
        {
            return GetStorageModelSchema().EntityType;
        }

        public SchemaAssociation[] GetStorageModelAssociation()
        {
            return GetStorageModelSchema().Association;
        }

        public SchemaFunction[] GetStorageModelFunction()
        {
            return GetStorageModelSchema().Function;
        }

        //Level 4 - Conceptual Model
        public SchemaEntityContainer1 GetConceptualModelEntityContainer()
        {
            return GetConceptualModelSchema().EntityContainer;
        }

        public SchemaEntityType1[] GetConceptualModelEntityType()
        {
            return GetConceptualModelSchema().EntityType;
        }

        public SchemaAssociation1[] GetConceptualModelAssociation()
        {
            return GetConceptualModelSchema().Association;
        }

        //Level 4 - Mapping
        public MappingEntityContainerMapping GetMappingEntityContainerMapping()
        {
            return GetMappingsMapping().EntityContainerMapping;
        }

        public MappingEntityContainerMappingEntitySetMapping[] GetMappingEntitySetMapping()
        {
            return GetMappingEntityContainerMapping().EntitySetMapping;
        }

        public MappingEntityContainerMappingFunctionImportMapping[] GetMappingFunctionImportMapping()
        {
            return GetMappingEntityContainerMapping().FunctionImportMapping;
        }

        #endregion

    }
}
