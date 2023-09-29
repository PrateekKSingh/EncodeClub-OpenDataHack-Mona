using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WebServerBasedAssetPositioning : MonoBehaviour
{ 
   
    PositionInfo posInfo = new PositionInfo();

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = scriptInitializedPosition;
         StartCoroutine(GetPosition());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator GetPosition() {
        UnityWebRequest www = UnityWebRequest.Get("http://localhost:3000/position");
        yield return www.SendWebRequest();
 
        if (www.result != UnityWebRequest.Result.Success) {
            Debug.Log(www.error);
        }
        else {
            // Show results as text
            Debug.Log(www.downloadHandler.text);
            posInfo = PositionInfo.CreateFromJSON(www.downloadHandler.text);
            Vector3 scriptInitializedPosition = new Vector3(posInfo.x,posInfo.y,posInfo.z);
            transform.position = scriptInitializedPosition;
 
            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
        }
     }
}

[System.Serializable]
public class PositionInfo
{
    public int x;
    public int y;
    public int z;

    public static PositionInfo CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<PositionInfo>(jsonString);
    }

    // Given JSON input:
    // {"name":"Dr Charles","lives":3,"health":0.8}
    // this example will return a PlayerInfo object with
    // name == "Dr Charles", lives == 3, and health == 0.8f.
}
