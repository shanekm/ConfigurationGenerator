namespace ConfigurationGenerator.Generator {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.contoso.com/books")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.contoso.com/books", IsNullable=false)]
    public class bookstore {
        
        private bookstoreBook[] bookField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("book")]
        public bookstoreBook[] book {
            get {
                return this.bookField;
            }
            set {
                this.bookField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.contoso.com/books")]
    public class bookstoreBook {
        
        private string titleField;
        
        private bookstoreBookAuthor authorField;
        
        private decimal priceField;
        
        private string genreField;
        
        private System.DateTime publicationdateField;
        
        private string iSBNField;
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public bookstoreBookAuthor author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }
        
        /// <remarks/>
        public decimal price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string genre {
            get {
                return this.genreField;
            }
            set {
                this.genreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="date")]
        public System.DateTime publicationdate {
            get {
                return this.publicationdateField;
            }
            set {
                this.publicationdateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ISBN {
            get {
                return this.iSBNField;
            }
            set {
                this.iSBNField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.contoso.com/books")]
    public class bookstoreBookAuthor {
        
        private string firstnameField;
        
        private string lastnameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("first-name")]
        public string firstname {
            get {
                return this.firstnameField;
            }
            set {
                this.firstnameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("last-name")]
        public string lastname {
            get {
                return this.lastnameField;
            }
            set {
                this.lastnameField = value;
            }
        }
    }
}

