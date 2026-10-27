// Console.Write("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];
// int sum = 0;
// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
//     sum += grades[i];
// }
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }
// double avg = (double)sum / grades.Length;
// Console.WriteLine($"Средний балл группы: {avg:F2}");


// int[] points = { 4, 7, 2, 9, 5 };
// for (int i = 0; i < points.Length; i++)
// {
// if (points[i] < 10)
// {
// points[i] = points[i] + 1;
// }
// }
// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }

// int[] gradesToSort = { 4, 5, 3, 5, 4, 2 };
// for (int i = 0; i < gradesToSort.Length - 1; i++)
// {
// for (int j = 0; j < gradesToSort.Length - 1 - i; j++)
// {
// if (gradesToSort[j] < gradesToSort[j + 1])
// {
// int temp = gradesToSort[j];
// gradesToSort[j] = gradesToSort[j + 1];
// gradesToSort[j + 1] = temp;
// }
// }
// }
// foreach (int grade in gradesToSort)
// {
//     Console.WriteLine(grade);
// }


// int[] slots = GenerateScheduleSlots(6);
// foreach (int slot in slots)
// {
// Console.WriteLine(slot);
// }
// int[] evenSlots = GenerateEvenSlots(6);
// foreach (int slot in evenSlots)
// {
//     Console.WriteLine(slot);
// }


// int[] gradesArraySort = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(gradesArraySort);
// foreach (int grade in gradesArraySort)
// {
// Console.WriteLine(grade);
// }


// Console.Write("Введите число N для задачи А: ");
// int nTaskA = int.Parse(Console.ReadLine());
// int[] arrayA = new int[nTaskA];
// for (int i = 0; i < arrayA.Length; i++)
// {
// arrayA[i] = (i + 1) * (i + 1);
// }
// foreach (int val in arrayA)
// {
// Console.WriteLine(val);
// }


// int[] arrayB = { 5, -3, 0, -1, 8, -12, 4 };
// for (int i = 0; i < arrayB.Length; i++)
// {
// if (arrayB[i] < 0)
// {
// arrayB[i] = 0;
// }
// }
// foreach (int val in arrayB)
// {
// Console.WriteLine(val);
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

double[] temperatures = { 12.5, -3.4, 0.0, -1.2, 21.3 };
for (int i = 0; i < temperatures.Length; i++)
{
if (temperatures[i] < 0)
{
temperatures[i] = 0;
}
}
foreach (double temp in temperatures)
{
Console.WriteLine(temp);
}


int[] arrayTask10 = { 12, 5, 12, 8, 3, 12, 10, 10 };
Array.Sort(arrayTask10);
int max = arrayTask10[arrayTask10.Length - 1];
int secondMax = int.MinValue;
bool found = false;
for (int i = arrayTask10.Length - 2; i >= 0; i--)
{
if (arrayTask10[i] != max)
{
secondMax = arrayTask10[i];
found = true;
break;
}
}
if (found)
{
Console.WriteLine($"Второе по величине число: {secondMax}");
}
else
{
Console.WriteLine("Второго по величине числа нет (все элементы равны).");
}
