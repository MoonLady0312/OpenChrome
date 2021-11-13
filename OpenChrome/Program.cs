using System.Diagnostics;
using ConfigReadingLib;

// Chrome Icon  Artist: firstfear(firstfear.deviantart.com)

try
{
    var reader = new ConfigReader("Path.txt");
    var programpath = reader.GetValue("program path");
    var instancepath = reader.GetValue("instance path");
    Process.Start(programpath, $"--user-data-dir=\"{instancepath}\"");
}
catch { }