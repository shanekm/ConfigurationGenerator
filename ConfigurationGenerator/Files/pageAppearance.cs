namespace ConfigurationGenerator.Generator {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="true")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="true", IsNullable=false)]
    public class pageAppearance {
        
        private pageAppearanceFont fontField;
        
        private pageAppearanceColor colorField;
        
        private bool remoteOnlyField;
        
        /// <remarks/>
        public pageAppearanceFont font {
            get {
                return this.fontField;
            }
            set {
                this.fontField = value;
            }
        }
        
        /// <remarks/>
        public pageAppearanceColor color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool remoteOnly {
            get {
                return this.remoteOnlyField;
            }
            set {
                this.remoteOnlyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="true")]
    public class pageAppearanceFont {
        
        private string nameField;
        
        private byte sizeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="true")]
    public class pageAppearanceColor {
        
        private byte backgroundField;
        
        private string foregroundField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte background {
            get {
                return this.backgroundField;
            }
            set {
                this.backgroundField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string foreground {
            get {
                return this.foregroundField;
            }
            set {
                this.foregroundField = value;
            }
        }
    }
}

