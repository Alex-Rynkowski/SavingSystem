using System.Threading.Tasks;

namespace Saving{
    public interface ISaving{
        void Save<T>(string saveFile,T objectToSave);

        Task<T> Load<T>(string saveFile);
    }
}