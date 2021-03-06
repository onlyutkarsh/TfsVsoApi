using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WorkItemEventArgsWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Field_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Field; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Object_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWorkItemEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Object; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Field_SetCondition(ref IWorkItemEventArgs instance, ref IField setValue);
        internal static IEnumerable<WorkItemEventArgsWrapper> GetIEnumerableInstance() { return new List<WorkItemEventArgsWrapper> {GetInstance()}; }

        internal static WorkItemEventArgsWrapper GetInstance()
        {
            WorkItemEventArgs real = default(WorkItemEventArgs);
            RealInstanceFactory(ref real);
            var instance = (WorkItemEventArgsWrapper) WorkItemEventArgsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WorkItemEventArgsWrapper instance, [CallerMemberName] string callerName = "");
        partial void Object_SetCondition(ref IWorkItemEventArgs instance, ref Object setValue);
        static partial void RealInstanceFactory(ref WorkItemEventArgs real, [CallerMemberName] string callerName = "");
    }
}