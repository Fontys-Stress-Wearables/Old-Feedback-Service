public class NatsMessage<T>
{
    public string origin { get; set; } = "feedback_service";
    public string target { get; set; }
    public T message { get; set; }
}