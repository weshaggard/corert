// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using global::System;
using global::System.Diagnostics;

namespace System.Reflection.Runtime.Dispensers
{
    //
    // A monikor for each reflection cache. The name should follow the style "key" followed by underscore followed by "value".
    //
    internal enum DispenserScenario
    {
        // Type.GetTypeInfo() for Runtime types.
        Type_TypeInfo,

        // Metadata typedef handle to RuntimeTypeInfo
        TypeDef_TypeInfo,

        // TypeInfo + Name to EventInfo
        TypeInfoAndName_EventInfo,

        // TypeInfo + Name to FieldInfo
        TypeInfoAndName_FieldInfo,

        // TypeInfo + Name to MethodInfo
        TypeInfoAndName_MethodInfo,

        // TypeInfo + Name to PropertyInfo
        TypeInfoAndName_PropertyInfo,

        // Assembly + NamespaceTypeName to Type
        AssemblyAndNamespaceTypeName_Type,

        // Assembly refName to Assembly
        AssemblyRefName_Assembly,

        // RuntimeAssembly to CaseInsensitiveTypeDictionary
        RuntimeAssembly_CaseInsensitiveTypeDictionary,

        // Scope definition handle to RuntimeAssembly
        Scope_Assembly,
    }
}

