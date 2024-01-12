using System;
class Program
{
    static void Main()
    {
        string mensagemCriptografada = "10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001 00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011";
        string[] valorCriptografado = mensagemCriptografada.Split(' ');
        string mensagemDescriptografada = DescriptografarMensagem(valorCriptografado);
        Console.WriteLine(mensagemDescriptografada);
    }

    static string DescriptografarMensagem(string[] valores)
    {
        string mensagemDescriptografada = "";

        foreach (string valor in valores)
        {
            int valorDecimal = Convert.ToInt32(valor, 2);
            int valorDescriptografado = DescriptografarValor(valorDecimal);
            char DescriptografarChar = Convert.ToChar(valorDescriptografado);

            mensagemDescriptografada += DescriptografarChar;
        }
        return mensagemDescriptografada;
    }

    static int DescriptografarValor(int valor)
    {
        int inverterBites = valor ^ 3;
        int Ntrocados = ((inverterBites & 0xF0) >> 4) | ((inverterBites & 0x0F) << 4);
        return Ntrocados;
    }
}