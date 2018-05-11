using UnityBenchmarkHarness;

public class EntryPoint : UnityBenchmarkRunner {
	
	protected override bool RunInternal() {
		var result = false;
		var baseline = new BenchmarkRunner("Baseline.OneStringField");
		baseline.Run(
			10,
			(obj1) => {
				var obj2 = new TestCases.OneStringField { Field = obj1.Field };
				result = obj1.Field == obj2.Field;
			},
			new TestCases.OneStringField { Field = "my_value" }
		);
		Runners.Add(baseline);

		var fs = new BenchmarkRunner("FullSerializerBenchmarks.OneStringField");
		fs.Run(
			10,
			(obj1) => {
				var obj2 = FullSerializerBenchmarks.OneStringField(obj1);
				result = obj1.Field == obj2.Field;
			},
			new TestCases.OneStringField { Field = "my_value" }
		);
		Runners.Add(fs);

		var jsonNet = new BenchmarkRunner("JsonNetBenchmarks.OneStringField");
		jsonNet.Run(
			10,
			(obj1) => {
				var obj2 = JsonNetBenchmarks.OneStringField(obj1);
				result = obj1.Field == obj2.Field;
			},
			new TestCases.OneStringField { Field = "my_value" }
		);
		Runners.Add(jsonNet);

		return result;
	}
}
