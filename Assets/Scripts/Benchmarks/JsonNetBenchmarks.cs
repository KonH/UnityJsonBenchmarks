using Newtonsoft.Json;

public static class JsonNetBenchmarks {
	
	public static TestCases.OneStringField OneStringField(TestCases.OneStringField obj1) {
		var str = JsonConvert.SerializeObject(obj1);
		var obj2 = JsonConvert.DeserializeObject<TestCases.OneStringField>(str);
		return obj2;
	}
}
