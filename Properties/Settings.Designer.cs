﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelefonRehberi.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=KOD;Initial Catalog=TelefonRehberi;Integrated Security=True")]
        public string TelefonRehberiConnectionString {
            get {
                return ((string)(this["TelefonRehberiConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public global::MetroFramework.MetroColorStyle StyleManegerSet {
            get {
                return ((global::MetroFramework.MetroColorStyle)(this["StyleManegerSet"]));
            }
            set {
                this["StyleManegerSet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int CmbBoxRenk {
            get {
                return ((int)(this["CmbBoxRenk"]));
            }
            set {
                this["CmbBoxRenk"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool T_DuzenEtkinlestir {
            get {
                return ((bool)(this["T_DuzenEtkinlestir"]));
            }
            set {
                this["T_DuzenEtkinlestir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool T_SilEtkinlestir {
            get {
                return ((bool)(this["T_SilEtkinlestir"]));
            }
            set {
                this["T_SilEtkinlestir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool T_EkleEtkinlestir {
            get {
                return ((bool)(this["T_EkleEtkinlestir"]));
            }
            set {
                this["T_EkleEtkinlestir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool T_SiralamaEtkinlestir {
            get {
                return ((bool)(this["T_SiralamaEtkinlestir"]));
            }
            set {
                this["T_SiralamaEtkinlestir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default")]
        public global::MetroFramework.MetroThemeStyle CmbBoxTema {
            get {
                return ((global::MetroFramework.MetroThemeStyle)(this["CmbBoxTema"]));
            }
            set {
                this["CmbBoxTema"] = value;
            }
        }
    }
}
