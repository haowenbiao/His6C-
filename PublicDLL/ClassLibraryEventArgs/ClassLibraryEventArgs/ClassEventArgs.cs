using System;
using System.Xml;

namespace ClassLibraryEventArgs
{
    #region 自定义代理

    [Obsolete("The Class is time out!")]
    public delegate void callBackNoParameterHandle();

    [Obsolete("The Class is time out!")]
    public delegate void callBackOneParameterHandle(object valObj);

    [Obsolete("The Class is time out!")]
    public delegate void callBackTowParameterHandle(object valObj1, object valObj2);

    #endregion

    [Obsolete("The Class is time out！")]
    public class EventArgsOfError : EventArgs
    {

        public EventArgsOfError(string valSystemErrorMessage, string valCustomErrorMessage)
        {
            _systemErrorMessage = valSystemErrorMessage;
            _customErrorMessage = valCustomErrorMessage;
        }

        public EventArgsOfError(string valXmlizedMessage)
        {
            FromXmlizedErrorMessage(valXmlizedMessage);
        }

        /* valMessage:
            <Record>
              <RecordInformations>
              </RecordInformations>
              <RecordLists>
                <RecordList>

                </RecordList>
              </RecordLists>
              <SqlStringID>
                <SqlStringIDLoad></SqlStringIDLoad>
                <SqlStringIDAdd></SqlStringIDAdd>
                <SqlStringIDEdit></SqlStringIDEdit>
                <SqlStringIDRemove></SqlStringIDRemove>
              </SqlStringID>
              <Message>
                <Succeed>
                  <ID></ID>
                  <Message></Message>
                </Succeed>
                <Error>
                  <ErrorNumber></ErrorNumber>
                  <SystemErrorMessage></SystemErrorMessage>
                  <CustomErrorMessage></CustomErrorMessage>
                </Error>
              </Message>
            </Record>
         */
        private void FromXmlizedErrorMessage(string valXmlizedMessage)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(valXmlizedMessage);
                XmlNode xmlError = xmlDocument.SelectSingleNode(@"//Record/Message/Error");
                if (xmlError == null)
                {
                    return;
                }
                // ReSharper disable PossibleNullReferenceException
                _errorNumber = Convert.ToInt64(xmlError["ErrorNumber"].InnerText);
                _systemErrorMessage = xmlError["SystemErrorMessage"].InnerText;
                _customErrorMessage = xmlError["CustomErrorMessage"].InnerText;
                // ReSharper restore PossibleNullReferenceException
            }
            catch
            {
                return;
            }
        }

        private long _errorNumber;
        public long ErrorNumber
        {
            get
            {
                return _errorNumber;
            }
        }

        private string _customErrorMessage;
        public string CustomErrorMessage
        {
            get
            {
                return _customErrorMessage;
            }
        }

        private string _systemErrorMessage;
        public string SystemErrorMessage
        {
            get
            {
                return _systemErrorMessage;
            }
        }
    }
    [Obsolete("The Class is time out!")]
    public delegate void ErrorHandler(object sender, EventArgsOfError e);
    [Obsolete("The Class is time out!")]
    public class EventArgsOfExecuteSucceed : EventArgs
    {

        public EventArgsOfExecuteSucceed(long valID,string valMessage)
        {
            _ID = valID;
            _message = valMessage;
        }

        public EventArgsOfExecuteSucceed(string valXmlizedMessage)
        {
            FromFromXmlizedMessage(valXmlizedMessage);
        }

        /*valXmlizedMessage:
        <Record>
          <RecordInformations>
          </RecordInformations>
          <RecordLists>
            <RecordList>

            </RecordList>
          </RecordLists>
          <SqlStringID>
            <SqlStringIDLoad></SqlStringIDLoad>
            <SqlStringIDAdd></SqlStringIDAdd>
            <SqlStringIDEdit></SqlStringIDEdit>
            <SqlStringIDRemove></SqlStringIDRemove>
          </SqlStringID>
          <Message>
            <Succeed>
              <ID></ID>
              <Message></Message>
            </Succeed>
            <Error>
              <ErrorNumber></ErrorNumber>
              <SystemErrorMessage></SystemErrorMessage>
              <CustomErrorMessage></CustomErrorMessage>
            </Error>
          </Message>
        </Record> 
         */
        private void FromFromXmlizedMessage(string valXmlizedMessage)
        {
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(valXmlizedMessage);
                XmlNode xmlError = xmlDocument.SelectSingleNode(@"//Record/Message/Succeed");
                if (xmlError == null)
                {
                    return;
                }
                // ReSharper disable PossibleNullReferenceException
                _ID = Convert.ToInt64(xmlError["ID"].InnerText);
                _message = xmlError["Message"].InnerText;
                _additionalInformation = valXmlizedMessage;
                // ReSharper restore PossibleNullReferenceException
            }
            catch
            {
                return;
            }
        }

        private object _additionalInformation;
        public object AdditionalInformation
        {
            get
            {
                return _additionalInformation;
            }
        }

        private long _ID;
        public long ID
        {
            get
            {
                return _ID;
            }
        }

        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
        }
    }
    [Obsolete("The Class is time out!")]
    public delegate void ExecuteSucceedHandler(object sender, EventArgsOfExecuteSucceed e);
    [Obsolete("The Class is time out!")]
    public class EventArgsOfSizeStateChanged:EventArgs
    {
    }
    [Obsolete("The Class is time out!")]
    public delegate void SizeStateChangedHandler(object sender, EventArgsOfSizeStateChanged e);
    [Obsolete("The Class is time out!")]
    public class EventArgsOfDataListItemSelected
    {
        private readonly long _ID;

        public EventArgsOfDataListItemSelected(long valID)
        {
            _ID = valID;
        }

        public long ID
        {
            get{ return _ID;}
        }
    }
    [Obsolete("The Class is time out!")]
    public delegate void DataListItemSelectedHandler(object sender, EventArgsOfDataListItemSelected e);
    
    #region DataListLoad
    [Obsolete("The Class is time out!")]
    public class EventArgsOfAfterDataListLoadSucceed:EventArgs
    {

        public EventArgsOfAfterDataListLoadSucceed(object valDataSource)
        {
            _dataSource = valDataSource;
        }

        private readonly object _dataSource;

        public object DataSource
        {
            get
            {
                return _dataSource;
            }
        }
    }
    [Obsolete("The Class is time out!")]
    public delegate void AfterDataListLoadSucceedHandler(object sender, EventArgsOfAfterDataListLoadSucceed e);
    [Obsolete("The Class is time out!")]
    public class EventArgsOfAfterDataListLoadFail:EventArgs
    {
        public EventArgsOfAfterDataListLoadFail(string systemErrorMessage)
        {
            _systemErrorMessage = systemErrorMessage;
        }

        private readonly string _systemErrorMessage;

        public string SystemErrorMessage
        {
            get
            {
                return _systemErrorMessage;
            }
        }
    }
    [Obsolete("The Class is time out!")]
    public delegate void AfterDataListLoadFailHandler(object sender, EventArgsOfAfterDataListLoadFail e);
    [Obsolete("The Class is time out!")]
    public class EventArgsOfBeforeDataListLoad:EventArgs
    {
    }
    [Obsolete("The Class is time out!")]
    public delegate void BeforeDataListLoadHandler(object sender, EventArgsOfBeforeDataListLoad e);

    #endregion

    #region MedicineStock
    [Obsolete("The Class is time out!")]
    public class EventArgsWithObject : EventArgs
    {
        public EventArgsWithObject(object sender)
        {
            _object = sender;
        }

        private object _object;
        public object Object 
        {
            get
            {
                return _object;
            }
        }
    }
    [Obsolete("The Class is time out!")]
    public delegate void EventWithObjectHandler(object sender, EventArgsWithObject e);
    
    #endregion
}
