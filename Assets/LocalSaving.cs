using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using UnityEngine;

public class LocalSaving : ISaveHandler{
    public void Save<T>(string saveFile, T objectToSave){
        var tmp = new Dictionary<string, object>();
        var path = GetPath(saveFile);
        tmp[saveFile] = objectToSave;
        using (var stream = File.Open(path, FileMode.Create)){
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, tmp);
        }
    }

    public async Task<T> Load<T>(string saveFile){
        var path = GetPath(saveFile);
        var tmp = new Dictionary<string, object>();
        if (!File.Exists(path)){
            return default;
        }

        using (var stream = File.Open(path, FileMode.Open)){
            var formatter = new BinaryFormatter();
            tmp = (Dictionary<string, object>) formatter.Deserialize(stream);
        }

        return (T) tmp[saveFile];
    }

    string GetPath(string saveFile){
        return Path.Combine(Application.persistentDataPath, saveFile + ".oof");
    }
}