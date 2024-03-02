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
                if (lijevo <= desno && gore <= dolje)
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
                if (gore <= dolje && lijevo >= desno) //"gore <= dolje" Ispisuje broj u sredini, zato sam stavio znak jednako. A u sredini je kraj niza. Kod "lijevo >= desno", znak ">" spriječava preskakanje i ispisivanje većih brojeva. Isto ispisuje broj u sredini.
                    for (int i = dolje; i >= gore; i--)
                    {
                        for (int j = desno; j >= lijevo; j--)
                            c[i, j] = brojac++;

                    }

                //Pomocno za koordinatu 3,7
                if (gore >= dolje && lijevo < desno) //"gore == dolje" Veće jednako ili manje jednako, isto je. Ne smije biti "lijevo <= desno" jer će mi ispisati broj "26" u koordinati (5,5). A napisao sam u već u gornjoj naredbi "gore <= dolje".
                    for (int i = dolje; i >= gore; i--) //"i >= gore" Bez znaka jednako ispisuje mi nule do kraja niza.
                    {
                        for (int j = desno; j >= lijevo; j--) // "j >= lijevo" ispisuje mi zadnji broj u nizu. Bez znaka jednako imam nulu.
                            c[i, j] = brojac++;

                    }
            }
            return c;
        }
        public static void Izvedi()
        {
            int reci = 5;
            int stupci = 9;
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
