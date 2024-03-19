class tde1 {
    static void Main(){
        //1 - Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.

        int idade = 35;
        Console.WriteLine(idade);

       //2 - Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.

       string nome = "Maria";
       Console.WriteLine(nome);

       //3 - Crie uma variável chamada altura e atribua a ela o valor 3.45.

       double altura = 3.45f;
       Console.WriteLine(altura);

       //4 - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor.

       const int ano = 12;
       Console.WriteLine(ano);

       //5 - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.

       double? nota = 7.80;
       Console.WriteLine(nota);

       //6 - Quais as diferenças entre os tipos por valor e os tipos por referência ?
       
       //Tipos por Valor: Armazenam diretamente os dados e são passados por cópia.
       //Tipos por Referência: Armazenam endereços de memória e são passados por referência, alterações feitas afetam o objeto original. 

       //7 - O que é um nullable type e qual a sua utilidade ?
        
        //"nullable type" é um tipo de dado que pode conter um valor adicional representando "nulo" ou "ausência de valor"
        //É útil em situações onde a presença de um valor é opcional.

        //8 - O que é Camel Case ? Dê um exemplo de sua aplicação.
        
        //Camel case é uma convenção de nomenclatura em que múltiplas palavras são unidas sem espaços, e cada palavra subsequente começa com uma letra maiúscula, exceto a primeira palavra que começa com uma letra minúscula.
        
        int idadeUsuario = 21;
        float salarioMensal = 1.300f;
        Console.WriteLine(idadeUsuario);

        Console.WriteLine(salarioMensal);

        //9 - O que é Pascal Case ? Dê um exemplo de sua aplicação.
        
        //Pascal case é uma convenção de nomenclatura em que cada palavra em um identificador começa com uma letra maiúscula e não há espaços entre as palavras. É frequentemente usado em nomes de tipos de dados, como structs e enums em C.
        //typedef struct {
    //int NumeroDeRegistro;
    //char NomeCompleto[50];
    //float Salario;
//} DadosFuncionario;

    //10 - Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar aoperação de soma)
    int x = 77;
    int y = 66;

    int soma = x + y;
     Console.WriteLine("A soma de x + y é:"+ soma);

    //11 - Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
    //boll: false
    //char: '\0', caractere nulo
    //int: 0
    //double 0.0
    //float: 0.0f
    //decimal: 0.0m
    //string: null

        



        
        
        




            
            
            


         
        







































    }
}