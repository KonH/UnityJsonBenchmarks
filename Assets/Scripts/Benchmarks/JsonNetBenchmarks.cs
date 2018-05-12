using Newtonsoft.Json;

public static class JsonNetBenchmarks {
	
	public static TestCases.StringField_1 StringField_1(TestCases.StringField_1 obj1) {
		var str = JsonConvert.SerializeObject(obj1);
		var obj2 = JsonConvert.DeserializeObject<TestCases.StringField_1>(str);
		return obj2;
	}

	public static TestCases.StringField_3 StringField_3(TestCases.StringField_3 obj1) {
		var str = JsonConvert.SerializeObject(obj1);
		var obj2 = JsonConvert.DeserializeObject<TestCases.StringField_3>(str);
		return obj2;
	}

	public static TestCases.StringField_5 StringField_5(TestCases.StringField_5 obj1) {
		var str = JsonConvert.SerializeObject(obj1);
		var obj2 = JsonConvert.DeserializeObject<TestCases.StringField_5>(str);
		return obj2;
	}
}
