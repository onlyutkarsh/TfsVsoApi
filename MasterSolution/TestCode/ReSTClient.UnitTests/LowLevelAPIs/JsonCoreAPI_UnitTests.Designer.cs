using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.LowLevelAPIs;
using DynCon.OSI.VSO.ReSTClient.Objects;
using DynCon.OSI.VSO.ReSTClient.Objects.Build;
using DynCon.OSI.VSO.ReSTClient.Objects.Projects;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.LowLevelAPIs
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class JsonCoreAPI_UnitTests : DynTestClassBase
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
        public void GetConnectedServices_UnitTest()
        {
            string projectId = "RestPlaypen";
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetConnectedServices_PreCondition(instance); },
                instance => { return _retVal = instance.GetConnectedServices(projectId); },
                instance => { GetConnectedServices_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetDetails_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetDetails_PreCondition(instance); },
                instance => { return _retVal = instance.GetDetails(); },
                instance => { GetDetails_PostValidate(instance, _retVal); });
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
        public void GetIdentityMru_UnitTest()
        {
            Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal = default(Task<IReadOnlyList<JsonGeneralPurposeObject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetIdentityMru_PreCondition(instance); },
                instance => { return _retVal = instance.GetIdentityMru(); },
                instance => { GetIdentityMru_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetMembers_UnitTest()
        {
            string projectId = "RestPlaypen";
            string teamId = "4ae176ed-a71c-417d-a33c-96a004fef678";
            Task<IReadOnlyList<JsonIdentity>> _retVal = default(Task<IReadOnlyList<JsonIdentity>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetMembers_PreCondition(instance); },
                instance => { return _retVal = instance.GetMembers(projectId, teamId); },
                instance => { GetMembers_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetProjects_UnitTest()
        {
            Task<IReadOnlyList<JsonProject>> _retVal = default(Task<IReadOnlyList<JsonProject>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetProjects_PreCondition(instance); },
                instance => { return _retVal = instance.GetProjects(); },
                instance => { GetProjects_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetProxies_UnitTest()
        {
            Task<IReadOnlyList<JsonProxy>> _retVal = default(Task<IReadOnlyList<JsonProxy>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetProxies_PreCondition(instance); },
                instance => { return _retVal = instance.GetProxies(); },
                instance => { GetProxies_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetTeams_UnitTest()
        {
            string projectId = "RestPlaypen";
            Task<IReadOnlyList<JsonTeam>> _retVal = default(Task<IReadOnlyList<JsonTeam>>);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetTeams_PreCondition(instance); },
                instance => { return _retVal = instance.GetTeams(projectId); },
                instance => { GetTeams_PostValidate(instance, _retVal); });
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
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(instance); },
                instance => { return _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        partial void Equals_PostValidate(JsonCoreAPI instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(JsonCoreAPI instance, ref Object obj);
        partial void GetConnectedServices_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetConnectedServices_PreCondition(JsonCoreAPI instance);
        partial void GetDetails_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetDetails_PreCondition(JsonCoreAPI instance);

        partial void GetHashCode_PostValidate(JsonCoreAPI instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(JsonCoreAPI instance);
        internal static IEnumerable<JsonCoreAPI> GetIEnumerableInstance() { return new List<JsonCoreAPI> {GetInstance()}; }
        partial void GetIdentityMru_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonGeneralPurposeObject>> _retVal);
        partial void GetIdentityMru_PreCondition(JsonCoreAPI instance);

        internal static JsonCoreAPI GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new JsonCoreAPI();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetMembers_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonIdentity>> _retVal);
        partial void GetMembers_PreCondition(JsonCoreAPI instance);
        partial void GetProjects_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonProject>> _retVal);
        partial void GetProjects_PreCondition(JsonCoreAPI instance);
        partial void GetProxies_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonProxy>> _retVal);
        partial void GetProxies_PreCondition(JsonCoreAPI instance);
        partial void GetTeams_PostValidate(JsonCoreAPI instance, Task<IReadOnlyList<JsonTeam>> _retVal);
        partial void GetTeams_PreCondition(JsonCoreAPI instance);

        partial void GetType_PostValidate(JsonCoreAPI instance, Type _retVal);
        partial void GetType_PreCondition(JsonCoreAPI instance);
        static partial void InstanceFactory(ref JsonCoreAPI instance, [CallerMemberName] string callerName = "");
        partial void ToString_PostValidate(JsonCoreAPI instance, String _retVal);
        partial void ToString_PreCondition(JsonCoreAPI instance);
    }
}