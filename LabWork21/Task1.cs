//1.1
int Sum(int a, int b) => a + b;

//1.2
// вычисление площади кольца
int r1 = 2, r2 = 5;
double s = Math.PI * (r1 - r2) * (r1 + r2);
if (s < 0)
    s = -s;

// сумма чисел от 1 до n (заменить на сумму ряда натуральных чисел) 
int sum = 0, n = 5;
sum = (n - 1) * n / 2;
