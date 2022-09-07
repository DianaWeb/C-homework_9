/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15-> 120
M = 4; N = 8. -> 30 */
/* int SumNum(int M, int N)
{
	int sum = 0;
	for (int i = M; i <= N; i++)
	{
		sum = sum + i;
	}
	return sum;
}
System.Console.WriteLine(SumNum(4, 8)); */

int SumNum2(int M, int N)
{
	if (M <= N) return M + SumNum2(M + 1, N);
	else return 0;
}
System.Console.WriteLine(SumNum2(4, 8));