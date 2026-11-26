namespace Librarys.Commons;

public class OperationResult
{
    bool IsSuccess { get; }
    string Message { get; }
    public OperationResult(bool isSuccess, string message)
    {
        this.IsSuccess = isSuccess;
        this.Message = message;
    }  
}