

/*
 * This file is auto-generated from a config file.  
 * Do not modify this file.  Modifications will be lost when the file is regenerated.
 */

namespace ConfigurationGenerator.Generator
{    	
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Linq;
	using System.IO;
	using System.Xml;
	using System.Xml.Serialization;
	using ConfigurationGenerator.Watchers;
	using ConfigurationGenerator.Watchers.Abstract;

	public class SettingsXml
	{
		public IFileWatcher FileWatcher { get; set; }

		private bookstore s_defaultInstance = new bookstore();

		public bookstore bookstore
		{
			get { return s_defaultInstance; }
			protected set { s_defaultInstance = value ?? new bookstore(); }
		}

		public SettingsXml(bool watch = false)
		{
			this.FileWatcher = new FileWatcher(watch);
			RefreshConfiguration();
		}

		public void RefreshConfiguration()
		{
			s_defaultInstance = Deserialize();
		}

		private bookstore Deserialize()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(bookstore));
			return (bookstore)serializer.Deserialize(new StringReader(this.FileWatcher.GetXmlSection(@"c:\Users\Shane.Kmiecik\Documents\Visual Studio 2013\Projects\ConfigurationGenerator\ConfigurationGenerator\Bookstore.xml")));
		}
	}
}   
