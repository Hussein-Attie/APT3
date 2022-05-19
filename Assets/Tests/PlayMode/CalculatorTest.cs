using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CalculatorTest
{
    
    [UnityTest]
    public IEnumerator CalculateSum()
    {
        var gameObject = new GameObject();
        var calculator = gameObject.AddComponent<Calculator>();
        
        yield return new WaitForSecondsRealtime(0.2f);
        Assert.AreEqual(calculator.x + calculator.y, calculator.sum);
    }
}
