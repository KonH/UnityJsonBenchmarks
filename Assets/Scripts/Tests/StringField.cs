using NUnit.Framework;
using UnityEngine;
using FullSerializer;
using Newtonsoft.Json;

public class StringField {

	[Test]
	public void FsSerializerSerializeDeserialize() {
		var serializer = new fsSerializer();
		var obj1 = new TestCases.StringField { Field = "some_text" };

		fsData data1;
		var result1 = serializer.TrySerialize(obj1, out data1);
		Assert.False(result1.Failed);

		var str = fsJsonPrinter.CompressedJson(data1);
		Debug.Log(str);

		TestCases.StringField obj2 = null;
		var data2 = fsJsonParser.Parse(str);
		var result2 = serializer.TryDeserialize(data2, ref obj2);
		Assert.False(result2.Failed);

		Assert.True(obj1.Field == obj2.Field);
	}

	[Test]
	public void JsonNetSerializeDeserialize() {
		var obj1 = new TestCases.StringField { Field = "some_text" };

		var str = JsonConvert.SerializeObject(obj1);
		Debug.Log(str);

		var obj2 = JsonConvert.DeserializeObject<TestCases.StringField>(str);
		Assert.True(obj1.Field == obj2.Field);
	}
}
