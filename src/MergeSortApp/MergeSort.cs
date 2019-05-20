namespace MergeSortApp
{
    public static class MergeSort
    {
        public static int[] mergeSort(int[] arr)
        {
            int[] arrEsquerdo;
            int[] arrDireito;
            int[] arrResultado = new int[arr.Length];
            int j = 0; //Variável que pos-incrementa o indice do sub-array direito
            int pontoMedio = arr.Length / 2; //Extrai o indice central do array

            //Define uma instância do sub-array esquerdo com tamanho deterninado pelo ponto médio
            arrEsquerdo = new int[pontoMedio];

            //Define um ponto de parada, afim de evitar uma recursão infinita, ou seja, estouro de pilha
            if (arr.Length <= 1)
            {
                return arr;
            }

            //Se o tamanho do array for par instancia o sub-array direito com o ponto médio.
            //Se for ímpar instancia com o ponto médio + 1
            if (arr.Length % 2 == 0)
            {
                arrDireito = new int[pontoMedio];
            }
            else
            {
                arrDireito = new int[pontoMedio + 1];
            }

            //Popula o sub-array esquerdo
            for (int i = 0; i < pontoMedio; i++)
            {
                arrEsquerdo[i] = arr[i];
            }

            //Popula o sub-array direito
            for (int i = pontoMedio; i < arr.Length; i++)
            {
                arrDireito[j] = arr[i];
                j++;
            }

            //Classificar recursivamente o sub-array esquerdo
            arrEsquerdo = mergeSort(arrEsquerdo);

            //Classificar recursivamente o sub-array direito
            arrDireito = mergeSort(arrDireito);

            //Classificar recursivamente a combinação de ambos sub-array
            arrResultado = Merge(arrEsquerdo, arrDireito);

            return arrResultado;
        }

        //Método responsável por combinar os dois sub-arrays ordenados.
        public static int[] Merge(int[] arrEsquerdo, int[] arrDireito)
        {
            int tamResultado = arrEsquerdo.Length + arrDireito.Length;
            int[] resultado = new int[tamResultado];

            int indexEsquerdo = 0;
            int indexDireito = 0;
            int indexResultado = 0;

            //Itera nos sub-arrays enquanto têm elementos
            while (indexEsquerdo < arrEsquerdo.Length || indexDireito < arrDireito.Length)
            {
                //Verifica se ambos arrays têm elementos
                if (indexEsquerdo < arrEsquerdo.Length && indexDireito < arrDireito.Length)
                {
                    //Verifica se o elemento do sub-array esquerdo é menor ou igual ao do sub-array direito,
                    //adiciona o elemento no array resultado
                    if (arrEsquerdo[indexEsquerdo] <= arrDireito[indexDireito])
                    {
                        resultado[indexResultado] = arrEsquerdo[indexEsquerdo];
                        indexEsquerdo++;
                        indexResultado++;
                    }
                    else
                    {
                        resultado[indexResultado] = arrDireito[indexDireito];
                        indexDireito++;
                        indexResultado++;
                    }
                }

                //Verifica se apenas o sub-array esquerdo têm elementos
                else if (indexEsquerdo < arrEsquerdo.Length)
                {
                    resultado[indexResultado] = arrEsquerdo[indexEsquerdo];
                    indexEsquerdo++;
                    indexResultado++;
                }
                //Verifica se apenas o sub-array direito têm elementos
                else if (indexDireito < arrDireito.Length)
                {
                    resultado[indexResultado] = arrDireito[indexDireito];
                    indexDireito++;
                    indexResultado++;
                }
            }
            return resultado;
        }
    }
}