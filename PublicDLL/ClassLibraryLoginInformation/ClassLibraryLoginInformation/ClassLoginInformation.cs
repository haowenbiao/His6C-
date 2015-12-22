namespace ClassLibraryLoginInformation
{
    public class ClassLoginInformation
    {
        public ClassLoginInformation(string valConnetionString,long valOperaterID)
        {
            ConnectionString = valConnetionString;
            OperaterID = valOperaterID;
        }

        public string ConnectionString { get; private set; }

        public long OperaterID { get; private set; }
    }
}
