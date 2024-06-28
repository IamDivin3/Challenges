using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = @"C:\Users\PC\Documents\Application Programming\Start\Files\Challenge\FileCollection";
        const string filename = "results.txt" ;
        string resultsFile = Path.Combine(directoryPath, filename);

        bool IsOfficeFile(string fileName) =>
            fileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase) ||
            fileName.EndsWith(".docx", StringComparison.OrdinalIgnoreCase) ||
            fileName.EndsWith(".pptx", StringComparison.OrdinalIgnoreCase);

        try
        {
            
            int excelCount = 0, wordCount = 0, powerpointCount = 0;
            long excelSize = 0, wordSize = 0, powerpointSize = 0;
            int totalOfficeFiles = 0;
            long totalSize = 0;

           
            DirectoryInfo directory = new DirectoryInfo(directoryPath);
            FileInfo[] files = directory.GetFiles();

            foreach (var file in files)
            {
                if (IsOfficeFile(file.Name))
                {
                    totalOfficeFiles++;
                    totalSize += file.Length;

                    // Count and sum based on file type
                    switch (file.Extension.ToLower())
                    {
                        case ".xlsx":
                            excelCount++;
                            excelSize += file.Length;
                            break;
                        case ".docx":
                            wordCount++;
                            wordSize += file.Length;
                            break;
                        case ".pptx":
                            powerpointCount++;
                            powerpointSize += file.Length;
                            break;
                        default:
                            break;
                    }
                }
            }

           
            using (StreamWriter writer = new StreamWriter(resultsFile))
            {
                writer.WriteLine($"Summary of Microsoft Office Files in Directory: {directoryPath}");
                writer.WriteLine("-----------------------------------------------");
                writer.WriteLine($"Excel files (.xlsx): {excelCount}, Total Size: {excelSize} bytes");
                writer.WriteLine($"Word files (.docx): {wordCount}, Total Size: {wordSize} bytes");
                writer.WriteLine($"PowerPoint files (.pptx): {powerpointCount}, Total Size: {powerpointSize} bytes");
                writer.WriteLine("-----------------------------------------------");
                writer.WriteLine($"Total Office Files: {totalOfficeFiles}, Total Size: {totalSize} bytes");
            }

            Console.WriteLine("Summary written to results.txt successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}
