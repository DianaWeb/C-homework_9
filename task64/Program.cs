string Queue(int M, int N)
{
	if (M <= N) return $"{M} {Queue(M + 1, N)}";
	else return string.Empty;
}
System.Console.WriteLine(Queue(2, 8));