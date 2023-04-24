// Solicite ao usuário que digite a sua senha (uma string). Exiba "Acesso permitido" caso a senha digitada seja 1234abcd, senão exiba "Acesso negado".
Console.WriteLine("--- Senha ---");

Console.Write("Digite a senha.....:");
string senha = Console.ReadLine()!;

if (senha == "1234abcd"){
    Console.WriteLine("Acesso permetido");
}else  {
    Console.WriteLine("Acesso negado");
}


