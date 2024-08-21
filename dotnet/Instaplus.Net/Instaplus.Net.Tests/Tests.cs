using Instaplus.Net.Requests;
using NUnit.Framework;

namespace Instaplus.Net.Tests;

[TestFixture]
public class Tests
{
    [Test]
    public void TestCreateApiInstance()
    {
        
        Assert.DoesNotThrow(() =>
        {
            var api = new InstaplusApi("{userId}", "{password}");
        });
    }
    
    [Test]
    public void TestCreateOrderRequest()
    {
        
        Assert.DoesNotThrow(() =>
        {
            var api = new InstaplusApi("{userId}", "{password}");
            var orderId = api.CreateOrder(new NewOrder()
            {
                ExternalId = "some-ref",
                Amount = 123.45m,
                Notes = "some notes",
                ValidityInHours = 2,
                ReceivingAccountId = "{accountId}"
            }).GetAwaiter().GetResult();
            
            Assert.That(orderId, Is.Not.Null);
        });
    }
    
    [Test]
    public void TestCreateGroupOrder()
    {
        
        Assert.DoesNotThrow(() =>
        {
            var api = new InstaplusApi("{userId}", "{password}");
            var groupId = api.CreateGroupOrder(new NewGroupOrder()
            {
                From = new []{ new NewGroupOrder.Order { Amount = 123.45m, ExternalId = "group-order-order-ref"}},
                Notes = "some notes",
                ValidityInHours = 2,
                ReceivingAccountId = "{accountId}"
            }).GetAwaiter().GetResult();
            
            Assert.That(groupId, Is.Not.Null);
        });
    }
    
    [Test]
    public void TestGetOrder()
    {
        
        Assert.DoesNotThrow(() =>
        {
            var api = new InstaplusApi("{userId}", "{password}");
            var order = api.GetOrder("{orderId}").GetAwaiter().GetResult();
            
            Assert.That(order, Is.Not.Null);
        });
    }
    
    [Test]
    public void TestGetGroupOrder()
    {
        
        Assert.DoesNotThrow(() =>
        {
            var api = new InstaplusApi("{userId}", "{password}");
            var groupOrder = api.GetGroupOrder("{groupOrderId}").GetAwaiter().GetResult();
            
            Assert.That(groupOrder, Is.Not.Null);
        });
    }
}