namespace Note.Domain;

public class ErrorDto
{
    public string errorCode { get; set; }
    
    public string userMessage { get; set; }

    public string[] internalError { get; set; }
}