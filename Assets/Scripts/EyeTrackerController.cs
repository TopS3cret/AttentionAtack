using UnityEngine;
using System.Collections;
using System;
using TETCSharpClient;
using TETCSharpClient.Data;

public class EyeTrackerController : MonoBehaviour, IGazeListener {
    
    // Use this for initialization
    void Start () {
        GazeManager.Instance.Activate(GazeManager.ApiVersion.VERSION_1_0, GazeManager.ClientMode.Push);
        
        GazeManager.Instance.AddGazeListener(this);
    }

    // Update is called once per frame
    void Update(){

    }

    public void OnGazeUpdate(GazeData gazeData){
        Debug.Log(gazeData.SmoothedCoordinates);
    }
}
