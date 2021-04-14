using System;

public static double Bai318_TongSothucAm(double[,] B)
{
    int i, j;
    double S = 0;
    for (i = 0; i < B.GetLength(0); i++)
    {
        for (j = 0; j < B.GetLength(1); j++)
        {
            if (B[i, j] < 0)
            {
                S = S + B[i, j];
            }
        }
    }
    Console.WriteLine($"Tong gia tri am trong ma tran so thuc: {S}");
    return S;
}