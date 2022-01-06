using System.Diagnostics;
using BearMLLib;

// Chrome Icon  Artist: firstfear(firstfear.deviantart.com)

var reader = new BearML("path.txt");
var programPath = reader.GetContent<string>("program");
var instancePath = reader.GetContent<string>("instance");
Process.Start(programPath, $"--user-data-dir=\"{instancePath}\"");