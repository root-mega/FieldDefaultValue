using FieldDefaultValue;
using System;
using System.Runtime.InteropServices;
using static FieldDefaultValue.Il2Cpp;

public class Program
{
    static Il2CppGlobalMetadataHeader ReadHeader(string filePath)
    {
        Il2CppGlobalMetadataHeader header = new Il2CppGlobalMetadataHeader();

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            header.Sanity = reader.ReadInt32();
            header.Version = reader.ReadInt32();
            header.StringLiteralOffset = reader.ReadInt32();
            header.StringLiteralCount = reader.ReadInt32();
            header.StringLiteralDataOffset = reader.ReadInt32();
            header.StringLiteralDataCount = reader.ReadInt32();
            header.StringOffset = reader.ReadInt32();
            header.StringCount = reader.ReadInt32();
            header.EventsOffset = reader.ReadInt32();
            header.EventsCount = reader.ReadInt32();
            header.PropertiesOffset = reader.ReadInt32();
            header.PropertiesCount = reader.ReadInt32();
            header.MethodsOffset = reader.ReadInt32();
            header.MethodsCount = reader.ReadInt32();
            header.ParameterDefaultValuesOffset = reader.ReadInt32();
            header.ParameterDefaultValuesCount = reader.ReadInt32();
            header.FieldDefaultValuesOffset = reader.ReadInt32();
            header.fieldDefaultValuesCount = reader.ReadInt32();
            header.FieldAndParameterDefaultValueDataOffset = reader.ReadInt32();
            header.FieldAndParameterDefaultValueDataCount = reader.ReadInt32();
            header.FieldMarshaledSizesOffset = reader.ReadInt32();
            header.FieldMarshaledSizesCount = reader.ReadInt32();
            header.ParametersOffset = reader.ReadInt32();
            header.ParametersCount = reader.ReadInt32();
            header.FieldsOffset = reader.ReadInt32();
            header.FieldsCount = reader.ReadInt32();
            header.GenericParametersOffset = reader.ReadInt32();
            header.GenericParametersCount = reader.ReadInt32();
            header.GenericParameterConstraintsOffset = reader.ReadInt32();
            header.GenericParameterConstraintsCount = reader.ReadInt32();
            header.GenericContainersOffset = reader.ReadInt32();
            header.GenericContainersCount = reader.ReadInt32();
            header.NestedTypesOffset = reader.ReadInt32();
            header.NestedTypesCount = reader.ReadInt32();
            header.InterfacesOffset = reader.ReadInt32();
            header.InterfacesCount = reader.ReadInt32();
            header.VtableMethodsOffset = reader.ReadInt32();
            header.VtableMethodsCount = reader.ReadInt32();
            header.InterfaceOffsetsOffset = reader.ReadInt32();
            header.InterfaceOffsetsCount = reader.ReadInt32();
            header.TypeDefinitionsOffset = reader.ReadInt32();
            header.TypeDefinitionsCount = reader.ReadInt32();
            header.RgctxEntriesOffset = reader.ReadInt32();
            header.RgctxEntriesCount = reader.ReadInt32();
            header.ImagesOffset = reader.ReadInt32();
            header.ImagesCount = reader.ReadInt32();
            header.AssembliesOffset = reader.ReadInt32();
            header.AssembliesCount = reader.ReadInt32();
            header.MetadataUsageListsOffset = reader.ReadInt32();
            header.MetadataUsageListsCount = reader.ReadInt32();
            header.MetadataUsagePairsOffset = reader.ReadInt32();
            header.MetadataUsagePairsCount = reader.ReadInt32();
            header.FieldRefsOffset = reader.ReadInt32();
            header.FieldRefsCount = reader.ReadInt32();

            fs.Close();
        }
        return header;
    }

    static void Main(string[] args)
    {
        Il2CppGlobalMetadataHeader header = ReadHeader("./global-metadata.dat");

        int structSize = Marshal.SizeOf<Il2CppFieldDefaultValue>();
        int metadata_array_field_default_val_size = 0;

        Il2CppFieldDefaultValue[] fieldDefaultValues = new Il2CppFieldDefaultValue[header.fieldDefaultValuesCount];

        Console.WriteLine("Assuming global-metadata.dat is at the application cwd.");

        Console.WriteLine($"FieldDefaultValuesOffset: {header.FieldDefaultValuesOffset}");
        Console.WriteLine($"header.fieldDefaultValuesCount: {header.fieldDefaultValuesCount}");
        Console.WriteLine($"Calculating size of FieldDefaultValuesOffset...");
        metadata_array_field_default_val_size = header.fieldDefaultValuesCount * 12;
        Console.WriteLine($"Size: {metadata_array_field_default_val_size}");

        using (FileStream fs = new FileStream("global-metadata.dat", FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            fs.Seek(header.FieldDefaultValuesOffset, SeekOrigin.Begin);

            for (int i = 0; i < header.fieldDefaultValuesCount; i++)
            {
                fieldDefaultValues[i] = new Il2CppFieldDefaultValue
                {
                    FieldIndex = reader.ReadInt32(),
                    TypeIndex = reader.ReadInt32(),
                    DefaultValueDataIndex = reader.ReadInt32()
                };
            }
        }

        Console.WriteLine($"Successfully retrieved {fieldDefaultValues.Length} default values!");
        Console.WriteLine($"Input your FieldIndex value!");
        int field_idx_to_search = Convert.ToInt32(Console.ReadLine());

        Il2CppFieldDefaultValue result = Array.Find(fieldDefaultValues, f => f.FieldIndex == field_idx_to_search);

        Console.WriteLine($"Default value is at {result.DefaultValueDataIndex + header.FieldDefaultValuesOffset}");
    }
}