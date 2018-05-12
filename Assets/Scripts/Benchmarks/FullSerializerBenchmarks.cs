using FullSerializer;

public static class FullSerializerBenchmarks {

	static fsSerializer _serializer = new fsSerializer();

	public static TestCases.StringField_1 StringField_1(TestCases.StringField_1 obj1) {
		fsData data1;
		_serializer.TrySerialize(obj1, out data1);

		var str = fsJsonPrinter.CompressedJson(data1);

		TestCases.StringField_1 obj2 = null;
		var data2 = fsJsonParser.Parse(str);
		_serializer.TryDeserialize(data2, ref obj2);

		return obj2;
	}

	public static TestCases.StringField_3 StringField_3(TestCases.StringField_3 obj1) {
		fsData data1;
		_serializer.TrySerialize(obj1, out data1);

		var str = fsJsonPrinter.CompressedJson(data1);

		TestCases.StringField_3 obj2 = null;
		var data2 = fsJsonParser.Parse(str);
		_serializer.TryDeserialize(data2, ref obj2);

		return obj2;
	}

	public static TestCases.StringField_5 StringField_5(TestCases.StringField_5 obj1) {
		fsData data1;
		_serializer.TrySerialize(obj1, out data1);

		var str = fsJsonPrinter.CompressedJson(data1);

		TestCases.StringField_5 obj2 = null;
		var data2 = fsJsonParser.Parse(str);
		_serializer.TryDeserialize(data2, ref obj2);

		return obj2;
	}
}
