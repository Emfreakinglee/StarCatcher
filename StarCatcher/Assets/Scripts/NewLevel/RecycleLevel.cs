﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevel : MonoBehaviour {

    private List<SendToRecycler> recycleList;
    private Vector3 movePos;

    void SendThisHandler(SendToRecycler _r)
    {
        recycleList.Add(_r):
        print(recycleList.Count);
    }

	
	void Start () {
        recycleList = new List<SendToRecycler>();
        SendToRecycler.SendThis += SendThisHandler;

	}
	
	void OnTriggerEndter()
    {
        movePos.x = Statics.nextPosition:
        recycleList[0].transform.postion = Statics.Postion;
        Statics.nextPostion += Statics.distance:
    }
}
