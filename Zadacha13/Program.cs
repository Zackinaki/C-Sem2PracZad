
Console.Clear();
Console.Write("Vvedite chsilo: ");
int a =Convert.ToInt32(Console.ReadLine());
if(a<100)
Console.WriteLine("Netu tret'ei cifra chisla");
else
{
    int i=0;
    int b=a;
    while(b>0)
   { 
        b=b/10;
        i++;
    
   }
  
int a1=10;

for(int j=1;j<i;j++)
{
    a1*=10;
}

double a2;
a2=(double)a/(double)a1;

double a3;
a3=a2*1000;

int a4;
a4=(int)a3;

int a5;
a5=a4%10;
Console.WriteLine($"Tret'a cifra chisla: {a5}");
}
