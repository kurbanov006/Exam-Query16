

ServiceQuery serviceQuery = new ServiceQuery();

var res = serviceQuery.GetQuery1();
foreach (var i in res)
{
    System.Console.WriteLine($"{i.Orderid}, {i.Address}, {i.DateOfBirth}, {i.Email}, {i.FullName}, {i.OrderDate}, {i.PhoneNumber}");
}