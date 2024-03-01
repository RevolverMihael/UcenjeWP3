using System.Data;

namespace circularMatrixInCSharp

{
    public class circularMatrix

    {

          static int[,] SpiralMatrica(int reci, int stupci)
        {
            int[,] c = new int[reci, stupci];
            int brojac = 1;

            int gore = 0, dolje = reci - 1, lijevo = 0, desno = stupci - 1;


            while (gore < dolje && lijevo < desno)
            {
                //desni stupac
                if (lijevo <= desno)
                {
                    for (int i = dolje; i >= gore; i--)
                    {
                        c[i, desno] = brojac++;
                    }
                    desno--;
                }
                //gornji red
                
                    for(int i = desno; i >= lijevo; i--)
                    {
                        c[gore,i] = brojac++;

                    }
                    gore++;
                
                

                //lijevi stupac
                
                    for (int i = gore; i <= dolje; i++)
                    {
                        c[i, lijevo] = brojac++;
                    }
                    lijevo++;



                //donji red

                if (gore <= dolje)
                {
                    for (int i = lijevo; i <= desno; i++)
                    {
                        c[dolje, i] = brojac++;
                    }
                    dolje--;
                }

                //nastavit gore
                for(int i = dolje; i >= gore;i--)
                {
                    c[i,desno] = brojac++;

                }
                desno--;
                
                //nastavit lijevo
                for(int i = desno; i >= lijevo; i--)
                {
                    c[gore, i] = brojac++;
                }
                gore++;
                
            }
            return c;
        }
        public static void Izvedi()
        {
            int reci = 3;
            int stupci = 7;
            int[,] c = SpiralMatrica(reci,stupci);

            for (int i = 0; i < reci; i++)
            {
                for (int j = 0; j < stupci; j++)
                {
                    Console.Write(c[i, j] + "\t ");

                }
                Console.Write("\n");
            }
        }





    }

}
