// See https://aka.ms/new-console-template for more informatio
int n;
int p;
Console.WriteLine("¿De que tamaño desea su matriz?");
p = int.Parse(Console.ReadLine());
llenar (p);

static extern void llenar (int p);


int[,] mat = new int[p,p]; 

for(int i = 0; i < p; i++)
{
    for(int j = 0; j < p; j++)
    {
        Console.WriteLine("Ingrese el numero para la posicion "+i+","+j);
        n = int.Parse(Console.ReadLine());
        mat[i,j] = n; 
    }
}
        
