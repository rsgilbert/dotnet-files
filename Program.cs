using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;


// IEnumerable<string> FindFiles(string folderName)
// {
//     List<string> salesFiles = new List<string>();
//     var foundFiles = Directory.EnumerateFiles(folderName, "sales.json", SearchOption.AllDirectories);
//     salesFiles.AddRange(foundFiles);
//     //Console.WriteLine(salesFiles.ToArray().Length);
//     return foundFiles;
// }


// foreach(var f in FindFiles("stores"))
// {
//     Console.WriteLine(f);
// }

// Console.WriteLine(Directory.GetCurrentDirectory());
// Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
// Console.WriteLine(Path.Combine("james", "bond"));

// Console.WriteLine(Path.GetExtension("makerere.sch"));
// FileInfo info = new FileInfo(Path.Join("stores", "201", "sales.json"));
// Console.WriteLine($"{info.FullName} {Environment.NewLine} {info.Attributes} {info.CreationTime} {info.DirectoryName}");


string content = File.ReadAllText(Path.Join("stores", "202", "salestotals.json"));
// Console.WriteLine(content);

var salesData = JsonConvert.DeserializeObject<SalesTotals>(content);

Console.WriteLine(salesData);
Console.WriteLine(salesData?.OverallTotal);

class SalesTotals 
{
    public double OverallTotal { get; set; }
}



