// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Working with file information

// Make sure the example file exists
const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file
Console.WriteLine(File.GetLastWriteTime(filename));

// TODO: We can also get general information using a FileInfo 
Console.WriteLine(File.GetLastWriteTime(filename));

// TODO: File information can also be manipulated
Console.WriteLine(File.GetLastAccessTime(filename));

try
{
    FileInfo fi = new FileInfo;
    Console.WriteLine($"{fi.Length}");
}
catch (Exception e)
{
    Console.Exception(${Exception: "e"});
}

DateTime dt;
File.SetCreationTime(filename);