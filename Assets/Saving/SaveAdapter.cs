namespace Saving{
    public class SaveAdapter{
        readonly string fileName;
        readonly ISaving saving;

        public SaveAdapter(string fileName){
            this.fileName = fileName;
            this.saving = new LocalSaving();
        }
        
        public void Save<T>(ISavable<T> savable){
            this.saving.Save(this.fileName, savable.CaptureState());
        }

        public async void Load<T>(ISavable<T> savable){
            var restoredObj = await this.saving.Load<T>(this.fileName);
            savable.RestoreState(restoredObj);
        }
    }
}