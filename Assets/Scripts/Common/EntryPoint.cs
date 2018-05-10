using System.Collections;
using UnityEngine;
using UnityBenchmarkHarness;

public class EntryPoint : MonoBehaviour {
	
	IEnumerator Start() {
		Resources.UnloadUnusedAssets();
		yield return new WaitForSeconds(3.0f);
		Run();
	}

	void Run() {
		bool result = false;
		result = OneStringField();
		Debug.Log(result);
	}

	bool OneStringField() {
		var result = false;
		BenchmarkRunner.Run(
			"Baseline",
			10,
			(obj1) => {
				var obj2 = new TestCases.OneStringField { Field = obj1.Field };
				result = obj1.Field == obj2.Field;
			},
			new TestCases.OneStringField { Field = "my_value" }
		).WriteToConsole();

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
