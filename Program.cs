
using Bootcamp_dotNet_e_C_.interfaces;
using Bootcamp_dotNet_e_C_.Models;



ICalculadora calc = new Calculadora();
Console.WriteLine(calc.multiplicar(3, 9));








//INTRODUCAO A PARADIGMA POO EM Csharp

// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(5000);
// c1.ExibirSaldo();


// Dictionary<string, string> estados = new Dictionary<string, string>();



// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach(KeyValuePair<string, string> item in estados){
//   Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------");

// estados.Remove("BA");
// estados["SP"] = "Sao paulo alterado";


// foreach(var item in estados){
//   Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o Elemento: {chave}");

// if (estados.ContainsKey(chave)){
//   Console.WriteLine($"VAlor existente {chave}");
// } else {
//   Console.WriteLine($"VAlor nao existe {chave}");
// }










// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o ultimo elementodo do topo {pilha.Pop()}");

// pilha.Push(20);



// foreach(int item in pilha)
// {
//   Console.WriteLine(item);
// }

















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila){
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach(int item in fila){
//   Console.WriteLine(item);
// }




// new ExemploExcecao().Metodo1();



// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//       Console.WriteLine(linha);
//     }

// } 
// catch(Exception ex){

//   Console.WriteLine($"Ocorreu uma excessao generica. {ex.Message}");
// }
// finally 
// {
//   Console.WriteLine("Chegou ate aqui");
// }







// string dataString = "2022-02-15 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//    "yyyy-MM-dd HH:mm",
//    CultureInfo.InvariantCulture,
//    DateTimeStyles.None, out DateTime data);

// if (sucesso){
//   Console.WriteLine($"Com sucesso {data}");
// } else {
//   Console.WriteLine($"{dataString} Nao e data valida");
// }


// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 1234.50M;
// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));
// Console.WriteLine(valorMonetario.ToString("C1"));


// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);

// Pessoa p1 = new Pessoa(nome: "Caio", sobrenome: "Portela");
// Pessoa p2 = new Pessoa(nome: "Pim", sobrenome: "Marroquim");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();




// Pessoa p1 = new Pessoa();
// p1.Nome = "caio";
// p1.Sobrenome = "Portela";
// p1.Idade = 30;
// p1.Apresentar();


// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");


// for(int i = 0; i < listaString.Count; i++){
//   Console.WriteLine(listaString[i]);
// }

// foreach(string item in listaString){
//   Console.WriteLine(item);
// }



// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 65;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayinteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayinteirosDobrados, arrayInteiros.Length);

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o Array com FOR");
// for(int i = 0; i < arrayInteiros.Length; i++){
//   Console.WriteLine($"Posicao {i} - {arrayInteiros[i]}");
// }

// Console.WriteLine("Percorrendo o ARRAY COM FOREACH");


// int contadorForeach = 0;
// foreach(int valor in arrayInteiros){
//   Console.WriteLine($"Posicao {contadorForeach} - {valor}");
//   contadorForeach++;
// }


// string opcao;
// bool exibirMenu = true;

// while(exibirMenu){

//   Console.Clear();
//   Console.WriteLine("Digite a sua opcao: ");
//   Console.WriteLine("1 - Cadastrar cliente ");
//   Console.WriteLine("2 - Buscar cliente");
//   Console.WriteLine("3 - Apagar Cliente ");
//   Console.WriteLine("4 - Encerrar");

//   opcao = Console.ReadLine();

//   switch(opcao){

//     case "1":
//       Console.WriteLine("Cadastro do cliente");
//       break;

//     case "2":
//       Console.WriteLine("Busca de Cliente");
//       break;

//     case "3":
//       Console.WriteLine("Apagar Cliente");
//       break;

//     case "4":
//       Console.WriteLine("Encerrar");
//       exibirMenu = false;
//       break;

//     default:
//       Console.WriteLine("Opcao Invalida");
//       break;
//   }
// }




// int soma = 0;
// int numero = 0;


// do {
//   Console.WriteLine("Digire um número: (0 para parar) ");
//   numero = Convert.ToInt32(Console.ReadLine());
//   soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da somas dos numeros digitador é: {soma}");






// int numero = 5;
// int contador = 0;
// // int auxiliar = 0;

// while (contador <= 10){
//   Console.WriteLine($"{contador + 1} execucao: {numero} x {contador} = {numero * contador}");
//   contador++;

//   if (contador == 6){
//     break;
//   }

// }


// for(int contador = 0; contador <= 10; contador++){

//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }




// Calculadora calc = new Calculadora();

// calc.somar(3, 7);
// calc.subtrair(10, 50);
// calc.multiplicar(15, 45);
// calc.dividir(2, 2);
// calc.potencia(3, 3);

// calc.seno(30);
// calc.coseno(30);
// calc.tangente(30);
// calc.raizQ(9);




// Console.WriteLine("Digite uma letra: ");

// var letra = Console.ReadLine();

// switch (letra){

//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;
//   default:
//     Console.WriteLine("Não Vogal ");
//     break;
// }







// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"é Possivel realizar a venda?  {possivelVenda}");

// if(quantidadeCompra == 0){
//   Console.WriteLine("Venda invalida");
// } else if (possivelVenda){
//   Console.WriteLine("venda realizada");
// } else {
//   Console.WriteLine("nao temos a quantidade desejada!");
// }




// double a = 4 / 2 + 2;

// Console.WriteLine(a);


//cast - casting
// int a = Convert.ToInt32(null);
//int a = int.Parse("5");


// Console.WriteLine(a);





// int a = 10;
// int b = 20;

// int c = a + b;

// c += 5;

// Console.WriteLine(c);





// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));



// string apresentacao = "Ola, seja bem vindo";

// int quantidade = 1;

// double altura = 1;

// decimal preco = 1.80M;

// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da variavel condicao: " + condicao);






// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "caio";
// pessoa1.Idade = 30;
// pessoa1.Apresentar();

// Pessoa pessoaFisicaRepresentacao = new Pessoa();