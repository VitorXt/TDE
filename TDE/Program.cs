using TDE;
using Newtonsoft.Json;
using System.IO;

StreamReader leitor = new StreamReader(@"C:\temp\Arquivo.json");
string conteudoArquivo = leitor.ReadToEnd();
leitor.Close();

List<Pessoa> pessoas = JsonConvert.DeserializeObject <List<Pessoa>>(conteudoArquivo);

string json = JsonConvert.SerializeObject(pessoas);

foreach (Pessoa pessoa in pessoas)
{
    Console.WriteLine("Nome: " + pessoa.Nome);
    Console.WriteLine("Idade: " + pessoa.Idade);
    Console.WriteLine("Profissao: " + pessoa.Profissao);
    Console.WriteLine("Cidade: " + pessoa.Cidade);
    Console.WriteLine("");
}

string caminhoArquivo = @"C:\temp\Arquivo_Criado.json";

File.WriteAllText(caminhoArquivo, json);

Console.ReadKey();