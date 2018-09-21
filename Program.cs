using System;

namespace Prueba
{
    class Program
    {
        static int[,] Matriz;

        static void Main(string[] args)
        {
            int Longitud;
            Longitud = 19;
            Matriz = new int[Longitud,Longitud];
            for ( int i=0;i<Longitud;i++)
            {
                for ( int j=0;j<Longitud;j++)
                {
                    Matriz[i,j]=0;
                }
            }
            LlenaMatriz(0,0,1,Longitud,0,1,1);
            int NumMaximo = Longitud*Longitud;
            NumMaximo = NumMaximo.ToString().Length;
            for ( int i=0;i<Longitud;i++)
            {
                for ( int j=0;j<Longitud;j++)
                {
                    //Console.Write(Matriz[i,j].ToString().PadLeft(NumMaximo, ' '));
                    if ( Matriz[i,j] == 1 )
                    {
                        Console.Write("*");
                    } else{
                        Console.Write(" ");
                    }                    
                    //Console.Write(Matriz[i,j]);
                    //Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }

        static void LlenaMatriz(int posx, int posy, int numero, int longitud, int direccionx, int direcciony, int signo){
            if ( posx>=0 && posy>=0 && posx<longitud && posy<longitud && Matriz[posx,posy]==0 && Matriz[posx+direccionx*signo,posy+direcciony*signo]==0 )
            {
                //Matriz[posx,posy] = numero++;               
                Matriz[posx,posy] = numero;               
                if ( (posx+2*direccionx*signo)<0 || (posx+2*direccionx*signo)>=longitud || (posy+2*direcciony*signo)>=longitud || (posy+2*direcciony*signo)<0 || Matriz[posx+2*direccionx*signo,posy+2*direcciony*signo]>0 )
                {
                    direccionx=(direccionx+1)%2;
                    direcciony=(direcciony+1)%2;
                    if ( direccionx == 0 && direcciony == 1 ) 
                        signo = signo * ( -1 );
                }
                LlenaMatriz(posx+direccionx*signo,posy+direcciony*signo,numero,longitud,direccionx,direcciony,signo);
            }
            return;
            
        }
    }
}
