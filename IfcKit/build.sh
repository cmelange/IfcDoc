#!/bin/bash
dotnet pack ./schemas/BuildingSmart.IFC.csproj -c Release --include-symbols -o ../nupkgs
dotnet pack ./formats/BuildingSmart.Serialization/BuildingSmart.Serialization.csproj -c Release --include-symbols -o ../../nupkgs
dotnet pack ./formats/json/BuildingSmart.Serialization.Json.csproj -c Release --include-symbols -o ../../nupkgs
dotnet pack ./formats/xml/BuildingSmart.Serialization.Xml.csproj -c Release --include-symbols -o ../../nupkgs
dotnet pack ./utilities/BuildingSmart.Utilities.Conversion/BuildingSmart.Utilities.Conversion.csproj -c Release --include-symbols -o ../../nupkgs