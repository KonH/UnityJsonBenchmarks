using NUnit.Framework;
using Newtonsoft.Json;

public class JsonNetTests {

	[Test]
	public void StringField_1() {
		var obj1 = new TestCases.StringField_1 { Field_0 = "some_text" };
		var str = JsonConvert.SerializeObject(obj1);
		var obj2 = JsonConvert.DeserializeObject<TestCases.StringField_1>(str);
		Assert.True(obj1.Field_0 == obj2.Field_0);
	}
}
