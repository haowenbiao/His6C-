using System;

namespace ClassLibraryEventArgs.EventArgsOfRecord
{
    /// <summary>
    /// 有关单据明细的事件参数
    /// </summary>
    public class EventArgsOfRecordDetail : EventArgs
    {
        public EventArgsOfRecordDetail(object valObject)
        {
            m_DetailItem = valObject;
        }

        private object m_DetailItem;
        public object DetailItem
        {
            get { return m_DetailItem; }
        }
    }
}
