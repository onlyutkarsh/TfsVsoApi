using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.DynTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.Core_UnitTests.Helpers
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class StringFormatter_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Build_UnitTest()
        {
            String template = default(String);
            Dictionary<String, String> values = default(Dictionary<String, String>);
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    template = default(String); //No Constructor
                    values = new Dictionary<String, String>();
                    Build_PreCondition(ref instance, ref template, ref values);
                },
                instance => { _retVal = StringFormatter.Build(template, values); },
                instance => { Build_PostValidate(ref instance, template, values, _retVal); });
        }

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
                    Equals_PreCondition(ref instance, ref obj);
                },
                instance => { _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(ref instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(ref instance); },
                instance => { _retVal = instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(ref instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            Type _retVal = default(Type);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(ref instance); },
                instance => { _retVal = instance.GetType(); },
                instance => { GetType_PostValidate(ref instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Parse_UnitTest()
        {
            String template = default(String);
            Dictionary<String, String> _retVal = default(Dictionary<String, String>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    template = default(String); //No Constructor
                    Parse_PreCondition(ref instance, ref template);
                },
                instance => { _retVal = StringFormatter.Parse(template); },
                instance => { Parse_PostValidate(ref instance, template, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(ref instance); },
                instance => { _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(ref instance, _retVal); });
        }

        partial void Build_PostValidate(ref StringFormatter instance, String template, Dictionary<String, String> values, String _retVal);
        partial void Build_PreCondition(ref StringFormatter instance, ref String template, ref Dictionary<String, String> values);

        partial void Equals_PostValidate(ref StringFormatter instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref StringFormatter instance, ref Object obj);

        partial void GetHashCode_PostValidate(ref StringFormatter instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref StringFormatter instance);
        internal static IEnumerable<StringFormatter> GetIEnumerableInstance() { return new List<StringFormatter> {GetInstance()}; }

        internal static StringFormatter GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new StringFormatter();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(ref StringFormatter instance, Type _retVal);
        partial void GetType_PreCondition(ref StringFormatter instance);
        static partial void InstanceFactory(ref StringFormatter instance, [CallerMemberName] string callerName = "");
        partial void Parse_PostValidate(ref StringFormatter instance, String template, Dictionary<String, String> _retVal);
        partial void Parse_PreCondition(ref StringFormatter instance, ref String template);
        partial void ToString_PostValidate(ref StringFormatter instance, String _retVal);
        partial void ToString_PreCondition(ref StringFormatter instance);
    }
}