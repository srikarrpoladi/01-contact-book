﻿<Project Sdk="Microsoft.NET.Sdk">

    < PropertyGroup >
        < TargetFramework > net6.0 </ TargetFramework >
        < ImplicitUsings > enable </ ImplicitUsings >
        < Nullable > enable </ Nullable >
    </ PropertyGroup >

    < ItemGroup >
      < PackageReference Include = "Microsoft.EntityFrameworkCore" Version = "6.0.10" />
      < PackageReference Include = "Microsoft.EntityFrameworkCore.InMemory" Version = "6.0.10" />
    </ ItemGroup >

</ Project >