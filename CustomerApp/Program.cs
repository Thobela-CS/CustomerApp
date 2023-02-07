using CustomerApp.Models;

var customers = new List<Customer>()
{
    new Customer
    {
        Name = "Collen",
        DateOfBirth = new DateTime(1990, 08, 13),
        Gender = "Male"
    },
     new Customer
    {
        Name = "Themba",
        DateOfBirth = new DateTime(1994, 08, 13),
        Gender = "Male"
    }
};

var males = customers.Where(x => x.Gender == "Male").ToList();

if(males != null && males.Any())
{
    var malesAvgAge = GetAvarageAgeFromList(males);
    Console.WriteLine("Males Avarage Age: " + malesAvgAge);
}

var females = customers.Where(x => x.Gender == "Female").ToList();
if (females != null && females.Any())
{
    var femalesAvgAge = GetAvarageAgeFromList(females);
    Console.WriteLine("Females Avarage Age: " + femalesAvgAge);
}

var customersAvg = GetAvarageAgeFromList(customers.ToList());
Console.WriteLine("Customers avarage age: " + customersAvg);

Console.ReadLine();


double GetAvarageAgeFromList(List<Customer> customers)
{
    var totalAge = customers.Sum(x => DateTime.Now.Year - x.DateOfBirth.Year);
    return totalAge / customers.Count();
}
