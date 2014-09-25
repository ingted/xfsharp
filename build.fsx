#r @"packages/FAKE/tools/FakeLib.dll"

open System.IO
open Fake
open Fake.FileSystemHelper
open Fake.FscHelper

let nunitRef = __SOURCE_DIRECTORY__ @@ @"packages\NUnit.Runners\tools\nunit.framework.dll"

let allDirs = 
    DirectoryInfo(__SOURCE_DIRECTORY__).GetDirectories "*"
        |> Array.filter(fun i -> not(i.Name.Contains(".")))
        |> Array.collect(fun d -> filesInDirMatching "*.fs" d)

let exampleFiles = allDirs |> Array.map(fun i -> i.FullName) |> Array.toList

Target "Default" (fun _ ->
    exampleFiles |> Fsc(fun param -> { param with FscTarget = Library
                                                  References = [nunitRef]
                                                  Output = "Example.dll" })
)

RunTargetOrDefault "Default"