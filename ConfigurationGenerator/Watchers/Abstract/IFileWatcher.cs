using System;

namespace ConfigurationGenerator.Watchers.Abstract
{
    public interface IFileWatcher
    {
        event EventHandler<EventArgs> SettingsChanged;

        string GetXmlSection(string section);
    }
}