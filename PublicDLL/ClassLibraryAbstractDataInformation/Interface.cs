namespace ClassLibraryAbstractDataInformation
{
    public interface ISaveable
    {
        long save();
    }
    public interface ICheckable
    {
        bool check();
    }
    public interface IClearable
    {
        void clear();
    }
}
