int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg1>result) result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}



int a1 = 23;
int a2 = 45;
int a3 = 2;
int a4 = 233;
int a5 = 453;
int a6 = 237;
int a7 = 233;
int a8 = 433;
int a9 = 23454;


int max = Max(Max(a1,a2,a3),
    Max(a4,a5,a6),
    Max(a7,a8,a9)
    );


Console.WriteLine(max);
