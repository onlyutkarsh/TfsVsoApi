using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Proxy
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class FileAttachmentWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AreaNodeUri_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFileAttachment) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    AreaNodeUri_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.AreaNodeUri = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.AreaNodeUri; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FileNameGUID_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFileAttachment) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    Guid setValue = default(Guid);
                    FileNameGUID_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.FileNameGUID = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.FileNameGUID; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void LocalFile_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFileAttachment) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    Stream setValue = default(Stream);
                    LocalFile_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.LocalFile = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.LocalFile; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ProjectUri_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IFileAttachment) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    ProjectUri_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.ProjectUri = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.ProjectUri; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AreaNodeUri_SetCondition(ref IFileAttachment instance, ref String setValue);
        partial void FileNameGUID_SetCondition(ref IFileAttachment instance, ref Guid setValue);
        internal static IEnumerable<FileAttachmentWrapper> GetIEnumerableInstance() { return new List<FileAttachmentWrapper> {GetInstance()}; }

        internal static FileAttachmentWrapper GetInstance()
        {
            FileAttachment real = default(FileAttachment);
            RealInstanceFactory(ref real);
            FileAttachmentWrapper instance = FileAttachmentWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            return instance;
        }

        static partial void InstanceFactory(ref FileAttachmentWrapper instance, [CallerMemberName] string callerName = "");

        partial void LocalFile_SetCondition(ref IFileAttachment instance, ref Stream setValue);
        partial void ProjectUri_SetCondition(ref IFileAttachment instance, ref String setValue);
        static partial void RealInstanceFactory(ref FileAttachment real, [CallerMemberName] string callerName = "");
    }
}