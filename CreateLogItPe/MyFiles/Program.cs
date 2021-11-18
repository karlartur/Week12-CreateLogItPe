using System;
using System.IO;
namespace MyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CreateFilesFromMyList(RePlaceNumbers(GetDataFromFile()));
            UpdateMyFiles(RePlaceNumbers(GetDataFromFile()));
        }

        private static string[] GetDataFromFile()
        {
            throw new NotImplementedException();
        }

        private static string[] GetDataFromFile(string filePath)
        {
            string sourceFilePath = $@"C:\Users\opilane\Sample\LogItPe21\MyFiles.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        } 
        private static string[] RePlaceNumbers(string[] sourceArray)
        {
            for(int i = 0; i < sourceArray.Length; i++)
            {
                sourceArray[i] = sourceArray[i].Replace('4', 'a').Replace('3', 'e').Replace('0', 'o').Replace('1', 'i');
                
            }
            return sourceArray;
        }
        private static void CreateFilesFromMyList(string[] arrayOfNames)
        {
            string rootPath = $@"C:\Users\opilane\Sample\LogItPe21";
            for(int i = 0; i < arrayOfNames.Length; i++)
            {
                File.Create($@"{rootPath}\{arrayOfNames[i]}.txt");
            }
        }
        private static void UpdateMyFiles(string[] updatedArray)
        {
            string sourceFilePath = $@"C:\Users\opilane\Sample\LogItPe21\MyFiles.txt";
            File.WriteAllLines(sourceFilePath, updatedArray);
        }

    }
}
