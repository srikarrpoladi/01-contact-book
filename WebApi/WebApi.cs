﻿< Project Sdk = "Microsoft.NET.Sdk.Web" >

    < PropertyGroup >
        < TargetFramework > net6.0 </ TargetFramework >
        < Nullable > enable </ Nullable >
        < RootNamespace > WebApi </ RootNamespace >
        < GenerateDocumentationFile > true </ GenerateDocumentationFile >
    </ PropertyGroup >

    < ItemGroup >
        < PackageReference Include = "Swashbuckle.AspNetCore" Version = "6.2.3" />
    </ ItemGroup >

    < ItemGroup >
      < ProjectReference Include = "..\Database\Database.csproj" />
    </ ItemGroup >

</ Project >