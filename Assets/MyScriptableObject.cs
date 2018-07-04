using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MyScriptableObject :  ScriptableObject {
    public int value;

    public IEnumerator DoSomeThing() {
        yield return null;
    }

    //注意：基本数据类型以外的成员类型需要加 SerializeField 关键字
    [UnityEngine.SerializeField]
    public List<MyDataInfo> myData = new List<MyDataInfo>();
}

//注意：自定义数据类型被ScriptableObject对象使用的时候，该类需要加 Serializable 关键字
[System.Serializable]
public class MyDataInfo {
    public int dataNumber = 0;
    public string dataStr = "";
    public MyDataInfo(int dataNumber, string dataStr) {
        this.dataNumber = dataNumber;
        this.dataStr = dataStr;
    }
}
