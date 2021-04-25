using System.Threading.Tasks;

public interface ISaveHandler{
    void Save<T>(string saveFile,T objectToSave);

    Task<T> Load<T>(string saveFile);
}