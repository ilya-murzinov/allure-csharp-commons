﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17929
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 

using System.Xml.Serialization;

namespace AllureCSharpCommons.AbstractEvents {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(TypeName="abstract-test-suite-started-event", Namespace="urn:events.allure.qatools.yandex.ru")]
    [XmlRoot("test-suite-started-event", Namespace="urn:events.allure.qatools.yandex.ru", IsNullable=false)]
    public abstract partial class abstracttestsuitestartedevent {
        
        private string uidField;
        
        private string nameField;
        
        private string titleField;
        
        private description descriptionField;
        
        private label[] labelsField;
        
        /// <remarks/>
        [XmlElement(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string uid {
            get {
                return this.uidField;
            }
            set {
                this.uidField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [XmlElement(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public description description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [XmlArray(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlArrayItem(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public label[] labels {
            get {
                return this.labelsField;
            }
            set {
                this.labelsField = value;
            }
        }
    }
}