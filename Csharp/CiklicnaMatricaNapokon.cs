using System.Data;

namespace circularMatrixInCSharp

{
    public class CiklicnaMatrica

    {

        static int[,] SpiralMatrica(int reci, int stupci)
        {
            int[,] c = new int[reci, stupci];
            int brojac = 1;

            int gore = 0;
            int dolje = reci - 1;
            int lijevo = 0;
            int desno = stupci - 1;
            int pocetniRed = 0;
            int pocetniStupac = 0;
            int zadnjiRed = reci - 1;
            int zadnjiStupac = stupci - 1;
            

            while (brojac <= reci * stupci)
            {

                //desni stupac
                if (lijevo < desno && gore < dolje)
                {
                    for (int i = dolje; i >= gore; i--)
                    {
                        c[i, desno] = brojac++;
                    }
                    desno--;

                    //gornji red
                    for (int i = desno; i >= lijevo; i--)
                    {
                        c[gore, i] = brojac++;

                    }
                    gore++;



                    //lijevi stupac
                    for (int i = gore; i <= dolje; i++)
                    {
                        c[i, lijevo] = brojac++;
                    }
                    lijevo++;



                    //donji red
                    for (int i = lijevo; i <= desno; i++)
                    {
                        c[dolje, i] = brojac++;
                    }
                    dolje--;
                    
                    
                }
                //UNUTARNJI CIKLUSI
                // 
                if (gore <= dolje && lijevo >= desno)
                {
                    for (int i = dolje; i >= gore; i--)
                    {
                        for (int j = desno; j >= lijevo; j--)
                            c[i, j] = brojac++;

                    }
                }


                if (gore >= dolje && lijevo < desno)
                {
                    for (int i = dolje; i >= gore; i--)
                    {
                        for (int j = desno; j >= lijevo; j--)
                            c[i, j] = brojac++;

                    }
                }

                
                    
                
            }
            return c;
        }
        public static void Izvedi()
        {
            int reci = 5;
            int stupci = 6;
            int[,] c = SpiralMatrica(reci, stupci);

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
