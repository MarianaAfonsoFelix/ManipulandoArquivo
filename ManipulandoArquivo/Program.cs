Console.WriteLine("Olar, seja bem vindo ao programa que realiza a cópia entre dois arquivos! :)");
Console.WriteLine("Digite o nome do arquivo de origem:");
string arquivoOrigem = Console.ReadLine();

Console.WriteLine("Digite o nome do arquivo de destino:");
string arquivoDestino = Console.ReadLine();

CopiaArquivos(arquivoOrigem, arquivoDestino);
 
 
 static void CopiaArquivos(string origem, string destino)
    {
        try
        {
            if (!File.Exists(origem))
            {
                Console.WriteLine($"O arquivo de origem '{origem}' não existe.");
                return;
            }
            if (File.Exists(destino))
            {
                Console.WriteLine($"O arquivo de destino '{destino}' já existe.");
                return;
            }

            using (StreamReader sr = new StreamReader(origem))
            {
                using (StreamWriter sw = new StreamWriter(destino))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(linha);
                    }
                }
            }

            Console.WriteLine($"Conteúdo de '{origem}' copiado para '{destino}' com sucesso.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocorreu um erro durante a cópia: {e.Message}");
        }
    }