class Program
{
    static void Main(string[] args)
    {
        string directoryPath = @"C:\Users\marko\Desktop\Code-Fix";  // Your directory path
        List<string> txtFiles = new List<string>();

        // Get all .txt files
        GetTxtFiles(directoryPath, txtFiles);

        // Append text to each .txt file
        foreach (var file in txtFiles)
        {
            AppendTextToFile(file, "ASPEKT");
        }
    }

    static void GetTxtFiles(string directoryPath, List<string> txtFiles)
    {
        string[] files = Directory.GetFiles(directoryPath, "*.txt");
        txtFiles.AddRange(files);  // Add found .txt files to the list

        string[] subdirectories = Directory.GetDirectories(directoryPath);
        foreach (string subdirectory in subdirectories)
        {
            GetTxtFiles(subdirectory, txtFiles);
        }
    }

    // Method to append text to a file
    static void AppendTextToFile(string filePath, string textToAppend)
    {
        using (StreamWriter writer = File.AppendText(filePath)) 
        {
            writer.WriteLine(textToAppend);
        }
    }
}
