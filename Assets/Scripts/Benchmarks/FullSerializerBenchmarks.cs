using FullSerializer;

public static class FullSerializerBenchmarks {

	static fsSerializer _serializer = new fsSerializer();

	public static TestCases.OneStringField OneStringField(TestCases.OneStringField obj1) {
		fsData data1;
		_serializer.TrySerialize(obj1, out data1);

		var str = fsJsonPrinter.CompressedJson(data1);

		TestCases.OneStringField obj2 = null;
		var data2 = fsJsonParser.Parse(str);
		_serializer.TryDeserialize(data2, ref obj2);

		return obj2;
	}
}
