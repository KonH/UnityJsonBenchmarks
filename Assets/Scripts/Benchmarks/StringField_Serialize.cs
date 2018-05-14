using System.Collections.Generic;
using UnityBenchmarkHarness;
using FullSerializer;
using Newtonsoft.Json;

public class StringField_Serialize : UnityBenchmark {
	TestCases.StringField _arg = new TestCases.StringField { Field = "my_value" };

	public override List<BenchmarkRunnerBase> CreateRunners() {
		return new List<BenchmarkRunnerBase> {
			new BenchmarkRunner<TestCases.StringField>(
				"BaseLine.StringField_Serialize",
				10,
				obj1 => {
					var str = $"{{\"Field\": \"{obj1.Field}\"}}";
					return str != null;
				},
				_arg
			),
			new BenchmarkRunner<TestCases.StringField>(
				"FullSerializer.StringField_Serialize",
				10,
				obj1 => {
					fsData data1;
					var serializer = new fsSerializer();
					serializer.TrySerialize(obj1, out data1);
					var str = fsJsonPrinter.CompressedJson(data1);
					return str != null;
				},
				_arg
			),
			new BenchmarkRunner<TestCases.StringField>(
				"JsonNet.StringField_Serialize",
				10,
				obj1 => {
					var str = JsonConvert.SerializeObject(obj1);
					return str != null;
				},
				_arg
			)
		};
	}
}
