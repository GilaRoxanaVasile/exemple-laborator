using System;
using L01_PSSC.Domain;
using CSharp.Choices;
using static L01_PSSC.Domain.Quantity;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var ContactList = new List<Contact2>();

Console.WriteLine("----");
Console.WriteLine("Nume: ");
string nume = Console.ReadLine();
Console.WriteLine("Prenume: ");
string prenume = Console.ReadLine();
Console.WriteLine("Nr. telefon: ");
string nrTel = Console.ReadLine();
Console.WriteLine("Adresa: ");
string adresa = Console.ReadLine();
var contact = new Contact(nume, prenume, nrTel, adresa);

Console.WriteLine("Cod produs: ");
string codProd = Console.ReadLine();
Console.WriteLine("Tip cantitate(0-kg, 1-unitate): ");
string tipCantitate = Console.ReadLine();
Console.WriteLine("Cantitate: ");
string cantitate = Console.ReadLine();
IQuantity qty = new QUnit(10);
string s = qty.Match(whenQKg: cantitate => "kg",
                     whenQUnit: cantitate => "unit");

var listOfProducs = new List<ListOfProducs>();
ListOfProducs newItem = new ListOfProducs(codProd, qty);
listOfProducs.Add(newItem);

Console.WriteLine(s);

ContactList.Add(new(contact, listOfProducs));


