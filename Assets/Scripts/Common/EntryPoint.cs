using UnityBenchmarkHarness;

public class EntryPoint : UnityBenchmarkRunner {
	
	protected override bool RunInternal() {
		var result = false;
		result = RunForStringField1(result);
		result = RunForStringField3(result);
		result = RunForStringField5(result);
		return result;
	}

	bool RunForStringField1(bool result) {
		var baseline = new BenchmarkRunner("Baseline.StringField_1");
		baseline.Run(
			10,
			(obj1) => {
				var obj2 = new TestCases.StringField_1 { Field_0 = obj1.Field_0 };
				result = obj1.Field_0 == obj2.Field_0;
			},
			new TestCases.StringField_1 { Field_0 = "my_value" }
		);
		Runners.Add(baseline);

		var fs = new BenchmarkRunner("FullSerializer.StringField_1");
		fs.Run(
			10,
			(obj1) => {
				var obj2 = FullSerializerBenchmarks.StringField_1(obj1);
				result = obj1.Field_0 == obj2.Field_0;
			},
			new TestCases.StringField_1 { Field_0 = "my_value" }
		);
		Runners.Add(fs);

		var jsonNet = new BenchmarkRunner("JsonNet.StringField_1");
		jsonNet.Run(
			10,
			(obj1) => {
				var obj2 = JsonNetBenchmarks.StringField_1(obj1);
				result = obj1.Field_0 == obj2.Field_0;
			},
			new TestCases.StringField_1 { Field_0 = "my_value" }
		);
		Runners.Add(jsonNet);

		return result;
	}

	bool RunForStringField3(bool result) {
		var baseline = new BenchmarkRunner("Baseline.StringField_3");
		baseline.Run(
			10,
			(obj1) => {
				var obj2 = new TestCases.StringField_3 {
					Field_0 = obj1.Field_0,
					Field_1 = obj1.Field_1,
					Field_2 = obj1.Field_2
				};
				result = obj1.Field_0 == obj2.Field_0;
			},
			new TestCases.StringField_3 {
				Field_0 = "my_value_0",
				Field_1 = "my_value_1",
				Field_2 = "my_value_2"
			}
		);
		Runners.Add(baseline);

		var fs = new BenchmarkRunner("FullSerializer.StringField_3");
		fs.Run(
			10,
			(obj1) => {
				var obj2 = FullSerializerBenchmarks.StringField_3(obj1);
				result = obj1.Field_0 == obj2.Field_0;
			},
			new TestCases.StringField_3 {
				Field_0 = "my_value_0",
				Field_1 = "my_value_1",
				Field_2 = "my_value_2"
			}
		);
		Runners.Add(fs);

		var jsonNet = new BenchmarkRunner("JsonNet.StringField_3");
		jsonNet.Run(
			10,
			(obj1) => {
				var obj2 = JsonNetBenchmarks.StringField_3(obj1);
				result = obj1.Field_0 == obj2.Field_0;
			},
			new TestCases.StringField_3 {
				Field_0 = "my_value_0",
				Field_1 = "my_value_1",
				Field_2 = "my_value_2"
			}
		);
		Runners.Add(jsonNet);

		return result;
	}

	bool RunForStringField5(bool result) {
		var baseline = new BenchmarkRunner("Baseline.StringField_5");
		baseline.Run(
			10,
			(obj1) => {
				var obj2 = new TestCases.StringField_5 {
					Field_0 = obj1.Field_0,
					Field_1 = obj1.Field_1,
					Field_2 = obj1.Field_2,
					Field_3 = obj1.Field_3,
					Field_4 = obj1.Field_4
				};
				result = obj1.Field_0 == obj2.Field_0;
			},
			new TestCases.StringField_5 {
				Field_0 = "my_value_0",
				Field_1 = "my_value_1",
				Field_2 = "my_value_2",
				Field_3 = "my_value_3",
				Field_4 = "my_value_4"
			}
		);
		Runners.Add(baseline);

		var fs = new BenchmarkRunner("FullSerializer.StringField_5");
		fs.Run(
			10,
			(obj1) => {
				var obj2 = FullSerializerBenchmarks.StringField_5(obj1);
				result = obj1.Field_0 == obj2.Field_0;
			},
			new TestCases.StringField_5 {
				Field_0 = "my_value_0",
				Field_1 = "my_value_1",
				Field_2 = "my_value_2",
				Field_3 = "my_value_3",
				Field_4 = "my_value_4"
			}
		);
		Runners.Add(fs);

		var jsonNet = new BenchmarkRunner("JsonNet.StringField_5");
		jsonNet.Run(
			10,
			(obj1) => {
				var obj2 = JsonNetBenchmarks.StringField_5(obj1);
				result = obj1.Field_0 == obj2.Field_0;
			},
			new TestCases.StringField_5 {
				Field_0 = "my_value_0",
				Field_1 = "my_value_1",
				Field_2 = "my_value_2",
				Field_3 = "my_value_3",
				Field_4 = "my_value_4"
			}
		);
		Runners.Add(jsonNet);

		return result;
	}
}
