using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class Test : MonoBehaviour {

	class MyClass {
		public char[] Array = new char[256];
	}

	IEnumerator Start () {
		yield return new WaitForSeconds(1.0f);

		var count = 0;
		var usedDiff = 0L;
		var memDiff = 0L;

		List<MyClass> objs = new List<MyClass>(1024);

		System.GC.Collect();
		var memBefore = System.GC.GetTotalMemory(false);
		var usedSizeBefore = Profiler.GetMonoUsedSizeLong();


		while ( true ) {
			System.GC.Collect();

			count++;

			objs.Add(new MyClass());

			var usedSizeAfter = Profiler.GetMonoUsedSizeLong();
			var memAfter = System.GC.GetTotalMemory(false);

			usedDiff = usedSizeAfter - usedSizeBefore;
			memDiff = memAfter - memBefore;

			if ( (usedDiff > 0) || (memDiff > 0) ) {
				break;
			}
		}
		Debug.Log($"Created {count} objects, usedDiff = {usedDiff}, memDiff = {memDiff}");
		Debug.Log(objs);

		// Result is:
		// Created 21 objects, usedDiff = 4096, memDiff = 4096
		// But we want to track accurate diff for each object was created :(
	}
}
