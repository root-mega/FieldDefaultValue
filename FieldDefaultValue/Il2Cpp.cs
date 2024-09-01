using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldDefaultValue
{
    public class Il2Cpp
    {
        public struct Il2CppGlobalMetadataHeader
        {
            public int Sanity { get; set; }
            public int Version { get; set; }
            public int StringLiteralOffset { get; set; } // string data for managed code
            public int StringLiteralCount { get; set; }
            public int StringLiteralDataOffset { get; set; }
            public int StringLiteralDataCount { get; set; }
            public int StringOffset { get; set; } // string data for metadata
            public int StringCount { get; set; }
            public int EventsOffset { get; set; } // Il2CppEventDefinition
            public int EventsCount { get; set; }
            public int PropertiesOffset { get; set; } // Il2CppPropertyDefinition
            public int PropertiesCount { get; set; }
            public int MethodsOffset { get; set; } // Il2CppMethodDefinition
            public int MethodsCount { get; set; }
            public int ParameterDefaultValuesOffset { get; set; } // Il2CppParameterDefaultValue
            public int ParameterDefaultValuesCount { get; set; }
            public int FieldDefaultValuesOffset { get; set; } // Il2CppFieldDefaultValue
            public int fieldDefaultValuesCount { get; set; }
            public int FieldAndParameterDefaultValueDataOffset { get; set; } // uint8_t
            public int FieldAndParameterDefaultValueDataCount { get; set; }
            public int FieldMarshaledSizesOffset { get; set; } // Il2CppFieldMarshaledSize
            public int FieldMarshaledSizesCount { get; set; }
            public int ParametersOffset { get; set; } // Il2CppParameterDefinition
            public int ParametersCount { get; set; }
            public int FieldsOffset { get; set; } // Il2CppFieldDefinition
            public int FieldsCount { get; set; }
            public int GenericParametersOffset { get; set; } // Il2CppGenericParameter
            public int GenericParametersCount { get; set; }
            public int GenericParameterConstraintsOffset { get; set; } // TypeIndex
            public int GenericParameterConstraintsCount { get; set; }
            public int GenericContainersOffset { get; set; } // Il2CppGenericContainer
            public int GenericContainersCount { get; set; }
            public int NestedTypesOffset { get; set; } // TypeDefinitionIndex
            public int NestedTypesCount { get; set; }
            public int InterfacesOffset { get; set; } // TypeIndex
            public int InterfacesCount { get; set; }
            public int VtableMethodsOffset { get; set; } // EncodedMethodIndex
            public int VtableMethodsCount { get; set; }
            public int InterfaceOffsetsOffset { get; set; } // Il2CppInterfaceOffsetPair
            public int InterfaceOffsetsCount { get; set; }
            public int TypeDefinitionsOffset { get; set; } // Il2CppTypeDefinition
            public int TypeDefinitionsCount { get; set; }
            public int RgctxEntriesOffset { get; set; } // Il2CppRGCTXDefinition
            public int RgctxEntriesCount { get; set; }
            public int ImagesOffset { get; set; } // Il2CppImageDefinition
            public int ImagesCount { get; set; }
            public int AssembliesOffset { get; set; } // Il2CppAssemblyDefinition
            public int AssembliesCount { get; set; }
            public int MetadataUsageListsOffset { get; set; } // Il2CppMetadataUsageList
            public int MetadataUsageListsCount { get; set; }
            public int MetadataUsagePairsOffset { get; set; } // Il2CppMetadataUsagePair
            public int MetadataUsagePairsCount { get; set; }
            public int FieldRefsOffset { get; set; } // Il2CppFieldRef
            public int FieldRefsCount { get; set; }
        }
        public struct Il2CppFieldDefaultValue
        {
            public int FieldIndex { get; set; }
            public int TypeIndex { get; set; }
            public int DefaultValueDataIndex { get; set; }
        }
    }
}
