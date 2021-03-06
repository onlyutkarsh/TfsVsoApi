using System;
using System.Linq;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT.Collections;
using DynCon.OSI.VSO.ReSTClient.UnitTests.Helpers.JsonSource;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.Objects.WIT.Collections
{
    /// <summary>Generated Test Template</summary>
    public partial class JsonFieldCollection_UnitTests : DynTestClassBase
    {
        partial void CaptureJson_PreCondition(JsonFieldCollection instance, ref Int32 id, ref Int32 rev, ref JToken newFields)
        {
            id = 1234;
            rev = 1;
            newFields = JsonFactory();
        }

        partial void Contains_PreCondition(JsonFieldCollection instance, ref String fieldName) { fieldName = "System.Id"; }

        partial void CopyTo_PreCondition(JsonFieldCollection instance, ref Array array, ref Int32 index)
        {
            array = new JsonField[100];
            index = 1;
        }

        static partial void InstanceFactory(ref JsonFieldCollection instance, string callerName)
        {
            JToken json = JsonFactory();
            instance = JsonFieldCollection.FromToken(json);
        }

        private static JToken JsonFactory()
        {
            JObject o = CannedMessages.SampleWorkItemsWithRelations;
            var firstItem = (JObject) o["value"].Value<JArray>()[0];
            JProperty property = firstItem.Properties().FirstOrDefault(p => p.Name == "fields");
            JToken json = property.Value;
            return json;
        }


        partial void TryGetField_PostValidate(JsonFieldCollection instance, String fieldName, JsonField field, Boolean _retVal)
        {
            switch (DataSequence)
            {
                case 1:
                    MoreData = true;
                    break;
                case 2:
                    MoreData = false;
                    break;
            }
        }

        partial void TryGetField_PreCondition(JsonFieldCollection instance, ref String fieldName, ref JsonField field)
        {
            switch (DataSequence)
            {
                case 1:
                    fieldName = "System.Id";
                    break;
                case 2:
                    fieldName = "System.Title";
                    break;
            }
        }
    }
}