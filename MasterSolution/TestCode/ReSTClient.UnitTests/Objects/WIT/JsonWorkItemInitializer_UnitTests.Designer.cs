using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonWorkItemInitializer_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Equals_UnitTest()
        {
            Object obj = default(Object);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    obj = new Object();
                    Equals_PreCondition(instance, ref obj);
                },
                instance => { return _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(instance); },
                instance => { return _retVal = instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            Type _retVal = default(Type);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(instance); },
                instance => { return _retVal = instance.GetType(); },
                instance => { GetType_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LinkTypeEndInitializer_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemInitializer instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IParameterizedLazyWithReset<JsonRelatedLink, JsonLinkTypeEnd> setValue = default(IParameterizedLazyWithReset<JsonRelatedLink, JsonLinkTypeEnd>);
                    LinkTypeEndInitializer_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.LinkTypeEndInitializer = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.LinkTypeEndInitializer; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void OtherItemInitializer_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    JsonWorkItemInitializer instance = GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    IParameterizedLazyWithReset<JsonRelatedLink, JsonWorkItem> setValue = default(IParameterizedLazyWithReset<JsonRelatedLink, JsonWorkItem>);
                    OtherItemInitializer_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.OtherItemInitializer = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.OtherItemInitializer; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(instance); },
                instance => { return _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void Equals_PostValidate(JsonWorkItemInitializer instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonWorkItemInitializer instance, ref Object obj);
        partial void GetHashCode_PostValidate(JsonWorkItemInitializer instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonWorkItemInitializer instance);
        internal static IEnumerable<JsonWorkItemInitializer> GetIEnumerableInstance() { return new List<JsonWorkItemInitializer> {GetInstance()}; }

        internal static JsonWorkItemInitializer GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonWorkItemInitializer();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(JsonWorkItemInitializer instance, Type _retVal);
        partial void GetType_PreCondition(JsonWorkItemInitializer instance);
        static partial void InstanceFactory(ref JsonWorkItemInitializer instance, [CallerMemberName] string callerName = "");

        partial void LinkTypeEndInitializer_SetCondition(ref JsonWorkItemInitializer instance, ref IParameterizedLazyWithReset<JsonRelatedLink, JsonLinkTypeEnd> setValue);
        partial void OtherItemInitializer_SetCondition(ref JsonWorkItemInitializer instance, ref IParameterizedLazyWithReset<JsonRelatedLink, JsonWorkItem> setValue);
        partial void ToString_PostValidate(JsonWorkItemInitializer instance, String _retVal);
        partial void ToString_PreCondition(JsonWorkItemInitializer instance);
    }
}