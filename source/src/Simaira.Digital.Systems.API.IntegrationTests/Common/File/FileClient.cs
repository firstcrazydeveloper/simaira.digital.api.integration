namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json.Schema;

    public class FileClient : IFileClient
    {
        public async Task DownloadFileAsync(string path, string dest)
        {
            using (var myWebClient = new WebClient())
            {
                await myWebClient.DownloadFileTaskAsync(new Uri(path), dest);
            }
        }

        public void MoveDirectoryWithOverride(string from, string to)
        {
            this.DeleteDirectoryIfExists(to);
            Directory.Move(from, to);
        }

        public void DeleteDirectoryIfExists(string name)
        {
            if (Directory.Exists(name))
            {
                Directory.Delete(name, true);
            }
        }

        public void DeleteFileIfExists(string name)
        {
            if (File.Exists(name))
            {
                File.Delete(name);
            }
        }

        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }

            if (!Directory.Exists(target.FullName))
            {
                Directory.CreateDirectory(target.FullName);
            }

            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        public string LoadFromManifestResourceStream(string fullyQualifiedResourceName)
        {
            using var stream = typeof(FileClient).Assembly.GetManifestResourceStream(fullyQualifiedResourceName);
            using var reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        public string ValidateJsonFile(string pathToJsonFile, string schemaName)
        {
            var configJson = default(string);

            using (var reader = new StreamReader(pathToJsonFile))
            {
                configJson = reader.ReadToEnd();
            }

            var assembly = typeof(FileClient).Assembly;
            var jschema = default(JSchema);
            var jobject = default(JObject);

            var stream = assembly.GetManifestResourceStream(schemaName);

            using (var reader = new StreamReader(stream))
            {
                string schemaText = reader.ReadToEnd();
                jschema = JSchema.Parse(schemaText);
                jobject = JObject.Parse(configJson);
            }

            var validtationErrors = new List<ValidationError>();

            void OnValidatinEvent(object sender, SchemaValidationEventArgs eventArgs)
            {
                validtationErrors.Add(eventArgs.ValidationError);
            }

            jobject.Validate(jschema, new SchemaValidationEventHandler(OnValidatinEvent));

            if (validtationErrors.Count > 0)
            {
                validtationErrors = validtationErrors.OrderBy(error => error.LineNumber).ThenBy(error => error.LinePosition).ToList();

                var builder = new StringBuilder();
                builder.AppendLine($"Json validation error for {pathToJsonFile}, validating agaisnt schema {schemaName}.");

                foreach (var error in validtationErrors)
                {
                    builder.AppendLine($"Line {error.LineNumber} Pos {error.LinePosition}: {error.Message}");
                }

                throw new Exception(builder.ToString());
            }

            return configJson;
        }
    }
}
