

/*
 * This file is auto-generated from a config file.  
 * Do not modify this file.  Modifications will be lost when the file is regenerated.
 */
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using ConfigurationGenerator.Watchers;
using ConfigurationGenerator.Watchers.Abstract;

namespace ConfigurationGenerator.Generator
{    	
	public class SettingsAppConfig
	{	
		public IFileWatcher FileWatcher { get; set; }

		public Dictionary<string, string> CurrentConfigurationCollection { get; private set; }


		private bookstore s_defaultInstancebookstore = new bookstore();

		public bookstore bookstore
		{
			get { return s_defaultInstancebookstore; }
			protected set { s_defaultInstancebookstore = value ?? new bookstore(); }
		}

		private pageAppearance s_defaultInstancepageAppearance = new pageAppearance();

		public pageAppearance pageAppearance
		{
			get { return s_defaultInstancepageAppearance; }
			protected set { s_defaultInstancepageAppearance = value ?? new pageAppearance(); }
		}

		private secureSettings s_defaultInstancesecureSettings = new secureSettings();

		public secureSettings secureSettings
		{
			get { return s_defaultInstancesecureSettings; }
			protected set { s_defaultInstancesecureSettings = value ?? new secureSettings(); }
		}


		public SettingsAppConfig(bool watch = false)
		{
			this.FileWatcher = new FileWatcher(watch);

			this.CurrentConfigurationCollection = new Dictionary<string, string>();
			RefreshConfiguration();
		}

		public void RefreshConfiguration()
		{
			ConfigurationManager.RefreshSection("appSettings");

			IntValue = Int32.Parse(GetConfigSetting("IntValue"), CultureInfo.InvariantCulture);
			StringValue = (GetConfigSetting("StringValue"));
			DoubleValue = Double.Parse(GetConfigSetting("DoubleValue"), CultureInfo.InvariantCulture);
			BoolValue = Boolean.Parse(GetConfigSetting("BoolValue"));
			LongValue = Int64.Parse(GetConfigSetting("LongValue"), CultureInfo.InvariantCulture);
			DateTimeValue = DateTime.Parse(GetConfigSetting("DateTimeValue"), CultureInfo.InvariantCulture);
			DateValue = DateTime.Parse(GetConfigSetting("DateValue"), CultureInfo.InvariantCulture);
			MyTestValue = Int32.Parse(GetConfigSetting("MyTestValue"), CultureInfo.InvariantCulture);
			StringValueTest = (GetConfigSetting("StringValueTest"));
			s_defaultInstancebookstore = Deserializebookstore();
			s_defaultInstancepageAppearance = DeserializepageAppearance();
			s_defaultInstancesecureSettings = DeserializesecureSettings();

		}


        public int IntValue
        {
            get; private set;
        }

        public string StringValue
        {
            get; private set;
        }

        public double DoubleValue
        {
            get; private set;
        }

        public bool BoolValue
        {
            get; private set;
        }

        public long LongValue
        {
            get; private set;
        }

        public System.DateTime DateTimeValue
        {
            get; private set;
        }

        public System.DateTime DateValue
        {
            get; private set;
        }

        public int MyTestValue
        {
            get; private set;
        }

        public string StringValueTest
        {
            get; private set;
        }
        protected virtual string GetConfigSetting(string settingName)
		{
            string setting = ConfigurationManager.AppSettings[settingName];
            string value = "";
            this.CurrentConfigurationCollection.TryGetValue(settingName, out value);

            // new dict item?
            if (string.IsNullOrEmpty(value))
            {
                this.CurrentConfigurationCollection.Add(settingName, setting);
            }
            else
            {
                // value exists in dict - update it
                if (!value.Equals(setting, StringComparison.InvariantCultureIgnoreCase))
                {
                    this.CurrentConfigurationCollection[settingName] = setting;
                }
            }

			return setting ?? "";
		}	
				

		private bookstore Deserializebookstore()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(bookstore));
			return (bookstore)serializer.Deserialize(new StringReader(this.FileWatcher.GetXmlSection("bookstoreGroup")));
		}

		private pageAppearance DeserializepageAppearance()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(pageAppearance));
			return (pageAppearance)serializer.Deserialize(new StringReader(this.FileWatcher.GetXmlSection("pageAppearanceGroup")));
		}

		private secureSettings DeserializesecureSettings()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(secureSettings));
			return (secureSettings)serializer.Deserialize(new StringReader(this.FileWatcher.GetXmlSection("secureAppSettings")));
		}
			
	}
}   
