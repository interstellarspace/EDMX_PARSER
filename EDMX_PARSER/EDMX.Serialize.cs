using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMX_PARSER.Serialize
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx", IsNullable = false)]
    public partial class Edmx
    {

        private EdmxRuntime runtimeField;

        private EdmxDesigner designerField;

        private decimal versionField;

        /// <remarks/>
        public EdmxRuntime Runtime
        {
            get
            {
                return this.runtimeField;
            }
            set
            {
                this.runtimeField = value;
            }
        }

        /// <remarks/>
        public EdmxDesigner Designer
        {
            get
            {
                return this.designerField;
            }
            set
            {
                this.designerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxRuntime
    {

        private EdmxRuntimeStorageModels storageModelsField;

        private EdmxRuntimeConceptualModels conceptualModelsField;

        private EdmxRuntimeMappings mappingsField;

        /// <remarks/>
        public EdmxRuntimeStorageModels StorageModels
        {
            get
            {
                return this.storageModelsField;
            }
            set
            {
                this.storageModelsField = value;
            }
        }

        /// <remarks/>
        public EdmxRuntimeConceptualModels ConceptualModels
        {
            get
            {
                return this.conceptualModelsField;
            }
            set
            {
                this.conceptualModelsField = value;
            }
        }

        /// <remarks/>
        public EdmxRuntimeMappings Mappings
        {
            get
            {
                return this.mappingsField;
            }
            set
            {
                this.mappingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxRuntimeStorageModels
    {

        private Schema schemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
        public Schema Schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl", IsNullable = false)]
    public partial class Schema
    {

        private SchemaEntityContainer entityContainerField;

        private SchemaEntityType[] entityTypeField;

        private SchemaAssociation[] associationField;

        private SchemaFunction[] functionField;

        private string namespaceField;

        private string aliasField;

        private string providerField;

        private ushort providerManifestTokenField;

        /// <remarks/>
        public SchemaEntityContainer EntityContainer
        {
            get
            {
                return this.entityContainerField;
            }
            set
            {
                this.entityContainerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityType")]
        public SchemaEntityType[] EntityType
        {
            get
            {
                return this.entityTypeField;
            }
            set
            {
                this.entityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Association")]
        public SchemaAssociation[] Association
        {
            get
            {
                return this.associationField;
            }
            set
            {
                this.associationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Function")]
        public SchemaFunction[] Function
        {
            get
            {
                return this.functionField;
            }
            set
            {
                this.functionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Namespace
        {
            get
            {
                return this.namespaceField;
            }
            set
            {
                this.namespaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ProviderManifestToken
        {
            get
            {
                return this.providerManifestTokenField;
            }
            set
            {
                this.providerManifestTokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaEntityContainer
    {

        private SchemaEntityContainerEntitySet[] entitySetField;

        private SchemaEntityContainerAssociationSet[] associationSetField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntitySet")]
        public SchemaEntityContainerEntitySet[] EntitySet
        {
            get
            {
                return this.entitySetField;
            }
            set
            {
                this.entitySetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociationSet")]
        public SchemaEntityContainerAssociationSet[] AssociationSet
        {
            get
            {
                return this.associationSetField;
            }
            set
            {
                this.associationSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaEntityContainerEntitySet
    {

        private string nameField;

        private string entityTypeField;

        private string typeField;

        private string schemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntityType
        {
            get
            {
                return this.entityTypeField;
            }
            set
            {
                this.entityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2007/12/edm/EntityStoreSchemaGenerator")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaEntityContainerAssociationSet
    {

        private SchemaEntityContainerAssociationSetEnd[] endField;

        private string nameField;

        private string associationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("End")]
        public SchemaEntityContainerAssociationSetEnd[] End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Association
        {
            get
            {
                return this.associationField;
            }
            set
            {
                this.associationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaEntityContainerAssociationSetEnd
    {

        private string roleField;

        private string entitySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntitySet
        {
            get
            {
                return this.entitySetField;
            }
            set
            {
                this.entitySetField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaEntityType
    {

        private SchemaEntityTypeKey keyField;

        private SchemaEntityTypeProperty[] propertyField;

        private string nameField;

        /// <remarks/>
        public SchemaEntityTypeKey Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public SchemaEntityTypeProperty[] Property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaEntityTypeKey
    {

        private SchemaEntityTypeKeyPropertyRef propertyRefField;

        /// <remarks/>
        public SchemaEntityTypeKeyPropertyRef PropertyRef
        {
            get
            {
                return this.propertyRefField;
            }
            set
            {
                this.propertyRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaEntityTypeKeyPropertyRef
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaEntityTypeProperty
    {

        private string nameField;

        private string typeField;

        private bool nullableField;

        private bool nullableFieldSpecified;

        private ushort maxLengthField;

        private bool maxLengthFieldSpecified;

        private byte precisionField;

        private bool precisionFieldSpecified;

        private byte scaleField;

        private bool scaleFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Nullable
        {
            get
            {
                return this.nullableField;
            }
            set
            {
                this.nullableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NullableSpecified
        {
            get
            {
                return this.nullableFieldSpecified;
            }
            set
            {
                this.nullableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort MaxLength
        {
            get
            {
                return this.maxLengthField;
            }
            set
            {
                this.maxLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxLengthSpecified
        {
            get
            {
                return this.maxLengthFieldSpecified;
            }
            set
            {
                this.maxLengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Precision
        {
            get
            {
                return this.precisionField;
            }
            set
            {
                this.precisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrecisionSpecified
        {
            get
            {
                return this.precisionFieldSpecified;
            }
            set
            {
                this.precisionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleSpecified
        {
            get
            {
                return this.scaleFieldSpecified;
            }
            set
            {
                this.scaleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaAssociation
    {

        private SchemaAssociationEnd[] endField;

        private SchemaAssociationReferentialConstraint referentialConstraintField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("End")]
        public SchemaAssociationEnd[] End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        public SchemaAssociationReferentialConstraint ReferentialConstraint
        {
            get
            {
                return this.referentialConstraintField;
            }
            set
            {
                this.referentialConstraintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaAssociationEnd
    {

        private string roleField;

        private string typeField;

        private string multiplicityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Multiplicity
        {
            get
            {
                return this.multiplicityField;
            }
            set
            {
                this.multiplicityField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaAssociationReferentialConstraint
    {

        private SchemaAssociationReferentialConstraintPrincipal principalField;

        private SchemaAssociationReferentialConstraintDependent dependentField;

        /// <remarks/>
        public SchemaAssociationReferentialConstraintPrincipal Principal
        {
            get
            {
                return this.principalField;
            }
            set
            {
                this.principalField = value;
            }
        }

        /// <remarks/>
        public SchemaAssociationReferentialConstraintDependent Dependent
        {
            get
            {
                return this.dependentField;
            }
            set
            {
                this.dependentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaAssociationReferentialConstraintPrincipal
    {

        private SchemaAssociationReferentialConstraintPrincipalPropertyRef propertyRefField;

        private string roleField;

        /// <remarks/>
        public SchemaAssociationReferentialConstraintPrincipalPropertyRef PropertyRef
        {
            get
            {
                return this.propertyRefField;
            }
            set
            {
                this.propertyRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaAssociationReferentialConstraintPrincipalPropertyRef
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaAssociationReferentialConstraintDependent
    {

        private SchemaAssociationReferentialConstraintDependentPropertyRef propertyRefField;

        private string roleField;

        /// <remarks/>
        public SchemaAssociationReferentialConstraintDependentPropertyRef PropertyRef
        {
            get
            {
                return this.propertyRefField;
            }
            set
            {
                this.propertyRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaAssociationReferentialConstraintDependentPropertyRef
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaFunction
    {

        private SchemaFunctionParameter[] parameterField;

        private string nameField;

        private bool aggregateField;

        private bool builtInField;

        private bool niladicFunctionField;

        private bool isComposableField;

        private string parameterTypeSemanticsField;

        private string schemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public SchemaFunctionParameter[] Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Aggregate
        {
            get
            {
                return this.aggregateField;
            }
            set
            {
                this.aggregateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BuiltIn
        {
            get
            {
                return this.builtInField;
            }
            set
            {
                this.builtInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NiladicFunction
        {
            get
            {
                return this.niladicFunctionField;
            }
            set
            {
                this.niladicFunctionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsComposable
        {
            get
            {
                return this.isComposableField;
            }
            set
            {
                this.isComposableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParameterTypeSemantics
        {
            get
            {
                return this.parameterTypeSemanticsField;
            }
            set
            {
                this.parameterTypeSemanticsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")]
    public partial class SchemaFunctionParameter
    {

        private string nameField;

        private string modeField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxRuntimeConceptualModels
    {

        private Schema1 schemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
        public Schema1 Schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    [System.Xml.Serialization.XmlRootAttribute("Schema", Namespace = "http://schemas.microsoft.com/ado/2008/09/edm", IsNullable = false)]
    public partial class Schema1
    {

        private SchemaEntityContainer1 entityContainerField;

        private SchemaEntityType1[] entityTypeField;

        private SchemaAssociation1[] associationField;

        private string namespaceField;

        private string aliasField;

        /// <remarks/>
        public SchemaEntityContainer1 EntityContainer
        {
            get
            {
                return this.entityContainerField;
            }
            set
            {
                this.entityContainerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityType")]
        public SchemaEntityType1[] EntityType
        {
            get
            {
                return this.entityTypeField;
            }
            set
            {
                this.entityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Association")]
        public SchemaAssociation1[] Association
        {
            get
            {
                return this.associationField;
            }
            set
            {
                this.associationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Namespace
        {
            get
            {
                return this.namespaceField;
            }
            set
            {
                this.namespaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaEntityContainer1
    {

        private SchemaEntityContainerEntitySet1[] entitySetField;

        private SchemaEntityContainerAssociationSet1[] associationSetField;

        private SchemaEntityContainerFunctionImport[] functionImportField;

        private string nameField;

        private bool lazyLoadingEnabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntitySet")]
        public SchemaEntityContainerEntitySet1[] EntitySet
        {
            get
            {
                return this.entitySetField;
            }
            set
            {
                this.entitySetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociationSet")]
        public SchemaEntityContainerAssociationSet1[] AssociationSet
        {
            get
            {
                return this.associationSetField;
            }
            set
            {
                this.associationSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FunctionImport")]
        public SchemaEntityContainerFunctionImport[] FunctionImport
        {
            get
            {
                return this.functionImportField;
            }
            set
            {
                this.functionImportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/ado/2009/02/edm/annotation")]
        public bool LazyLoadingEnabled
        {
            get
            {
                return this.lazyLoadingEnabledField;
            }
            set
            {
                this.lazyLoadingEnabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaEntityContainerEntitySet1
    {

        private string nameField;

        private string entityTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntityType
        {
            get
            {
                return this.entityTypeField;
            }
            set
            {
                this.entityTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaEntityContainerAssociationSet1
    {

        private SchemaEntityContainerAssociationSetEnd1[] endField;

        private string nameField;

        private string associationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("End")]
        public SchemaEntityContainerAssociationSetEnd1[] End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Association
        {
            get
            {
                return this.associationField;
            }
            set
            {
                this.associationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaEntityContainerAssociationSetEnd1
    {

        private string roleField;

        private string entitySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntitySet
        {
            get
            {
                return this.entitySetField;
            }
            set
            {
                this.entitySetField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaEntityContainerFunctionImport
    {

        private SchemaEntityContainerFunctionImportParameter[] parameterField;

        private string nameField;

        private string entitySetField;

        private string returnTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public SchemaEntityContainerFunctionImportParameter[] Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntitySet
        {
            get
            {
                return this.entitySetField;
            }
            set
            {
                this.entitySetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReturnType
        {
            get
            {
                return this.returnTypeField;
            }
            set
            {
                this.returnTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaEntityContainerFunctionImportParameter
    {

        private string nameField;

        private string modeField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaEntityType1
    {

        private SchemaEntityTypeKey1 keyField;

        private SchemaEntityTypeProperty1[] propertyField;

        private SchemaEntityTypeNavigationProperty[] navigationPropertyField;

        private string nameField;

        /// <remarks/>
        public SchemaEntityTypeKey1 Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public SchemaEntityTypeProperty1[] Property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NavigationProperty")]
        public SchemaEntityTypeNavigationProperty[] NavigationProperty
        {
            get
            {
                return this.navigationPropertyField;
            }
            set
            {
                this.navigationPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaEntityTypeKey1
    {

        private SchemaEntityTypeKeyPropertyRef1 propertyRefField;

        /// <remarks/>
        public SchemaEntityTypeKeyPropertyRef1 PropertyRef
        {
            get
            {
                return this.propertyRefField;
            }
            set
            {
                this.propertyRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaEntityTypeKeyPropertyRef1
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaEntityTypeProperty1
    {

        private string typeField;

        private string nameField;

        private bool nullableField;

        private bool nullableFieldSpecified;

        private string maxLengthField;

        private bool fixedLengthField;

        private bool fixedLengthFieldSpecified;

        private bool unicodeField;

        private bool unicodeFieldSpecified;

        private byte precisionField;

        private bool precisionFieldSpecified;

        private byte scaleField;

        private bool scaleFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Nullable
        {
            get
            {
                return this.nullableField;
            }
            set
            {
                this.nullableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NullableSpecified
        {
            get
            {
                return this.nullableFieldSpecified;
            }
            set
            {
                this.nullableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaxLength
        {
            get
            {
                return this.maxLengthField;
            }
            set
            {
                this.maxLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FixedLength
        {
            get
            {
                return this.fixedLengthField;
            }
            set
            {
                this.fixedLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FixedLengthSpecified
        {
            get
            {
                return this.fixedLengthFieldSpecified;
            }
            set
            {
                this.fixedLengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Unicode
        {
            get
            {
                return this.unicodeField;
            }
            set
            {
                this.unicodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnicodeSpecified
        {
            get
            {
                return this.unicodeFieldSpecified;
            }
            set
            {
                this.unicodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Precision
        {
            get
            {
                return this.precisionField;
            }
            set
            {
                this.precisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrecisionSpecified
        {
            get
            {
                return this.precisionFieldSpecified;
            }
            set
            {
                this.precisionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleSpecified
        {
            get
            {
                return this.scaleFieldSpecified;
            }
            set
            {
                this.scaleFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaEntityTypeNavigationProperty
    {

        private string nameField;

        private string relationshipField;

        private string fromRoleField;

        private string toRoleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Relationship
        {
            get
            {
                return this.relationshipField;
            }
            set
            {
                this.relationshipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromRole
        {
            get
            {
                return this.fromRoleField;
            }
            set
            {
                this.fromRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ToRole
        {
            get
            {
                return this.toRoleField;
            }
            set
            {
                this.toRoleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaAssociation1
    {

        private SchemaAssociationEnd1[] endField;

        private SchemaAssociationReferentialConstraint1 referentialConstraintField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("End")]
        public SchemaAssociationEnd1[] End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        public SchemaAssociationReferentialConstraint1 ReferentialConstraint
        {
            get
            {
                return this.referentialConstraintField;
            }
            set
            {
                this.referentialConstraintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaAssociationEnd1
    {

        private SchemaAssociationEndOnDelete onDeleteField;

        private string roleField;

        private string typeField;

        private string multiplicityField;

        /// <remarks/>
        public SchemaAssociationEndOnDelete OnDelete
        {
            get
            {
                return this.onDeleteField;
            }
            set
            {
                this.onDeleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Multiplicity
        {
            get
            {
                return this.multiplicityField;
            }
            set
            {
                this.multiplicityField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaAssociationEndOnDelete
    {

        private string actionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaAssociationReferentialConstraint1
    {

        private SchemaAssociationReferentialConstraintPrincipal1 principalField;

        private SchemaAssociationReferentialConstraintDependent1 dependentField;

        /// <remarks/>
        public SchemaAssociationReferentialConstraintPrincipal1 Principal
        {
            get
            {
                return this.principalField;
            }
            set
            {
                this.principalField = value;
            }
        }

        /// <remarks/>
        public SchemaAssociationReferentialConstraintDependent1 Dependent
        {
            get
            {
                return this.dependentField;
            }
            set
            {
                this.dependentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaAssociationReferentialConstraintPrincipal1
    {

        private SchemaAssociationReferentialConstraintPrincipalPropertyRef1 propertyRefField;

        private string roleField;

        /// <remarks/>
        public SchemaAssociationReferentialConstraintPrincipalPropertyRef1 PropertyRef
        {
            get
            {
                return this.propertyRefField;
            }
            set
            {
                this.propertyRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaAssociationReferentialConstraintPrincipalPropertyRef1
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaAssociationReferentialConstraintDependent1
    {

        private SchemaAssociationReferentialConstraintDependentPropertyRef1 propertyRefField;

        private string roleField;

        /// <remarks/>
        public SchemaAssociationReferentialConstraintDependentPropertyRef1 PropertyRef
        {
            get
            {
                return this.propertyRefField;
            }
            set
            {
                this.propertyRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/edm")]
    public partial class SchemaAssociationReferentialConstraintDependentPropertyRef1
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxRuntimeMappings
    {

        private Mapping mappingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
        public Mapping Mapping
        {
            get
            {
                return this.mappingField;
            }
            set
            {
                this.mappingField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs", IsNullable = false)]
    public partial class Mapping
    {

        private MappingEntityContainerMapping entityContainerMappingField;

        private string spaceField;

        /// <remarks/>
        public MappingEntityContainerMapping EntityContainerMapping
        {
            get
            {
                return this.entityContainerMappingField;
            }
            set
            {
                this.entityContainerMappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMapping
    {

        private MappingEntityContainerMappingEntitySetMapping[] entitySetMappingField;

        private MappingEntityContainerMappingFunctionImportMapping[] functionImportMappingField;

        private string storageEntityContainerField;

        private string cdmEntityContainerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntitySetMapping")]
        public MappingEntityContainerMappingEntitySetMapping[] EntitySetMapping
        {
            get
            {
                return this.entitySetMappingField;
            }
            set
            {
                this.entitySetMappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FunctionImportMapping")]
        public MappingEntityContainerMappingFunctionImportMapping[] FunctionImportMapping
        {
            get
            {
                return this.functionImportMappingField;
            }
            set
            {
                this.functionImportMappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StorageEntityContainer
        {
            get
            {
                return this.storageEntityContainerField;
            }
            set
            {
                this.storageEntityContainerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CdmEntityContainer
        {
            get
            {
                return this.cdmEntityContainerField;
            }
            set
            {
                this.cdmEntityContainerField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingEntitySetMapping
    {

        private MappingEntityContainerMappingEntitySetMappingEntityTypeMapping[] entityTypeMappingField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityTypeMapping")]
        public MappingEntityContainerMappingEntitySetMappingEntityTypeMapping[] EntityTypeMapping
        {
            get
            {
                return this.entityTypeMappingField;
            }
            set
            {
                this.entityTypeMappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingEntitySetMappingEntityTypeMapping
    {

        private MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMapping modificationFunctionMappingField;

        private MappingEntityContainerMappingEntitySetMappingEntityTypeMappingMappingFragment mappingFragmentField;

        private string typeNameField;

        /// <remarks/>
        public MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMapping ModificationFunctionMapping
        {
            get
            {
                return this.modificationFunctionMappingField;
            }
            set
            {
                this.modificationFunctionMappingField = value;
            }
        }

        /// <remarks/>
        public MappingEntityContainerMappingEntitySetMappingEntityTypeMappingMappingFragment MappingFragment
        {
            get
            {
                return this.mappingFragmentField;
            }
            set
            {
                this.mappingFragmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TypeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMapping
    {

        private MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingUpdateFunction updateFunctionField;

        private MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingInsertFunction insertFunctionField;

        private MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingDeleteFunction deleteFunctionField;

        /// <remarks/>
        public MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingUpdateFunction UpdateFunction
        {
            get
            {
                return this.updateFunctionField;
            }
            set
            {
                this.updateFunctionField = value;
            }
        }

        /// <remarks/>
        public MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingInsertFunction InsertFunction
        {
            get
            {
                return this.insertFunctionField;
            }
            set
            {
                this.insertFunctionField = value;
            }
        }

        /// <remarks/>
        public MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingDeleteFunction DeleteFunction
        {
            get
            {
                return this.deleteFunctionField;
            }
            set
            {
                this.deleteFunctionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingUpdateFunction
    {

        private MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingUpdateFunctionScalarProperty[] scalarPropertyField;

        private string functionNameField;

        private string rowsAffectedParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScalarProperty")]
        public MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingUpdateFunctionScalarProperty[] ScalarProperty
        {
            get
            {
                return this.scalarPropertyField;
            }
            set
            {
                this.scalarPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FunctionName
        {
            get
            {
                return this.functionNameField;
            }
            set
            {
                this.functionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RowsAffectedParameter
        {
            get
            {
                return this.rowsAffectedParameterField;
            }
            set
            {
                this.rowsAffectedParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingUpdateFunctionScalarProperty
    {

        private string nameField;

        private string parameterNameField;

        private string versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParameterName
        {
            get
            {
                return this.parameterNameField;
            }
            set
            {
                this.parameterNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingInsertFunction
    {

        private MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingInsertFunctionScalarProperty[] scalarPropertyField;

        private string functionNameField;

        private string rowsAffectedParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScalarProperty")]
        public MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingInsertFunctionScalarProperty[] ScalarProperty
        {
            get
            {
                return this.scalarPropertyField;
            }
            set
            {
                this.scalarPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FunctionName
        {
            get
            {
                return this.functionNameField;
            }
            set
            {
                this.functionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RowsAffectedParameter
        {
            get
            {
                return this.rowsAffectedParameterField;
            }
            set
            {
                this.rowsAffectedParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingInsertFunctionScalarProperty
    {

        private string nameField;

        private string parameterNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParameterName
        {
            get
            {
                return this.parameterNameField;
            }
            set
            {
                this.parameterNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingDeleteFunction
    {

        private MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingDeleteFunctionScalarProperty[] scalarPropertyField;

        private string functionNameField;

        private string rowsAffectedParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScalarProperty")]
        public MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingDeleteFunctionScalarProperty[] ScalarProperty
        {
            get
            {
                return this.scalarPropertyField;
            }
            set
            {
                this.scalarPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FunctionName
        {
            get
            {
                return this.functionNameField;
            }
            set
            {
                this.functionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RowsAffectedParameter
        {
            get
            {
                return this.rowsAffectedParameterField;
            }
            set
            {
                this.rowsAffectedParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingEntitySetMappingEntityTypeMappingModificationFunctionMappingDeleteFunctionScalarProperty
    {

        private string nameField;

        private string parameterNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParameterName
        {
            get
            {
                return this.parameterNameField;
            }
            set
            {
                this.parameterNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingEntitySetMappingEntityTypeMappingMappingFragment
    {

        private MappingEntityContainerMappingEntitySetMappingEntityTypeMappingMappingFragmentScalarProperty[] scalarPropertyField;

        private string storeEntitySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScalarProperty")]
        public MappingEntityContainerMappingEntitySetMappingEntityTypeMappingMappingFragmentScalarProperty[] ScalarProperty
        {
            get
            {
                return this.scalarPropertyField;
            }
            set
            {
                this.scalarPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StoreEntitySet
        {
            get
            {
                return this.storeEntitySetField;
            }
            set
            {
                this.storeEntitySetField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingEntitySetMappingEntityTypeMappingMappingFragmentScalarProperty
    {

        private string nameField;

        private string columnNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ColumnName
        {
            get
            {
                return this.columnNameField;
            }
            set
            {
                this.columnNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/09/mapping/cs")]
    public partial class MappingEntityContainerMappingFunctionImportMapping
    {

        private string functionImportNameField;

        private string functionNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FunctionImportName
        {
            get
            {
                return this.functionImportNameField;
            }
            set
            {
                this.functionImportNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FunctionName
        {
            get
            {
                return this.functionNameField;
            }
            set
            {
                this.functionNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxDesigner
    {

        private EdmxDesignerConnection connectionField;

        private EdmxDesignerOptions optionsField;

        private EdmxDesignerDiagrams diagramsField;

        /// <remarks/>
        public EdmxDesignerConnection Connection
        {
            get
            {
                return this.connectionField;
            }
            set
            {
                this.connectionField = value;
            }
        }

        /// <remarks/>
        public EdmxDesignerOptions Options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
            }
        }

        /// <remarks/>
        public EdmxDesignerDiagrams Diagrams
        {
            get
            {
                return this.diagramsField;
            }
            set
            {
                this.diagramsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxDesignerConnection
    {

        private EdmxDesignerConnectionDesignerInfoPropertySet designerInfoPropertySetField;

        /// <remarks/>
        public EdmxDesignerConnectionDesignerInfoPropertySet DesignerInfoPropertySet
        {
            get
            {
                return this.designerInfoPropertySetField;
            }
            set
            {
                this.designerInfoPropertySetField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxDesignerConnectionDesignerInfoPropertySet
    {

        private EdmxDesignerConnectionDesignerInfoPropertySetDesignerProperty designerPropertyField;

        /// <remarks/>
        public EdmxDesignerConnectionDesignerInfoPropertySetDesignerProperty DesignerProperty
        {
            get
            {
                return this.designerPropertyField;
            }
            set
            {
                this.designerPropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxDesignerConnectionDesignerInfoPropertySetDesignerProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxDesignerOptions
    {

        private EdmxDesignerOptionsDesignerProperty[] designerInfoPropertySetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DesignerProperty", IsNullable = false)]
        public EdmxDesignerOptionsDesignerProperty[] DesignerInfoPropertySet
        {
            get
            {
                return this.designerInfoPropertySetField;
            }
            set
            {
                this.designerInfoPropertySetField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxDesignerOptionsDesignerProperty
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxDesignerDiagrams
    {

        private EdmxDesignerDiagramsDiagram diagramField;

        /// <remarks/>
        public EdmxDesignerDiagramsDiagram Diagram
        {
            get
            {
                return this.diagramField;
            }
            set
            {
                this.diagramField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx")]
    public partial class EdmxDesignerDiagramsDiagram
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
}
