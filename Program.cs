Console.Clear();
const string sair = "tchau";
string pergunta;

Console.WriteLine("~~~~ Bem vindo ao Groot Chatbot! ~~~~");

do
{
    Console.Write("Pergunta: ");
    pergunta = Console.ReadLine()!;
    string resposta = RespostaGroot(pergunta);
    ExibeResposta(RespostaGroot(pergunta));
}while (pergunta.Trim().ToLower() != sair);

void ExibeResposta(string resposta)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"                          Resposta: {resposta}");
    Console.ResetColor();
}

string RespostaGroot(string pergunta)
{
    return pergunta.Trim().ToLower() == sair ?
        "Eu sou Groot!" :
        "Eu sou Groot.";
}
