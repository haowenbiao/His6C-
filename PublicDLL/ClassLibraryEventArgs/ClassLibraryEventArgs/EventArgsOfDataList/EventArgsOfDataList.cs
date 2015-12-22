using System;

namespace ClassLibraryEventArgs.EventArgsOfDataList
{
    public class EventArgsOfAfterDataListLoadSucceed : EventArgs
    {

        public EventArgsOfAfterDataListLoadSucceed(object valDataSource)
        {
            DataSource = valDataSource;
        }

        public object DataSource { get; private set; }
    }

    public delegate void AfterDataListLoadSucceedHandler(object sender, EventArgsOfAfterDataListLoadSucceed e);

    public class EventArgsOfAfterDataListLoadFail : EventArgs
    {
        public EventArgsOfAfterDataListLoadFail(string systemErrorMessage)
        {
            SystemErrorMessage = systemErrorMessage;
        }

        public string SystemErrorMessage { get; private set; }
    }

    public delegate void AfterDataListLoadFailHandler(object sender, EventArgsOfAfterDataListLoadFail e);

    public class EventArgsOfBeforeDataListLoad : EventArgs
    {
    }

    public delegate void BeforeDataListLoadHandler(object sender, EventArgsOfBeforeDataListLoad e);

    public class EventArgsOfDataListItemSelected
    {
        public EventArgsOfDataListItemSelected(long valID)
        {
            ID = valID;
        }

        public long ID { get; private set; }
    }

    public delegate void DataListItemSelectedHandler(object sender, EventArgsOfDataListItemSelected e);
}
