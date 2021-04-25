using System;
using System.Collections.Generic;
using UnityEngine;

public class TestSaving : MonoBehaviour, ISavable<Dictionary<string, int>>{
    Adapter adapter;


    Dictionary<string, int> Gold{ get; set; }

    void Start(){
        this.adapter = new Adapter(this.name);
        this.Gold = new Dictionary<string, int>(){
            ["Alex"] = 0,
            ["John"] = 0,
            ["Clara"] = 0,
            ["Max"] = 0,
            ["Selena"] = 0,
        };
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.W)){
            this.Gold["Alex"]++;
            this.Gold["John"] += 2;
            this.Gold["Clara"] += 3;
            this.Gold["Max"] += 4;
            this.Gold["Selena"] += 5;
        }

        if (Input.GetKeyDown(KeyCode.S)){
            this.adapter.Save(this);
        }

        if (Input.GetKeyDown(KeyCode.L)){
            this.adapter.Load(this);
        }
    }

    public Dictionary<string, int> CaptureState(){
        foreach (var i in this.Gold){
            print($"Key: {i.Key} Value: {i.Value}");
        }

        return this.Gold;
    }

    public void RestoreState(Dictionary<string, int> load){
        this.Gold = load;

        foreach (var i in this.Gold){
            print($"Key: {i.Key} Value: {i.Value}");
        }
    }
}