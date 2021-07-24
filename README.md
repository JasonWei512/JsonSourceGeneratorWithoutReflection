.Net 6's [json source generator](https://devblogs.microsoft.com/dotnet/try-the-new-system-text-json-source-generator/) doesn't work with [native AOT](https://github.com/dotnet/runtimelab/tree/feature/NativeAOT) if reflection is disabled.

1. If you run this project with ```dotnet run```, then it will print ```{"Id":1,"Name":"Nishikori Kei"}```.

2. If you publish this project with ```dotnet publish -r win-x64 -c release```, and run ```bin\release\net6.0\win-x64\publish\JsonSourceGeneratorWithoutReflection.exe```, then nothing will be printed.

3. If you set ```IlcDisableReflection``` in ```JsonSourceGeneratorWithoutReflection.csproj``` to ```false```, and redo step 2, then it will print the serialized json string again.