public class Adapter{
    readonly string fileName;
    readonly ISaveHandler saveHandler;

    public Adapter(string fileName){
        this.fileName = fileName;
        this.saveHandler = new LocalSaving();
    }


    public void Save<T>(ISavable<T> savable){
        this.saveHandler.Save(this.fileName, savable.CaptureState());
    }

    public async void Load<T>(ISavable<T> savable){
        var restoredObj = await this.saveHandler.Load<T>(this.fileName);
        savable.RestoreState(restoredObj);
    }
}