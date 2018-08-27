using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class FitnessAPI : MonoBehaviour {
    public Text responseText;
    public AggregateBy aggregateBy = new AggregateBy();
    public BucketByTime bucket = new BucketByTime();
    public RootObject root = new RootObject();
    string json;
    string uri = "https://www.googleapis.com/fitness/v1/users/me/dataset:aggregate";
    public string postData = "";
    public string API_KEY = "AIzaSyCXdKnWPSEHsSwmUH4svAtt9nrC6i-_CKY";
    public string access_token = "ya29.Glu4BTAIZiwBwK2fmEJZLZTOiNzPk76jBzKCtfuX2Mg7KTonzzs0Yh3Z_yWhcARSUn9kIr61akx67bWMDgjvh3ecF_FJqzDkJSo93lUkNFDDwpgAUAqAfOr1Kv8N";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        responseText.text = json;
        Request();
        
    }
    public void Request()
    {
        aggregateBy.dataSourceId = "derived:com.google.step_count.delta:com.google.android.gms:estimated_steps";
        bucket.durationMillis = 86400000;
        root.startTimeMillis = 1438705622000;
        root.endTimeMillis = 1439310422000;
        json = JsonUtility.ToJson(aggregateBy) + JsonUtility.ToJson(bucket) + JsonUtility.ToJson(root);
    }


}


public class AggregateBy
{
    public string dataTypeName { get; set; }
    public string dataSourceId { get; set; }
}

public class BucketByTime
{
    public int durationMillis { get; set; }
}

public class RootObject
{
    public List<AggregateBy> aggregateBy { get; set; }
    public BucketByTime bucketByTime { get; set; }
    public long startTimeMillis { get; set; }
    public long endTimeMillis { get; set; }
}