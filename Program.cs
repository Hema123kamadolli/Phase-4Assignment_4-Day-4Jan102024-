// See https://aka.ms/new-console-template for more information
using Assignment_4;
List<Product> products = new List<Product>()
{
    new Product() { Id=1,PName="Laptop",PBrand="Lenova",MfgDate=new DateTime(day:05,month:11,year:2019),ExpDate=new DateTime(day:15,month:05,year:2021)},
    new Product() { Id=2,PName="Mobile",PBrand="Samsung",MfgDate=new DateTime(day:13,month:08,year:2018),ExpDate=new DateTime(day:10,month:09,year:2020)},
    new Product() { Id=3,PName="Bluetooth",PBrand="Boot Rock-Z",MfgDate=new DateTime(day:23,month:05,year:2019),ExpDate=new DateTime(day:20,month:11,year:2022)},
    new Product() { Id=4,PName="Smart-Watch",PBrand="MI",MfgDate=new DateTime(day:16,month:01,year:2017),ExpDate=new DateTime(day:19,month:03,year:2020)},
    new Product() { Id=5,PName="Hair-Dryer",PBrand="Vega",MfgDate=new DateTime(day:21,month:05,year:2022),ExpDate=new DateTime(day:25,month:07,year:2024)},
};

Console.WriteLine("ID\t PName \t PBrand \t MfgDate \t\t ExpDate");
foreach (Product pro in products)
{
    Console.Write(pro.Id + "\t");
    Console.Write(pro.PName + "\t ");
    Console.Write(pro.PBrand + "\t ");
    Console.Write(pro.ExpDate.ToLongDateString()+"\t");
    Console.Write(pro.ExpDate.ToLongDateString());
    Console.WriteLine("\n");
}
