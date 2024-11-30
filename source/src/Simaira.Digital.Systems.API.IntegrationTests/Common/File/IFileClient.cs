namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using System.IO;
    using System.Threading.Tasks;

    public interface IFileClient
    {
        Task DownloadFileAsync(string path, string dest);

        void MoveDirectoryWithOverride(string from, string to);

        void DeleteDirectoryIfExists(string name);

        void DeleteFileIfExists(string name);

        void CopyAll(DirectoryInfo source, DirectoryInfo target);

        string ValidateJsonFile(string pathToJsonFile, string schemaName);

        string LoadFromManifestResourceStream(string fullyQualifiedResourceName);
    }
}
