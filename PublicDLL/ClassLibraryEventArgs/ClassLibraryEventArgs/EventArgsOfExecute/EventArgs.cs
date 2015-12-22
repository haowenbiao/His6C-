using System;
using System.Xml;

namespace ClassLibraryEventArgs.EventArgsOfExecute
{
    public class EventArgsOfExecuteError : EventArgs
    {

        public EventArgsOfExecuteError(string valSystemErrorMessage, string valCustomErrorMessage)
        {
            _systemErrorMessage = valSystemErrorMessage;
            _customErrorMessage = valCustomErrorMessage;
        }

        public EventArgsOfExecuteError(string valXmlizedMessage)
        {
            FromXmlizedErrorMessage(valXmlizedMessage);
        }

        /* valXmlizedMessage:
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

    public delegate void ExecuteErrorHandler(object sender, EventArgsOfExecuteError e);

    public class EventArgsOfExecuteSucceed : EventArgs
    {

        public EventArgsOfExecuteSucceed(long valID, string valMessage)
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

    public delegate void ExecuteSucceedHandler(object sender, EventArgsOfExecuteSucceed e);

}
