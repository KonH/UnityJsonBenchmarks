using NUnit.Framework;
using FullSerializer;

public class FullSerializerTests {

	[Test]
	public void OneStringField() {
		var serializer = new fsSerializer();
		var obj1 = new TestCases.OneStringField { Field = "some_text" };

		fsData data1;
		var result1 = serializer.TrySerialize(obj1, out data1);
		Assert.False(result1.Failed);

		var str = fsJsonPrinter.CompressedJson(data1);

		TestCases.OneStringField obj2 = null;
		var data2 = fsJsonParser.Parse(str);
		var result2 = serializer.TryDeserialize<TestCases.OneStringField>(data2, ref obj2);
		Assert.False(result2.Failed);

		Assert.True(obj1.Field == obj2.Field);
	}
}
