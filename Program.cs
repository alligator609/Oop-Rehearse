
var encode = new VideoEncoder();
encode.RegisterNotificationChannel(new SmsNotificationChannel());
encode.RegisterNotificationChannel(new MailNotificationChannel());
encode.Encode(new Video());

public interface INotificationChannel
{
    void Send(Message message); 
}

public class Message
{

}

public class Video
{

}

public class MailNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("sending mail...");
    }
}


public class SmsNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("sending sms...");
    }
}

public class VideoEncoder
{
    private readonly List<INotificationChannel> _notificationChannels;

    public VideoEncoder()
    {
        _notificationChannels = new List<INotificationChannel>();
    }
    public void Encode(Video video)
    {
        foreach (var channel in _notificationChannels)
            channel.Send(new Message());
    }

    public void RegisterNotificationChannel (INotificationChannel channel)
    {
        _notificationChannels.Add(channel);
    }

}