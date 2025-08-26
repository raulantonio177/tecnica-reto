namespace WeightedUniformStrings.Core;

public class WeightedUniformStringSolver
{
    public List<string> WeightedUniformStrings(string s, List<int> queries)
    {
        var pesos = new Dictionary<char, int>();
        pesos.Add('a', 1);
        pesos.Add('b', 2);
        pesos.Add('c', 3);
        pesos.Add('d', 4);
        pesos.Add('e', 5);
        pesos.Add('f', 6);
        pesos.Add('g', 7);
        pesos.Add('h', 8);
        pesos.Add('i', 9);
        pesos.Add('j', 10);
        pesos.Add('k', 11);
        pesos.Add('l', 12);
        pesos.Add('m', 13);
        pesos.Add('n', 14);
        pesos.Add('o', 15);
        pesos.Add('p', 16);
        pesos.Add('q', 17);
        pesos.Add('r', 18);
        pesos.Add('s', 19);
        pesos.Add('t', 20);
        pesos.Add('u', 21);
        pesos.Add('v', 22);
        pesos.Add('w', 23);
        pesos.Add('x', 24);
        pesos.Add('y', 25);
        pesos.Add('z', 26);
        var subcadenasUniformes = new List<string>();
        var arrayCaracteres = s.ToArray();

        //Forma Conjunto de subcadenas uniformes
        for (int i = 0; i < s.Length; i++)
        {
            if (arrayCaracteres[i] == arrayCaracteres[i + 1])
            {
                var elemento = arrayCaracteres[i].ToString() + arrayCaracteres[i + 1].ToString();
                subcadenasUniformes.Add(elemento);
            }
            else
            {
                subcadenasUniformes.Add(arrayCaracteres[i].ToString());
            }
        }

        var conjuntoU = new List<int>();

        return new List<string>();
    }
}
