using UnityBenchmarkHarness;

public class EntryPoint : UnityBenchmarkRunner {
	
	protected override bool RunInternal() {
		var result = false;
		var runner = new BenchmarkRunner("Baseline");
		runner.Run(
			10,
			(obj1) => {
				var obj2 = new TestCases.OneStringField { Field = obj1.Field };
				result = obj1.Field == obj2.Field;
			},
			new TestCases.OneStringField { Field = "my_value" }
		);
		Runners.Add(runner);

		/*BenchmarkRunner.Run(
			"FullSerializerBenchmarks.OneStringField",
			10,
			(obj1) => {
				var obj2 = FullSerializerBenchmarks.OneStringField(obj1);
				result = obj1.Field == obj2.Field;
			},
			new TestCases.OneStringField { Field = "my_value" }
		).WriteToConsole();

		BenchmarkRunner.Run(
			"JsonNetBenchmarks.OneStringField",
			10,
			(obj1) => {
				var obj2 = JsonNetBenchmarks.OneStringField(obj1);
				result = obj1.Field == obj2.Field;
			},
			new TestCases.OneStringField { Field = "my_value" }
		).WriteToConsole();*/

		return result;
	}
}
