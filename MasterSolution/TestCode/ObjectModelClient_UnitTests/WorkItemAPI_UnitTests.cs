﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using DynCon.OSI.VSO.ObjectModelClient.Factories;
using DynCon.OSI.VSO.SharedInterfaces.APIs;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using DynCon.OSI.VSO.SharedInterfaces.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests
{
    /// <summary>
    ///     Class ClientObjectModel_UnitTests.
    /// </summary>
    [TestClass]
    public class ClientObjectModel_UnitTests
    {
        /// <summary>
        ///     Builds the work item_ unit test.
        /// </summary>
        [TestMethod]
        public void BuildWorkItem_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            IReadOnlyList<string> headings = new List<string> {"System.Title", "System.Project", "System.WorkItemType"};
            IReadOnlyList<object> data = new List<object> {"Sample Title", "RestPlaypen", "Task"};
            IWorkItem workItem = api.BuildWorkItem(headings, data);
            Assert.IsNotNull(workItem);
        }

        /// <summary>
        ///     Creates the work item_ unit test.
        /// </summary>
        [TestMethod]
        public void CreateWorkItem_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;

            IReadOnlyList<string> headings = new List<string> {"System.Title", "System.Project", "System.WorkItemType"};
            IReadOnlyList<object> data = new List<object> {"Sample Title", "RestPlaypen", "Task"};
            IWorkItem workItem = api.BuildWorkItem(headings, data);
            const string project = "RestPlaypen";
            Task<IWorkItem> createTask = api.CreateWorkItem(project, workItem);
            IWorkItem finalResult = createTask.Result;
            Assert.IsNotNull(finalResult);
        }


        /// <summary>
        ///     Gets the areas_ unit test.
        /// </summary>
        [TestMethod]
        public void GetAreas_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            const string project = "RestPlaypen";

            Task<IReadOnlyList<IArea>> task = api.GetAreas(project, 999);
            IReadOnlyList<IArea> result = task.Result;
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Gets the fields_ unit test.
        /// </summary>
        [TestMethod]
        public void GetFields_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;

            Task<IReadOnlyList<IWorkItemFieldDefinition>> task = api.GetFields();
            IReadOnlyList<IWorkItemFieldDefinition> result = task.Result;
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Gets the iterations_ unit test.
        /// </summary>
        [TestMethod]
        public void GetIterations_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            const string project = "RestPlaypen";

            Task<IReadOnlyList<IIteration>> task = api.GetIterations(project, 999);
            IReadOnlyList<IIteration> result = task.Result;
            Assert.IsNotNull(result);
        }

        /// <summary>
        ///     Gets the work item type categories_ unit test.
        /// </summary>
        [TestMethod]
        public void GetWorkItemTypeCategories_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            const string project = "RestPlaypen";

            Task<IReadOnlyList<IWorkItemTypeCategory>> task = api.GetWorkItemTypeCategories(project);
            IReadOnlyList<IWorkItemTypeCategory> result = task.Result;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        /// <summary>
        ///     Gets the work item types_ unit test.
        /// </summary>
        [TestMethod]
        public void GetWorkItemTypes_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            const string project = "RestPlaypen";

            Task<IReadOnlyList<IWorkItemType>> task = api.GetWorkItemTypes(project);
            IReadOnlyList<IWorkItemType> result = task.Result;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }

        /// <summary>
        ///     Gets the work items_ unit test.
        /// </summary>
        [TestMethod]
        public void GetWorkItems_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;
            var idList = new List<int> {62};
            Task<IReadOnlyList<IWorkItem>> task = api.GetWorkItems(idList);
            Assert.IsNotNull(task);
            IReadOnlyList<IWorkItem> result = task.Result;
            Assert.IsNotNull(result);
            Assert.AreEqual(idList.Count, result.Count);
        }

        /// <summary>
        ///     Wiqls the query_ unit test.
        /// </summary>
        [TestMethod]
        public void WiqlQuery_UnitTest()
        {
            IWorkItemAPI api = APIFactory.WorkItemAPI;

            const string project = "RestPlaypen";
            const string wiql = "SELECT [System.Id], [System.WorkItemType], [System.Title], [System.AssignedTo], [System.State], [System.Tags] FROM WorkItems";
            Task<IReadOnlyList<IWorkItem>> task = api.WiqlQuery(project, wiql, true);
            IReadOnlyList<IWorkItem> result = task.Result;
            Debug.WriteLine("WIQL Query returned {0} Items", result.Count);
            Assert.IsNotNull(result);
        }
    }
}