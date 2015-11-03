using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using ConfigurationGenerator.Watchers.Abstract;

namespace ConfigurationGenerator.Watchers
{
    public class FileWatcher : IFileWatcher
    {
        private FileSystemWatcher watcher;

        private XDocument xmlDocument;

        public FileWatcher(bool start)
        {
            if (!start)
            {
                return;
            }

            this.RegisterForChanges();
        }

        public event EventHandler<EventArgs> SettingsChanged;

        public string GetXmlSection(string path)
        {
            string xmlString;
            if (!File.Exists(path))
            {
                this.xmlDocument = XDocument.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                xmlString =
                    this.xmlDocument.Root.Elements(path).FirstOrDefault().Descendants().FirstOrDefault().ToString();
            }
            else
            {
                this.xmlDocument = XDocument.Load(path);
                xmlString = this.xmlDocument.ToString();
            }

            return xmlString;
        }

        public void OnChanged(object source, EventArgs e)
        {
            if (this.SettingsChanged != null)
            {
                this.SettingsChanged(source, new EventArgs());
            }
        }

        private void RegisterForChanges()
        {
            // Get executing assembly parent location
            var execAssemblyPath = Assembly.GetExecutingAssembly().Location;
            string directory = Directory.GetParent(execAssemblyPath).FullName;
            string path = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            string fileName = Path.GetFileName(path);

            // Create file system watcher
            this.watcher = new FileSystemWatcher
                               {
                                   Path = directory, 
                                   NotifyFilter =
                                       NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                       | NotifyFilters.FileName | NotifyFilters.DirectoryName, 
                                   Filter = fileName
                               };

            // Add event handlers.
            this.watcher.Changed += this.OnChanged;

            // Begin watching.
            this.watcher.EnableRaisingEvents = true;
        }
    }
}