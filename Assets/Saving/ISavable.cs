namespace Saving{
    public interface ISavable<T>{
        T CaptureState();
        void RestoreState(T load);
    }
}