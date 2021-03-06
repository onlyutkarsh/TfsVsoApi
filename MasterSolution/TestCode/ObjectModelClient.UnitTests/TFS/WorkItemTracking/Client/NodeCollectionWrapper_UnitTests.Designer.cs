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
    public partial class NodeCollectionWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<NodeCollectionWrapper> GetIEnumerableInstance() { return new List<NodeCollectionWrapper> {GetInstance()}; }

        internal static NodeCollectionWrapper GetInstance()
        {
            NodeCollection real = default(NodeCollection);
            RealInstanceFactory(ref real);
            var instance = (NodeCollectionWrapper) NodeCollectionWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref NodeCollectionWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref NodeCollection real, [CallerMemberName] string callerName = "");
    }
}