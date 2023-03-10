int[,] GetPoint2dList(int count, int minValue, int maxValue)
{
  int[,] table = new int[count, 2];

  for (int i = 0; i < count; i++)
  {
    int x = Random.Shared.Next(minValue, maxValue);
    int y = Random.Shared.Next(minValue, maxValue);
    table[i, 0] = x;
    table[i, 1] = y;
  }
  return table;
}

string PrinterList(int[,] points)
{
  string result = String.Empty;

  int row = points.GetLength(0);
  for (int i = 0; i < row; i++)
  {
    result += $"{points[i, 0]};{points[i, 1]}\n";
  }
  return result;
}

void SavePointListTo(string path, string data)
{
  File.WriteAllText(path, data);
}

int[,] point2dList = GetPoint2dList(10, 0, 20);

string data = PrinterList(point2dList);

SavePointListTo("points.csv", data);