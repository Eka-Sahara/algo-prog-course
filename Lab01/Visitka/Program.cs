string name = "Сахабутдинова Екатерина Максимовна";
const string GroupName = "ИСП-252";
int courseNumber = 2;
string birthday = "16.07.2009";
int workOne = 4;
int workTwo = 4;
int workThree = 5;
bool schoolarship = true;   //проверяем достоин ли студент стипендии
int studyWeek = 15;

double gpa = (workOne + workTwo + workThree) / 3;   //считаем средний балл

//выводим информацию
System.Console.WriteLine($"  ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
System.Console.WriteLine($"ФИО:       {name}");
System.Console.WriteLine($"Группа:    {GroupName}");
System.Console.WriteLine($"Курс:      {courseNumber}");
System.Console.WriteLine($"Дата рождения: {birthday}");
System.Console.WriteLine();
System.Console.WriteLine($"Средний балл за 3 работы: {gpa}");
System.Console.WriteLine($"Стипендия положена (>= 4.0): {schoolarship}");
System.Console.WriteLine();
System.Console.WriteLine($"Учебных недель осталось в семестре: {studyWeek}");

