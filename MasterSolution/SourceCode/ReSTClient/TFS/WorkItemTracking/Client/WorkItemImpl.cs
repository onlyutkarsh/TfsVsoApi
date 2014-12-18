using System;
using System.Collections;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    ///     Class WorkItemImpl.
    /// </summary>
    internal class WorkItemImpl : JsonWorkItem, IWorkItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemImpl"/> class.
        /// </summary>
        /// <param name="content">The content.</param>
        private WorkItemImpl(JToken content) : base(content)
        {
            
        }

        public new static WorkItemImpl FromToken(JToken content)
        {
            var workItem = new WorkItemImpl(content);
           return workItem;
        }

        /// <summary>
        ///     Applies the rules.
        /// </summary>
        /// <param name="copyChangedByFromLatest">The copy changed by from latest.</param>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.ApplyRules(Boolean copyChangedByFromLatest) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Applies the rules.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.ApplyRules() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the area identifier.
        /// </summary>
        /// <value>The area identifier.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        Int32 IWorkItem.AreaId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the area path.
        /// </summary>
        /// <value>The area path.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        String IWorkItem.AreaPath { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the attached file count.
        /// </summary>
        /// <value>The attached file count.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItem.AttachedFileCount { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the attachments.
        /// </summary>
        /// <value>The attachments.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IAttachmentCollection IWorkItem.Attachments { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the authorized date.
        /// </summary>
        /// <value>The authorized date.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        DateTime IWorkItem.AuthorizedDate { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Calculates the field lists.
        /// </summary>
        /// <param name="fieldId">The field identifier.</param>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.CalculateFieldLists(Int32 fieldId) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the changed by.
        /// </summary>
        /// <value>The changed by.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        String IWorkItem.ChangedBy { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the changed date.
        /// </summary>
        /// <value>The changed date.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        DateTime IWorkItem.ChangedDate { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Closes this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.Close() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the collection.
        /// </summary>
        /// <value>The collection.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItemCollection IWorkItem.Collection { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Copies the specified target type.
        /// </summary>
        /// <param name="targetType">Type of the target.</param>
        /// <param name="flags">The flags.</param>
        /// <returns>IWorkItem.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItem IWorkItem.Copy(IWorkItemType targetType, IWorkItemCopyFlags flags) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Copies the specified target type.
        /// </summary>
        /// <param name="targetType">Type of the target.</param>
        /// <returns>IWorkItem.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItem IWorkItem.Copy(IWorkItemType targetType) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Copies this instance.
        /// </summary>
        /// <returns>IWorkItem.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItem IWorkItem.Copy() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the created by.
        /// </summary>
        /// <value>The created by.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        String IWorkItem.CreatedBy { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the created date.
        /// </summary>
        /// <value>The created date.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        DateTime IWorkItem.CreatedDate { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        String IWorkItem.Description { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the display form.
        /// </summary>
        /// <value>The display form.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        String IWorkItem.DisplayForm { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the external link count.
        /// </summary>
        /// <value>The external link count.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItem.ExternalLinkCount { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the field data.
        /// </summary>
        /// <value>The field data.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItemFieldData IWorkItem.FieldData { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the fields.
        /// </summary>
        /// <value>The fields.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IFieldCollection IWorkItem.Fields { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the action object.
        /// </summary>
        /// <param name="actionInfo">The action information.</param>
        /// <returns>Object.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Object IWorkItem.GetActionObject(IWorkItem_EditActionInfo actionInfo) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the actions history.
        /// </summary>
        /// <returns>IWorkItem_EditActionSet[].</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItem_EditActionSet[] IWorkItem.GetActionsHistory() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the field value.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>Object.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Object IWorkItem.GetFieldValue(Int32 id, Int32 revision) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the field value external.
        /// </summary>
        /// <param name="fd">The fd.</param>
        /// <param name="revision">The revision.</param>
        /// <returns>Object.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Object IWorkItem.GetFieldValueExternal(IFieldDefinition fd, Int32 revision) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the latest synchronize data.
        /// </summary>
        /// <returns>IWorkItemSyncData.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItemSyncData IWorkItem.GetLatestSyncData() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the state of the next.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns>String.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        String IWorkItem.GetNextState(String action) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the history.
        /// </summary>
        /// <value>The history.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        String IWorkItem.History { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the hyper link count.
        /// </summary>
        /// <value>The hyper link count.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItem.HyperLinkCount { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItem.Id { get { return base.Id; } }

        /// <summary>
        ///     Gets the internal version.
        /// </summary>
        /// <value>The internal version.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItem.InternalVersion { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is access denied.
        /// </summary>
        /// <value>The is access denied.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IWorkItem.IsAccessDenied { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is dirty.
        /// </summary>
        /// <value>The is dirty.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IWorkItem.IsDirty { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is new.
        /// </summary>
        /// <value>The is new.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IWorkItem.IsNew { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is open.
        /// </summary>
        /// <value>The is open.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IWorkItem.IsOpen { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is partial open.
        /// </summary>
        /// <value>The is partial open.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IWorkItem.IsPartialOpen { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is read only.
        /// </summary>
        /// <value>The is read only.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IWorkItem.IsReadOnly { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the is read only open.
        /// </summary>
        /// <value>The is read only open.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IWorkItem.IsReadOnlyOpen { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Determines whether this instance is valid.
        /// </summary>
        /// <returns>Boolean.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Boolean IWorkItem.IsValid() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the <see cref="Object" /> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Object.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        Object IWorkItem.this[String name] { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the <see cref="Object" /> with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Object.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        Object IWorkItem.this[ICoreField id] { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the iteration identifier.
        /// </summary>
        /// <value>The iteration identifier.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        Int32 IWorkItem.IterationId { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the iteration path.
        /// </summary>
        /// <value>The iteration path.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        String IWorkItem.IterationPath { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the link data.
        /// </summary>
        /// <value>The link data.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItemLinkData IWorkItem.LinkData { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the links.
        /// </summary>
        /// <value>The links.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        ILinkCollection IWorkItem.Links { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the name of the node.
        /// </summary>
        /// <value>The name of the node.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        String IWorkItem.NodeName { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Opens this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.Open() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Partials the open.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.PartialOpen() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the project.
        /// </summary>
        /// <value>The project.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IProject IWorkItem.Project { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the reason.
        /// </summary>
        /// <value>The reason.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        String IWorkItem.Reason { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the related link count.
        /// </summary>
        /// <value>The related link count.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItem.RelatedLinkCount { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Resets this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.Reset() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the rev.
        /// </summary>
        /// <value>The rev.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItem.Rev { get { return base.Rev; } }

        /// <summary>
        ///     Gets the revised date.
        /// </summary>
        /// <value>The revised date.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        DateTime IWorkItem.RevisedDate { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the revision.
        /// </summary>
        /// <value>The revision.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItem.Revision { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the revisions.
        /// </summary>
        /// <value>The revisions.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IRevisionCollection IWorkItem.Revisions { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Saves this instance.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.Save() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Saves the specified save flags.
        /// </summary>
        /// <param name="saveFlags">The save flags.</param>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.Save(ISaveFlags saveFlags) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Sets the dirty.
        /// </summary>
        /// <param name="isDirty">The is dirty.</param>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.SetDirty(Boolean isDirty) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        String IWorkItem.State { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the store.
        /// </summary>
        /// <value>The store.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItemStore IWorkItem.Store { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Synchronizes to latest.
        /// </summary>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.SyncToLatest() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Synchronizes the work item.
        /// </summary>
        /// <param name="syncData">The synchronize data.</param>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        void IWorkItem.SyncWorkItem(IWorkItemSyncData syncData) { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets or sets the tags.
        /// </summary>
        /// <value>The tags.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        String IWorkItem.Tags { get { throw new ToBeImplementedException(); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the temporary identifier.
        /// </summary>
        /// <value>The temporary identifier.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItem.TemporaryId { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException">
        /// </exception>
        String IWorkItem.Title { get { return base.ReadField<String>("System.Title"); } set { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the type.
        /// </summary>
        /// <value>The type.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItemType IWorkItem.Type { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the URI.
        /// </summary>
        /// <value>The URI.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Uri IWorkItem.Uri { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Validates this instance.
        /// </summary>
        /// <returns>ArrayList.</returns>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        ArrayList IWorkItem.Validate() { throw new ToBeImplementedException(); }

        /// <summary>
        ///     Gets the watermark.
        /// </summary>
        /// <value>The watermark.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        Int32 IWorkItem.Watermark { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the work item link history.
        /// </summary>
        /// <value>The work item link history.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItemLinkCollection IWorkItem.WorkItemLinkHistory { get { throw new ToBeImplementedException(); } }

        /// <summary>
        ///     Gets the work item links.
        /// </summary>
        /// <value>The work item links.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.ToBeImplementedException"></exception>
        IWorkItemLinkCollection IWorkItem.WorkItemLinks { get { throw new ToBeImplementedException(); } }

       }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItem_EditActionSetImpl : IWorkItem_EditActionSet
    {
    }
}

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal struct WorkItem_EditActionInfoImpl : IWorkItem_EditActionInfo
    {
    }
}