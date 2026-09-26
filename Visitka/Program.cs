string namecarta = "Визитная карточка Студента";
string FioStudenta = "Мягков Владимир Дмитриевич";
string nameGroup = "ИСП-254";
int courseNumber = 2;
string Spicialnost = "09.02.07";
double averageGrade = 4.33;
//Оценки за 3 работы
double grade1 = 4.5;
double grade2 = 5.0;
double grade3 = 4.3;
bool isStipend = true;
int Ychebnuh = 16;
//Максимальный балл
const double MaxGrade = 5.0;
//Вычисление среднего балла
double average = (grade1 + grade2 + grade3) / 3;

// Вывод визитки 
Console.WriteLine("========================================"); 
Console.WriteLine($"     {namecarta}"); 
Console.WriteLine("========================================"); 
//Информация о студенте
Console.WriteLine($"ФИО:        {FioStudenta}");
Console.WriteLine($"Группа:     {nameGroup}");
Console.WriteLine($"Курс:       {courseNumber}");
Console.WriteLine($"Специальность: {Spicialnost}");
Console.WriteLine("========================================"); 
//Его средний балл, высший балл, положение степендии и кол-во учебных недель
Console.WriteLine($"Средний балл за 3 работы: {averageGrade}");
Console.WriteLine($"Максимальная оценка:      {MaxGrade}");
Console.WriteLine($"Степендия положена (>= 4.0): {isStipend}");
Console.WriteLine($"Учебных  недель осталсось в семестре: {Ychebnuh}");
Console.WriteLine("========================================"); 