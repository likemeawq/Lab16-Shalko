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

int[] gradesToSort = { 4, 5, 3, 5, 4, 2 };
for (int i = 0; i < gradesToSort.Length - 1; i++)
{
for (int j = 0; j < gradesToSort.Length - 1 - i; j++)
{
if (gradesToSort[j] < gradesToSort[j + 1])
{
int temp = gradesToSort[j];
gradesToSort[j] = gradesToSort[j + 1];
gradesToSort[j + 1] = temp;
}
}
}
foreach (int grade in gradesToSort)
{
    Console.WriteLine(grade);
}


int[] slots = GenerateScheduleSlots(6);
foreach (int slot in slots)
{
Console.WriteLine(slot);
}
int[] evenSlots = GenerateEvenSlots(6);
foreach (int slot in evenSlots)
{
    Console.WriteLine(slot);
}
