// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\Person.json"
// Version: 1005
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
using JsonDemo.CustomAttributes;
#pragma warning disable 0108
#pragma warning disable 1591

namespace JsonDemo {
using __Person1__ = global::JsonDemo.Person.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __PeAge__ = global::JsonDemo.Person.Input.Age;
using __PeName__ = global::JsonDemo.Person.Input.Name;
using __PeHtml__ = global::JsonDemo.Person.Input.Html;
using __Person2__ = global::JsonDemo.Person.Input;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __PeSchema__ = global::JsonDemo.Person.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Person__ = global::JsonDemo.Person;
using __TLong__ = global::Starcounter.Templates.TLong;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class Person_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class Person : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __PeSchema__ DefaultTemplate = new __PeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Person() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Person(__PeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __PeSchema__ Template { get { return (__PeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Person__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/JsonDemo/viewmodels/Person.html";
                Html.SetCustomAccessors((_p_) => { return ((__Person__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Person__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Person__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Person__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Age = Add<__TLong__>("Age");
                Age.DefaultValue = 0L;
                Age.SetCustomAccessors((_p_) => { return ((__Person__)_p_).__bf__Age__; }, (_p_, _v_) => { ((__Person__)_p_).__bf__Age__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Person__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TLong__ Age;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\Person.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\Person.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModels\Person.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModels\Person.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Age__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Age {
    #line 4 "ViewModels\Person.json"
        get {
        #line hidden
            return Template.Age.Getter(this); }
        #line 4 "ViewModels\Person.json"
        set {
        #line hidden
            Template.Age.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Person__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Person__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Age : Input<__Person__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
