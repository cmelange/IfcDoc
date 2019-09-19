#!/bin/bash
dotnet pack ./schemas/BuildingSmart.IFC.csproj -c Release --include-symbols -o ../nupkgs
dotnet pack ./formats/json/BuildingSmart.Serialization.Json.csproj -c Release --include-symbols -o ../../nupkgs