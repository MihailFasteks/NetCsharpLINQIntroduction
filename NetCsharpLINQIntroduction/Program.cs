// See https://aka.ms/new-console-template for more information
using NetCsharpLINQIntroduction;

/*int[] Mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
foreach (var val in Mas)
    Console.Write(val+" ");
Console.WriteLine();*/
//task1
/*var selected = from t in Mas // определяем каждый объект из teams как t
                     select t; // выбираем объект

foreach (var t in selected)
    Console.Write(t + " ");
Console.WriteLine();

selected = from t in Mas
           where t % 2 == 0
           orderby t
           select t;

foreach (var t in selected)
    Console.Write(t + " ");
Console.WriteLine();

selected = from t in Mas
           where t % 2 != 0
           orderby t
           select t;

foreach (var t in selected)
    Console.Write(t + " ");
Console.WriteLine();

int number = 5;
selected = from t in Mas
           where t >number
           orderby t
           select t;

foreach (var t in selected)
    Console.Write(t + " ");
Console.WriteLine();

int num1 = 3;
int num2 = 8;

selected = from t in Mas
           where t > num1 && t < num2
           orderby t
           select t;

foreach (var t in selected)
    Console.Write(t + " ");
Console.WriteLine();

selected = from t in Mas
           where t %7==0
           orderby t
           select t;

foreach (var t in selected)
    Console.Write(t + " ");
Console.WriteLine();

selected = from t in Mas
           where t % 8 == 0
           orderby t descending
           select t;

foreach (var t in selected)
    Console.Write(t + " ");
Console.WriteLine();*/


//task2
/*string[] cities = { "Барселона", " Киев", " Мадрид", "Манчестер ", "Одесса", "Кишинев", "Анапа" };
var selectedCities = from t in cities
           select t;

foreach (var t in selectedCities)
    Console.Write(t + " ");
Console.WriteLine();
int l = 4;
 selectedCities = cities.Where(t => t.Length-1==l);

foreach (var t in selectedCities)
    Console.Write(t + " ");
Console.WriteLine();

selectedCities = cities.Where(t => t.ToUpper().StartsWith("А")).OrderBy(t => t);
foreach (var t in selectedCities)
    Console.Write(t + " ");
Console.WriteLine();

selectedCities = cities.Where(t => t.ToUpper().EndsWith("М")).OrderBy(t => t);
foreach (var t in selectedCities)
    Console.Write(t + " ");
Console.WriteLine();

selectedCities = cities.Where(t => t.ToUpper().StartsWith("N")&& t.ToUpper().EndsWith("K")).OrderBy(t => t);
foreach (var t in selectedCities)
    Console.Write(t + " ");
Console.WriteLine();
selectedCities = cities.Where(t => t.StartsWith("Ne")).OrderByDescending(t => t);
foreach (var t in selectedCities)
    Console.Write(t + " ");
Console.WriteLine();*/

//task3


Student stud1 = new Student("Boris", "Afanasof", "ITstep", 24);
Student stud2 = new Student("Anna", "Sergeeva", "ITstep", 23);
Student stud3 = new Student("Artem", "Gorenko", "ITstep", 21);
Student stud4 = new Student("Konstantin", "Kashencov", "ITstep", 22);

Student[] studs = { stud1, stud2, stud3, stud4 };

var selectedStuds = studs.Where(t => t.Name == "Boris");
foreach (var t in selectedStuds)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedStuds = studs.Where(t => t.Lastname.StartsWith("Bro"));
foreach (var t in selectedStuds)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();


selectedStuds = studs.Where(t => t.age>19);
foreach (var t in selectedStuds)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedStuds = studs.Where(t => t.age > 19 && t.age<23);
foreach (var t in selectedStuds)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedStuds = studs.Where(t => t.univName == "MIT");
foreach (var t in selectedStuds)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();

selectedStuds = studs.Where(t => t.univName == "Oxford" && t.age>18).OrderByDescending(t=>t);
foreach (var t in selectedStuds)
    Console.WriteLine(t + " ");
Console.WriteLine();
Console.WriteLine();