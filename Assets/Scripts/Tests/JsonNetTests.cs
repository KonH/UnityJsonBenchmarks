using NUnit.Framework;
using Newtonsoft.Json;

public class JsonNetTests {

	[Test]
	public void OneStringField() {
		var obj1 = new TestCases.OneStringField { Field = "some_text" };
		var str = JsonConvert.SerializeObject(obj1);
		var obj2 = JsonConvert.DeserializeObject<TestCases.OneStringField>(str);
		Assert.True(obj1.Field == obj2.Field);
	}
}
