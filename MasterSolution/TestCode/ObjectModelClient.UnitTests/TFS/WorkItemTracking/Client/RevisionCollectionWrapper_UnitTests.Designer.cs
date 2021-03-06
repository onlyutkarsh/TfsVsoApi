using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class RevisionCollectionWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<RevisionCollectionWrapper> GetIEnumerableInstance() { return new List<RevisionCollectionWrapper> {GetInstance()}; }

        internal static RevisionCollectionWrapper GetInstance()
        {
            RevisionCollection real = default(RevisionCollection);
            RealInstanceFactory(ref real);
            var instance = (RevisionCollectionWrapper) RevisionCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref RevisionCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref RevisionCollection real, [CallerMemberName] string callerName = "");
    }
}