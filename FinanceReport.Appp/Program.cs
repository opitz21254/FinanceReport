using System.Globalization;
using CsvHelper;
using FinanceReport.Core;

// I must run ```dotnet build``` every time I change the file path
using var reader = new StreamReader(@"C:\\Users\\opitz\\Code\\FinanceReport\\FinanceReport.Appp\\report.csv");

using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

var records = csv.GetRecords<Transaction>().ToList();


Console.WriteLine($"Loades {records.Count} transactions");