using NUnit.Framework;
using FullSerializer;

public class FullSerializerTests {

	[Test]
	public void StringField_1() {
		var serializer = new fsSerializer();
		var obj1 = new TestCases.StringField_1 { Field_0 = "some_text" };

		fsData data1;
		var result1 = serializer.TrySerialize(obj1, out data1);
		Assert.False(result1.Failed);

		var str = fsJsonPrinter.CompressedJson(data1);

		TestCases.StringField_1 obj2 = null;
		var data2 = fsJsonParser.Parse(str);
		var result2 = serializer.TryDeserialize<TestCases.StringField_1>(data2, ref obj2);
		Assert.False(result2.Failed);

		Assert.True(obj1.Field_0 == obj2.Field_0);
	}
}
