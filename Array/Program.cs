using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY
            string[] nomi = { "Angelo", "Luca", "Filippo" }; //devono essere dati coerenti, non posso aggiungere altri elementi dopo, devo fare come sotto
            string[] cognomi = new string[3]; //non metto dati, ne posso mettere 3, fino a [2]
            cognomi[0] = "primo";
            cognomi[1] = "secondo";
            cognomi[2] = "terzo";
            foreach (string nome in nomi)
            {
                Console.WriteLine(nome);
            }

            //ARRAY MULTIDIMENSIONALI
            string[,] codici =
            {
                {"0,10", "0,11"},
                {"0,20", "0,21" },
                {"0,30", "0,31" }
            };
            string[,] codici2 = new string[3,2]
            {
                {"0,10", "0,11"},
                {"0,20", "0,21" },
                {"0,30", "0,31" }
            };
            codici2[2, 1] = "0,32";
            foreach(string codice in codici)
            {
                Console.WriteLine(codice);
            }
            for (int riga = 0; riga < codici.GetLength(0); riga++)
            {
                //GetLenght(0) prende lunghezza della prima dimensione
                for(int colonna = 0; colonna < codici.GetLength(1); colonna++)
                {
                    Console.WriteLine(codici[riga, colonna]);
                }
            }

            //ARRAY 3D
            string[,,] array3D = new string[2,2,2]
            {
                {
                    {"0,10","0,20"},
                    {"0,21","0,22"}
                },
                {
                    {"0,23","0,24"},
                    {"0,25","0,26"}
                }
            };
            for (int dim1 = 0; dim1 < array3D.GetLength(0); dim1++)
            {
                for (int dim2 = 0; dim2 < array3D.GetLength(1); dim2++)
                {
                    for (int dim3 = 0; dim3 < array3D.GetLength(2); dim3++)
                    {
                        Console.WriteLine(array3D[dim1, dim2, dim3]);

                    }
                }
            }
        } 
    }
}
