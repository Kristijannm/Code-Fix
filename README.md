# File Handling Program

This program is designed to search for `.txt` files within a given directory and its subdirectories, and append a specified text to each of those files. The code has been improved to handle subdirectories, properly manage resources, and enhance consistency.

## Changes Made

The following improvements were made to the original code to enhance its functionality.

### 1. **Directory Traversal Fix**
   **Issue:** The original code only traversed the top-level directory and failed to handle subdirectories.
   
   **Solution:** The directory traversal was updated to ensure that all subdirectories are scanned for `.txt` files.
   
   **Old Code:**
   ```csharp
   GetTxtFiles(directoryPath, txtFiles);
```
**New Code**
```csharp
GetTxtFiles(subdirectory, txtFiles);
```
### **2. Correct Resource Disposal (StreamWriter)**
   **Old Code:**
   ```csharp
StreamWriter writer = null;
writer = File.AppendText(filePath);
writer.WriteLine(textToAppend);
```
**New Code**
   ```csharp
using (StreamWriter writer = File.AppendText(filePath))
{
    writer.WriteLine(textToAppend);
}
```
### **3. Method Name Consistency**
   **Old Code:**
   ```csharp
static void AppendTextToFiles(string filePath, string textToAppend)
```
**New Code**
   ```csharp
static void AppendTextToFile(string filePath, string textToAppend)
```

