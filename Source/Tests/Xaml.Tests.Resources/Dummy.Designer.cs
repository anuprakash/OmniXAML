﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xaml.Tests.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Dummy {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Dummy() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Xaml.Tests.Resources.Dummy", typeof(Dummy).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; Container.Property=&quot;Value&quot;&gt;&lt;/DummyClass&gt;.
        /// </summary>
        public static string AttachedProperty {
            get {
                return ResourceManager.GetString("AttachedProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Bad&lt;/&gt;.
        /// </summary>
        public static string BadFormat {
            get {
                return ResourceManager.GetString("BadFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;DummyClass.Items&gt;
        ///    &lt;Item /&gt;
        ///    &lt;Item /&gt;
        ///    &lt;Item /&gt;
        ///  &lt;/DummyClass.Items&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string ChildCollection {
            get {
                return ResourceManager.GetString("ChildCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;root&quot; xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;&gt;
        ///    &lt;Grid&gt;
        ///        &lt;TextBlock x:Name=&quot;MyTextBlock&quot; /&gt;
        ///        &lt;TextBlock x:Name=&quot;MyOtherTextBlock&quot; /&gt;
        ///    &lt;/Grid&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string ChildInDeeperNameScope {
            get {
                return ResourceManager.GetString("ChildInDeeperNameScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;&gt;
        ///  &lt;DummyClass.Child&gt;
        ///    &lt;ChildClass x:Name=&quot;MyObject&quot; /&gt;
        ///  &lt;/DummyClass.Child&gt;    
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string ChildInNameScope {
            get {
                return ResourceManager.GetString("ChildInNameScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;DummyClass.Items&gt;
        ///    &lt;Item/&gt;
        ///  &lt;/DummyClass.Items&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string ClassWithInnerCollection {
            get {
                return ResourceManager.GetString("ClassWithInnerCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; /&gt;.
        /// </summary>
        public static string CollapsedTag {
            get {
                return ResourceManager.GetString("CollapsedTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; SampleProperty=&quot;SomeText&quot; /&gt;.
        /// </summary>
        public static string CollapsedTagWithProperty {
            get {
                return ResourceManager.GetString("CollapsedTagWithProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;Item Title=&quot;Main1&quot; /&gt;
        ///  &lt;Item Title=&quot;Main2&quot; /&gt;
        ///  &lt;DummyClass.Child&gt;
        ///    &lt;ChildClass&gt;
        ///      &lt;Item&gt;
        ///        &lt;Item Title=&quot;Item1&quot; /&gt;
        ///        &lt;Item Title=&quot;Item2&quot; /&gt;
        ///        &lt;Item Title=&quot;Item3&quot; /&gt;
        ///      &lt;/Item&gt;
        ///      &lt;ChildClass.Child&gt;
        ///        &lt;ChildClass /&gt;
        ///      &lt;/ChildClass.Child&gt;
        ///    &lt;/ChildClass&gt;
        ///  &lt;/DummyClass.Child&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string CollectionsContentPropertyNesting {
            get {
                return ResourceManager.GetString("CollectionsContentPropertyNesting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;DummyClass.Items&gt;
        ///    &lt;Item Title=&quot;SomeText&quot; /&gt;
        ///  &lt;/DummyClass.Items&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string CollectionWithClosedItemAndProperty {
            get {
                return ResourceManager.GetString("CollectionWithClosedItemAndProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Grid xmlns=&quot;root&quot;&gt;
        ///  &lt;Grid.Children&gt;
        ///    &lt;TextBlock&gt;
        ///    &lt;/TextBlock&gt;
        ///    &lt;TextBlock /&gt;
        ///  &lt;/Grid.Children&gt;
        ///&lt;/Grid&gt;.
        /// </summary>
        public static string CollectionWithMixedEmptyAndNotEmptyNestedElements {
            get {
                return ResourceManager.GetString("CollectionWithMixedEmptyAndNotEmptyNestedElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;DummyClass.Items&gt;
        ///    &lt;Item/&gt;
        ///    &lt;Item/&gt;
        ///    &lt;Item/&gt;
        ///  &lt;/DummyClass.Items&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string CollectionWithMoreThanOneItem {
            get {
                return ResourceManager.GetString("CollectionWithMoreThanOneItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;!--This is a comment--&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string Comment {
            get {
                return ResourceManager.GetString("Comment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;Item /&gt;
        ///  &lt;Item /&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string ContentPropertyForCollectionMoreThanOneElement {
            get {
                return ResourceManager.GetString("ContentPropertyForCollectionMoreThanOneElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;Item /&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string ContentPropertyForCollectionOneElement {
            get {
                return ResourceManager.GetString("ContentPropertyForCollectionOneElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;ChildClass xmlns=&quot;root&quot;&gt;
        ///  &lt;Item /&gt;
        ///&lt;/ChildClass&gt;.
        /// </summary>
        public static string ContentPropertyForSingleMember {
            get {
                return ResourceManager.GetString("ContentPropertyForSingleMember", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;TextBlock xmlns=&quot;root&quot;&gt;Hi all!!&lt;/TextBlock&gt;  .
        /// </summary>
        public static string ContentPropertyInInnerContent {
            get {
                return ResourceManager.GetString("ContentPropertyInInnerContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;
        ///            xmlns:x=&quot;another&quot; &gt;
        ///  &lt;DummyClass.ChildFromAnotherNamespace&gt;
        ///    &lt;x:Foreigner /&gt;
        ///  &lt;/DummyClass.ChildFromAnotherNamespace&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string DifferentNamespaces {
            get {
                return ResourceManager.GetString("DifferentNamespaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;
        ///            xmlns:x=&quot;another&quot; SampleProperty=&quot;One&quot; AnotherProperty=&quot;Two&quot;&gt;
        ///  &lt;DummyClass.ChildFromAnotherNamespace&gt;
        ///    &lt;x:Foreigner /&gt;
        ///  &lt;/DummyClass.ChildFromAnotherNamespace&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string DifferentNamespacesAndMoreThanOneProperty {
            get {
                return ResourceManager.GetString("DifferentNamespacesAndMoreThanOneProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string Empty {
            get {
                return ResourceManager.GetString("Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; EnumProperty=&quot;One&quot;&gt;&lt;/DummyClass&gt;.
        /// </summary>
        public static string EnumProperty {
            get {
                return ResourceManager.GetString("EnumProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;DummyClass.Child&gt;
        ///    &lt;ChildClass&gt;&lt;/ChildClass&gt;
        ///  &lt;/DummyClass.Child&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string ExpectedStage11 {
            get {
                return ResourceManager.GetString("ExpectedStage11", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;DummyClass.Child&gt;
        ///    &lt;ChildClass&gt;
        ///      &lt;ChildClass.Child&gt;
        ///        &lt;ChildClass&gt;
        ///          &lt;ChildClass.Child&gt;
        ///            &lt;ChildClass/&gt;
        ///          &lt;/ChildClass.Child&gt;
        ///        &lt;/ChildClass&gt;
        ///      &lt;/ChildClass.Child&gt;
        ///    &lt;/ChildClass&gt;
        ///  &lt;/DummyClass.Child&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string FourLevelsOfNesting {
            get {
                return ResourceManager.GetString("FourLevelsOfNesting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;
        ///            xmlns:mc=&quot;http://schemas.openxmlformats.org/markup-compatibility/2006&quot;
        ///            mc:Ignorable=&quot;d&quot;
        ///            xmlns:d=&quot;http://schemas.microsoft.com/expression/blend/2008&quot;
        ///            d:DesignWidth=&quot;300&quot;
        ///            SampleProperty=&quot;Property!&quot;&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string Ignorable {
            get {
                return ResourceManager.GetString("Ignorable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;DummyClass.SampleProperty&gt;Property!&lt;/DummyClass.SampleProperty&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string InnerContent {
            get {
                return ResourceManager.GetString("InnerContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;DummyClass.Child&gt;
        ///    &lt;ChildClass&gt;&lt;/ChildClass&gt;
        ///  &lt;/DummyClass.Child&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string InstanceWithChild {
            get {
                return ResourceManager.GetString("InstanceWithChild", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;ChildClass xmlns=&quot;root&quot;&gt;
        ///  &lt;Item /&gt;
        ///&lt;/ChildClass&gt;.
        /// </summary>
        public static string InstanceWithCollapsedChildThatUsesContentProperty {
            get {
                return ResourceManager.GetString("InstanceWithCollapsedChildThatUsesContentProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;sys:Int32 xmlns:sys=&quot;clr-namespace:System;assembly=mscorlib&quot;&gt;123&lt;/sys:Int32&gt;.
        /// </summary>
        public static string Int {
            get {
                return ResourceManager.GetString("Int", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;
        ///            xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;&gt;
        ///  &lt;DummyClass.Resources&gt;
        ///    &lt;ChildClass x:Key=&quot;SomeKey&quot; /&gt;    
        ///  &lt;/DummyClass.Resources&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string KeyDirective {
            get {
                return ResourceManager.GetString("KeyDirective", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;
        ///            xmlns:special=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;&gt;
        ///  &lt;DummyClass.Resources&gt;
        ///    &lt;ChildClass special:Key=&quot;SomeKey&quot; /&gt;    
        ///  &lt;/DummyClass.Resources&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string KeyDirectiveNotInX {
            get {
                return ResourceManager.GetString("KeyDirectiveNotInX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; SampleProperty=&quot;{Parameterized Parameter}&quot;/&gt;.
        /// </summary>
        public static string MarkupExtensionCtorWith1StringArgument {
            get {
                return ResourceManager.GetString("MarkupExtensionCtorWith1StringArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;
        ///            SampleProperty=&quot;{Dummy Property=&apos;Some Value&apos;}&quot;
        ///            AnotherProperty=&quot;{Dummy Property=&apos;Another Value&apos;}&quot; /&gt;.
        /// </summary>
        public static string MarkupExtensionTwoQuotedValues {
            get {
                return ResourceManager.GetString("MarkupExtensionTwoQuotedValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; SampleProperty=&quot;{Dummy Option}&quot;/&gt;.
        /// </summary>
        public static string MarkupExtensionWithOption {
            get {
                return ResourceManager.GetString("MarkupExtensionWithOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;sysCol:ArrayList xmlns:sysCol=&quot;clr-namespace:System.Collections;assembly=mscorlib&quot;
        ///                  xmlns=&quot;root&quot;&gt;
        ///    &lt;DummyClass /&gt;
        ///    &lt;DummyClass /&gt;
        ///    &lt;DummyClass /&gt;
        ///&lt;/sysCol:ArrayList&gt;.
        /// </summary>
        public static string MixedCollection {
            get {
                return ResourceManager.GetString("MixedCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;Item /&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string NestedChildWithoutPropertyName {
            get {
                return ResourceManager.GetString("NestedChildWithoutPropertyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; NonExisting=&quot;Something&quot; /&gt;.
        /// </summary>
        public static string NonExistingProperty {
            get {
                return ResourceManager.GetString("NonExistingProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;x:DummyClass xmlns:x=&quot;nonRoot&quot;&gt;&lt;/x:DummyClass&gt;.
        /// </summary>
        public static string NonRootNamespace {
            get {
                return ResourceManager.GetString("NonRootNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; Number=&quot;1234&quot;&gt;&lt;/DummyClass&gt;.
        /// </summary>
        public static string NonStringProperty {
            get {
                return ResourceManager.GetString("NonStringProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;sysCol:ArrayList xmlns:sysCol=&quot;clr-namespace:System.Collections;assembly=mscorlib&quot;
        ///           xmlns:sys=&quot;clr-namespace:System;assembly=mscorlib&quot;&gt;
        ///    &lt;sys:Int32&gt;1&lt;/sys:Int32&gt;
        ///    &lt;sys:Int32&gt;2&lt;/sys:Int32&gt;
        ///    &lt;sys:Int32&gt;3&lt;/sys:Int32&gt;
        ///&lt;/sysCol:ArrayList&gt;.
        /// </summary>
        public static string PureCollection {
            get {
                return ResourceManager.GetString("PureCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;&lt;/DummyClass&gt;.
        /// </summary>
        public static string RootNamespace {
            get {
                return ResourceManager.GetString("RootNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; SampleProperty=&quot;{Dummy}&quot;/&gt;.
        /// </summary>
        public static string SimpleExtension {
            get {
                return ResourceManager.GetString("SimpleExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; SampleProperty=&quot;{Dummy Property=SomeValue}&quot;/&gt;.
        /// </summary>
        public static string SimpleExtensionWithOneAssignment {
            get {
                return ResourceManager.GetString("SimpleExtensionWithOneAssignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;&lt;/DummyClass&gt;.
        /// </summary>
        public static string SingleInstance {
            get {
                return ResourceManager.GetString("SingleInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;sys:String xmlns:sys=&quot;clr-namespace:System;assembly=mscorlib&quot;&gt;Text&lt;/sys:String&gt;.
        /// </summary>
        public static string String {
            get {
                return ResourceManager.GetString("String", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; xmlns:sys=&quot;clr-namespace:System;assembly=mscorlib&quot;&gt;
        ///  &lt;DummyClass.SampleProperty&gt;
        ///    &lt;sys:String &gt;Text&lt;/sys:String&gt;
        ///  &lt;/DummyClass.SampleProperty&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string StringAsProperty {
            get {
                return ResourceManager.GetString("StringAsProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; SampleProperty=&quot;Property!&quot;&gt;&lt;/DummyClass&gt;.
        /// </summary>
        public static string StringProperty {
            get {
                return ResourceManager.GetString("StringProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;sys:String xmlns:sys=&quot;clr-namespace:System;assembly=mscorlib&quot;&gt;
        ///
        ///  Text
        ///
        ///&lt;/sys:String&gt;.
        /// </summary>
        public static string StringWithWhitespace {
            get {
                return ResourceManager.GetString("StringWithWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;DummyClass.Child&gt;
        ///    &lt;ChildClass&gt;
        ///      &lt;ChildClass.Child&gt;
        ///        &lt;ChildClass/&gt;
        ///      &lt;/ChildClass.Child&gt;
        ///    &lt;/ChildClass&gt;
        ///  &lt;/DummyClass.Child&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string ThreeLevelsOfNesting {
            get {
                return ResourceManager.GetString("ThreeLevelsOfNesting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;DummyClass.Items&gt;
        ///    &lt;Item Title=&quot;Main1&quot; /&gt;
        ///    &lt;Item Title=&quot;Main2&quot; /&gt;
        ///  &lt;/DummyClass.Items&gt;
        ///  &lt;DummyClass.Child&gt;
        ///    &lt;ChildClass&gt;
        ///    &lt;/ChildClass&gt;
        ///  &lt;/DummyClass.Child&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string TwoNestedProperties {
            get {
                return ResourceManager.GetString("TwoNestedProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot;&gt;
        ///  &lt;DummyClass.Items&gt;   
        ///  &lt;/DummyClass.Items&gt;
        ///  &lt;DummyClass.Child&gt;    
        ///  &lt;/DummyClass.Child&gt;
        ///&lt;/DummyClass&gt;.
        /// </summary>
        public static string TwoNestedPropertiesEmpty {
            get {
                return ResourceManager.GetString("TwoNestedPropertiesEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;ChildClass  xmlns=&quot;root&quot;&gt;
        ///  &lt;Item&gt;
        ///    &lt;Item Title=&quot;Item1&quot; /&gt;    
        ///  &lt;/Item&gt;
        ///  &lt;ChildClass.Child&gt;
        ///    &lt;ChildClass /&gt;
        ///  &lt;/ChildClass.Child&gt;
        ///&lt;/ChildClass&gt;.
        /// </summary>
        public static string TwoNestedPropertiesOneOfThemUsesContentPropertyWithSingleItem {
            get {
                return ResourceManager.GetString("TwoNestedPropertiesOneOfThemUsesContentPropertyWithSingleItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;ChildClass  xmlns=&quot;root&quot;&gt;
        ///  &lt;Item&gt;
        ///    &lt;Item Title=&quot;Item1&quot; /&gt;    
        ///  &lt;/Item&gt;
        ///  &lt;ChildClass.Child&gt;
        ///    &lt;ChildClass /&gt;
        ///  &lt;/ChildClass.Child&gt;
        ///&lt;/ChildClass&gt;.
        /// </summary>
        public static string TwoNestedPropertiesOneOfThemUsesContentPropertyWithSingleItem1 {
            get {
                return ResourceManager.GetString("TwoNestedPropertiesOneOfThemUsesContentPropertyWithSingleItem1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Unknown&gt;&lt;/Unknown&gt;.
        /// </summary>
        public static string UnknownType {
            get {
                return ResourceManager.GetString("UnknownType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DummyClass xmlns=&quot;root&quot; Container.Property=&quot;Value&quot;&gt;&lt;/DummyClass&gt;.
        /// </summary>
        public static string WithAttachableProperty {
            get {
                return ResourceManager.GetString("WithAttachableProperty", resourceCulture);
            }
        }
    }
}
