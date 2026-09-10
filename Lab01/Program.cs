string myName = "Екатерина Сахабутдинова";
string groupName = "ИСП-252";
int courseNumber = 2;
double averageGrade = 4.6;
bool isBudget = true;
System.Console.WriteLine("Знакомство");
System.Console.WriteLine($"Студент: {myName}");
System.Console.WriteLine($"Студент: {groupName}");
System.Console.WriteLine($"Курс: {courseNumber}");
System.Console.WriteLine($"Средний балл: {averageGrade}");
System.Console.WriteLine($"Бюджетное место: {isBudget}");


System.Console.WriteLine();
System.Console.WriteLine("Ремонт: комнта");
double roomWidth = 3.5;
double roomLength = 4.2;
double roomArea = roomWidth * roomLength;
double roomPerimeter = (roomWidth + roomLength) * 2;
System.Console.WriteLine($"Ширина: {roomWidth} м, длинна: {roomLength} м");
System.Console.WriteLine($"Площадь: {roomArea} кв.м");
System.Console.WriteLine($"Периметр: {roomPerimeter} м");       //расчитывает площадь и периметр комнаты


System.Console.WriteLine();
System.Console.WriteLine("Покупка ноутбука в рассрочку");
int laptopPrice = 65000;
int monthsCount = 12;
double interestRate = 0.08;
double totalWithInterest = laptopPrice * (1 + interestRate);
double monthlyPayment = totalWithInterest / monthsCount;
System.Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
System.Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
System.Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");     //рассчитывает цену самого ноутбука, цену с процентами и сколько рублей в месяц выплачивать


System.Console.WriteLine();
System.Console.WriteLine("Внимание деление int");
int totalStudents = 25;
int groupsCount = 4;
int studentsPerGroupWrong = totalStudents / groupsCount;
double studentsPerGroupCorrect = (double)totalStudents / groupsCount;
System.Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
System.Console.WriteLine($"25 / 4 как int: {studentsPerGroupCorrect}");


System.Console.WriteLine();
System.Console.WriteLine("Способы собрать строку");
string firstName = "Екатерина";
string lastName = "Сахабутдинова";
string fullNameConcat = firstName + " " + lastName;
string fullNameInterp = $"{firstName} {lastName}";
string fullNameConcatMethod = string.Concat(firstName, " ", lastName);
System.Console.WriteLine(fullNameConcat);
System.Console.WriteLine(fullNameInterp);
System.Console.WriteLine(fullNameConcatMethod);
System.Console.WriteLine($"Все три строки равны:{fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");

System.Console.WriteLine();
System.Console.WriteLine("Константы");
const double VatRate = 0.20;
const string collegeName = "ВФ ВолГУ";
double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate);
System.Console.WriteLine($"Учебное заведение: {collegeName}");
System.Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate:P0}):{priceWithVat}");      //находит стоимость обучения в колледже

