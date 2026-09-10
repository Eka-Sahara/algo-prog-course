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
System.Console.WriteLine($"Периметр: {roomPerimeter} м");


System.Console.WriteLine();
System.Console.WriteLine("Покупка ноутбука в рассрочку");
int laptopPrice = 65000;
int monthsCount = 12;
double interestRate = 0.08;
double totalWithInterest = laptopPrice * (1 + interestRate);
double monthlyPayment = totalWithInterest / monthsCount;
System.Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
System.Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
System.Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");
System.Console.WriteLine();
System.Console.WriteLine("Внимание деление int");
int totalStudents = 25;
int groupsCount = 4;
int studentsPerGroupWrong = totalStudents / groupsCount;
double studentsPerGroupCorrect = (double)totalStudents / groupsCount;
System.Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
System.Console.WriteLine($"25 / 4 как int: {studentsPerGroupCorrect}");
