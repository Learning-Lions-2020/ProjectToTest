using Moq;
using ProjectToTest;

namespace TestProject;

public class CustomerTests
{
    [Fact]
    public void NotifySupplier_SendMail_IfMessageStringIsReceived()
    {
        //arrange
        var moqMailService = new Mock<IMailService>();
        var customer = new Customer(moqMailService.Object);

        //act
        var message = "Hello I want to work with you!";
        var returnedMessage= customer.NotifySupplier(message);

        //assert
        moqMailService.Verify( m => m.SendMail(It.IsAny<string>()));
        Assert.Equal(message, returnedMessage);
    }
}