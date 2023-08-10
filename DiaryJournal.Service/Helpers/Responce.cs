namespace DiaryJournal.Service.Helpers;

public class Responce<T>
{
    public long StatusCode { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
}
