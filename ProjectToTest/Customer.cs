namespace ProjectToTest;

public class Customer
{
    private readonly IMailService _mailService;

    public Customer(IMailService mailService)
    {
        this._mailService = mailService;
    }

    public string NotifySupplier(string message)
    {
        _mailService.SendMail(message);
        return message;
    }

    // add aditional methods that will fail initially but are testable
    // fix the implementation until tests are green -> TDD Aproach

    public double CalculateWhatEver()
    {
        return 0;
    }
}
