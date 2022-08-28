using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.IO;


internal class Program
{
    private static void Main(string[] args)
    {
        var caminho = "C:\\TrabalhandoComArquivos";
        var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
        var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
        var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
        var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-backup.txt");
        var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");

        var listaString = new List<string> { "Linha 1", "linha 2", "linha 3" };
        var listaStringContinuacao = new List<string> { "Linha 4", "linha 5", "linha 6" };


        FileHelper helper = new FileHelper();

        // helper.ListarDiretorios(caminho);
        //helper.ListarArquivosDiretorios(caminho);
        //helper.CriarDiretorio(caminhoPathCombine);
        //helper.apagarDiretorio(caminhoPathCombine, true);
        // helper.CriarArquivoTexto(caminhoArquivo, "Olá! teste de escrita do arquivo");
        //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
        //helper.adcionarTextoStream(caminho, listaStringContinuacao);
        //helper.lerArquivoStream(caminhoArquivo);
        //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
        //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
        helper.DeletarArquivo(caminhoArquivoTesteCopia);

        // ICalculadora calc = new Calculadora();
        // System.Console.WriteLine(calc.Somar(10, 20));


        // Computador comp = new Computador();
        // System.Console.WriteLine(comp.ToString());

        // Corrente c1 = new Corrente();
        // c1.Creditar(100);
        // c1.ExibirSaldo();

        // Calculadora calc= new Calculadora();
        // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
        // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));

        //  Aluno p1 = new Aluno();
        //  Professor p2 = new Professor();

        //  p1.Nome = "Bob";
        //  p1.Idade = 20;
        //  p1.Documento = "12345";
        //  p1.Nota= 9;

        //  p1.Apresentar();

        //   p2.Nome = "Bob";
        //  p2.Idade = 20;
        //  p2.Documento = "12345";
        //  p2.Salario= 9000;

        //  p2.Apresentar();

        //valores válidos
        // Retangulo r = new Retangulo();
        // r.DefinirMedidas(30, 30);

        // System.Console.WriteLine($"Área: {r.ObterArea()}");

        // //valores inválidos
        // Retangulo r2 = new Retangulo();
        // r2.DefinirMedidas(0, 0);

        // System.Console.WriteLine($"Área: {r2.ObterArea()}");
    }
}


