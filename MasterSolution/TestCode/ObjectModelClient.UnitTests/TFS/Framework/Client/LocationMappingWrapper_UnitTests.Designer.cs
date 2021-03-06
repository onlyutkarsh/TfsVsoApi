using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class LocationMappingWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AccessMapping_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ILocationMapping) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.AccessMapping; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Location_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ILocationMapping) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Location; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AccessMapping_SetCondition(ref ILocationMapping instance, ref IAccessMapping setValue);
        internal static IEnumerable<LocationMappingWrapper> GetIEnumerableInstance() { return new List<LocationMappingWrapper> {GetInstance()}; }

        internal static LocationMappingWrapper GetInstance()
        {
            LocationMapping real = default(LocationMapping);
            RealInstanceFactory(ref real);
            var instance = (LocationMappingWrapper) LocationMappingWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref LocationMappingWrapper instance, [CallerMemberName] string callerName = "");
        partial void Location_SetCondition(ref ILocationMapping instance, ref String setValue);
        static partial void RealInstanceFactory(ref LocationMapping real, [CallerMemberName] string callerName = "");
    }
}