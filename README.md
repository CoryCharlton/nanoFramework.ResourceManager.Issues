# nanoFramework.ResourceManager.Issues

This is a quick set of projects to reproduce several issues relates to `nanoFramework.ResourceManager` and the resource generator. All of these issues are only reproducible when there are multiple resource files in the same application.

It was suggested in Discord that there is perhaps an unenforced requirement of only having a single resource file per project. If this is the case then these could potentially be solved by having the build task detect multiple resource files and throwing a clear error that explains the limitation.

## DuplicateResourceKeys

This application will not build as the resource keys from multiple resource files are added to the same dictionary and a duplicate key exception is thrown.

```
Build started...
1>------ Build started: Project: DuplicateResourceKeys, Configuration: Debug Any CPU ------
1>C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\nanoFramework\v1.0\NFProjectSystem.MDP.targets(230,5): error : Unable to compile output assembly file 'C:\src\temp\nanoFramework.ResourceManager.Issues\DuplicateResourceKeys\obj\Debug\DuplicateResourceKeys.pe' - check parse command results.
1>C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\nanoFramework\v1.0\NFProjectSystem.MDP.targets(230,5): error : An entry with the same key already exists.
1>C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\nanoFramework\v1.0\NFProjectSystem.MDP.targets(230,5): error :    at System.ThrowHelper.ThrowArgumentException(ExceptionResource resource)
1>C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\nanoFramework\v1.0\NFProjectSystem.MDP.targets(230,5): error :    at System.Collections.Generic.TreeSet`1.AddIfNotPresent(T item)
1>C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\nanoFramework\v1.0\NFProjectSystem.MDP.targets(230,5): error :    at System.Collections.Generic.SortedDictionary`2.Add(TKey key, TValue value)
1>C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\nanoFramework\v1.0\NFProjectSystem.MDP.targets(230,5): error :    at nanoFramework.Tools.MetadataProcessor.nanoResourcesTable.Write(nanoBinaryWriter writer)
1>C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\nanoFramework\v1.0\NFProjectSystem.MDP.targets(230,5): error :    at nanoFramework.Tools.MetadataProcessor.nanoAssemblyBuilder.Write(nanoBinaryWriter binaryWriter)
1>C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\nanoFramework\v1.0\NFProjectSystem.MDP.targets(230,5): error :    at nanoFramework.Tools.MetadataProcessor.MsBuildTask.MetaDataProcessorTask.ExecuteCompile(String fileName)
1>C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\nanoFramework\v1.0\NFProjectSystem.MDP.targets(230,5): error :    at nanoFramework.Tools.MetadataProcessor.MsBuildTask.MetaDataProcessorTask.Execute()
1>Done building project "DuplicateResourceKeys.nfproj" -- FAILED.
========== Build: 0 succeeded, 1 failed, 0 up-to-date, 0 skipped ==========
========== Build started at 11:50 AM and took 00.296 seconds ==========
```

## PositiveResourceIds

This application fails to load resources that have been assigned positive resource ids when there are multiple resource files. Positive ids work when there is only a single resource file as demonstrated in `SingleResourceFile`

```
    ++++ Exception System.ArgumentException - 0x00000000 (1) ++++
    ++++ Message: 
    ++++ System.Resources.ResourceManager::GetObjectFromId [IP: 004e] ++++
    ++++ nanoFramework.Runtime.Native.ResourceUtility::GetObject [IP: 0000] ++++
    ++++ PositiveResourceIds.Resource2::GetString [IP: 000b] ++++
    ++++ PositiveResourceIds.Program::Main [IP: 001d] ++++
Exception thrown: 'System.ArgumentException' in nanoFramework.ResourceManager.dll
```

## SingleResourceFile

This application uses the same resource ids as the `PositiveResourceIds` but demonstrates how the problem does not exist when there is only a single resource file