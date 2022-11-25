Console.Clear();
Console.Write("Vvdedite chisla: ");
int a = Convert.ToInt32(Console.ReadLine());
int maxmin=0;
do{
    int b = Convert.ToInt32(Console.ReadLine());
    if (b==0)
       break;
    if(b>a){
        maxmin=a;
        a=b;
    }
    else if(b>maxmin)
    maxmin=b;
}
while(true);
Console.WriteLine($"Vtoroe no velichine chislo: {maxmin}");

