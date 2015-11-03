using System;
using System.Collections.Generic;

namespace ConfigurationGenerator.Watchers.Abstract
{
    public interface IDatabaseWatcher
    {
        Dictionary<string, string> Collection { get; }

        event EventHandler<EventArgs> SettingsChanged;
    }
}