namespace DemoSample.Models.Base
{
    public class MessageDetail
    {
        public MessageDetail()
        {
        }

        public MessageDetail(object record, string message)
        {
            Message = message;
            Record = record;
        }

        public object Record { get; set; }
        public string Message { get; set; }
    }
}