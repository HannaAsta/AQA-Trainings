
int[] scores = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int minNumber = scores[0];
int maxNumber = scores[0];

int Sum = 0;


for (int i = 0; i < scores.Length; i ++) 
{
   Sum += scores [i];

    if (scores[i] < minNumber)
        minNumber = scores[i];

    if (scores[i] > maxNumber)
        maxNumber = scores[i];
}

float average = (float)Sum / scores.Length;


Console.WriteLine($"min={minNumber}");
Console.WriteLine($"max={maxNumber}");

Console.WriteLine($"average={average}");

