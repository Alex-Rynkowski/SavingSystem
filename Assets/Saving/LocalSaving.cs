using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;

namespace Saving{
    public class LocalSaving : ISaving{
        public void Save<T>(string saveFile, T objectToSave){
            var fileDictionary = new Dictionary<string, object>();
            var path = GetPath(saveFile);
            Debug.Log($"Saving to: {path}");

            fileDictionary[saveFile] = JsonConvert.SerializeObject(objectToSave);

            using var stream = File.Open(path, FileMode.Create);
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, fileDictionary);
        }

        public async Task<T> Load<T>(string saveFile){
            var path = GetPath(saveFile);
            Debug.Log($"Loading from: {path}");
            if (!File.Exists(path)){
                return default;
            }

            using var stream = File.Open(path, FileMode.Open);
            var formatter = new BinaryFormatter();
            var fileDictionary = (Dictionary<string, object>) formatter.Deserialize(stream);

            return JsonConvert.DeserializeObject<T>(fileDictionary[saveFile].ToString());
        }

        string GetPath(string saveFile){
            return Path.Combine(Application.persistentDataPath, saveFile + ".save");
        }
    }
}