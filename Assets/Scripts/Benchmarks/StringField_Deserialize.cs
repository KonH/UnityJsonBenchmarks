using System.Collections.Generic;
using UnityBenchmarkHarness;

public class StringField_Deserialize : UnityBenchmark {
	public override List<BenchmarkRunnerBase> CreateRunners() {
		throw new System.NotImplementedException();
	}

	/*public override BenchmarkRunnerBase CreateRunner() {
		return new BenchmarkRunner<TestCases.StringField_1>(
			"Baseline.StringField_1",
			10,
			(obj1) => {
				var obj2 = new TestCases.StringField_1 { Field_0 = obj1.Field_0 };
				return obj1.Field_0 == obj2.Field_0;
			},
			new TestCases.StringField_1 { Field_0 = "my_value" }
		);
	}

	public static TestCases.StringField_1 StringField_1(TestCases.StringField_1 obj1) {
		fsData data1;
		_serializer.TrySerialize(obj1, out data1);

		var str = fsJsonPrinter.CompressedJson(data1);

		TestCases.StringField_1 obj2 = null;
		var data2 = fsJsonParser.Parse(str);
		_serializer.TryDeserialize(data2, ref obj2);

		return obj2;
	}

	public static TestCases.StringField_1 StringField_1(TestCases.StringField_1 obj1) {
		var str = JsonConvert.SerializeObject(obj1);
		var obj2 = JsonConvert.DeserializeObject<TestCases.StringField_1>(str);
		return obj2;
	}*/
}
