using System;

public static bool Bai316_KTSonguyenChanBehon2015(int[,] A)
{
    int i, j;
    bool KT = false;
    for (i = 0; i < A.GetLength(0); i++)
    {
        for (j = 0; j < A.GetLength(1); j++)
        {
            if (A[i, j] % 2 == 0 && A[i, j] < 2015)
            {
                KT = true;
            }
        }
    }
    Console.WriteLine(KT);
    return KT;
}