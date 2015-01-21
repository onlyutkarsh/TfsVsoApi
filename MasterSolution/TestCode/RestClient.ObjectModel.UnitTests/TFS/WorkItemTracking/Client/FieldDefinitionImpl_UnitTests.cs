using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class FieldDefinitionImpl_UnitTests
    {
        static partial void JsonSource(ref JToken json)
        {
            //var retVal = new JObject();
            //retVal.Add("referenceName", "Testing.Field.ReferenceName");
            //retVal.Add("rel", "Testing.Field.Rel");
            //json = retVal;

            json = JObject.Parse(CannedMessages.SampleWorkItemsFieldDefinition);
        }
    }
}