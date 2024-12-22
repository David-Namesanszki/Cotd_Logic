namespace Cotd_Logic.BL.Common;

public struct CommandResult
{
	public CommandResult(string message, bool result)
	{
		Message = message;
		Result = result;
	}

    public CommandResult(bool result)
    {
        Result = result;
    }

    public string? Message { get; }
    public bool Result { get; }
}
