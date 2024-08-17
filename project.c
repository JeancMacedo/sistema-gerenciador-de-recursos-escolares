#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <locale.h>
#include <string.h>

#define NUM_MAX 100 // número máximo de alimentos cadastrados permitidos

typedef struct Alimento {
    int ocupado;
	char nome[101]; //o nome tem 100 caracteres, e tem o espaco do '\0'
	int quantidade;
	char validade[11]; //a validade tem 10 caracteres, e tem o espaco do '\0'
	int dia, mes, ano;
} Alimento;

        // Variáveis Globais
Alimento vetor_alimento[NUM_MAX]; //cria um vetor com capacidade de armazenar os dados de 100 alimentos
int total_alimento = 0; //guarda o total de alimentos cadastradas
char caminho_arquivo_alimento[101]; //guarda o caminho do arquivo com os dados dos alimentos


// Protótipo das funções responsáveis por gerenciar o cadastro de alimentos

void cadastro_inicializar(); //inicializa o vetor e o contador de cadastro //cria o arquivo de texto onde os dados do cadastro serão salvos

void cadastro_inicializar_arquivo(); //cria o arquivo de dados (caso ele não exista) que irá guardar os dados do cadastro

void cadastro_carregar_dados_arquivo(); //carrega os dados de um arquivo de texto para o vetor de estruturas Alimento

void cadastro_salvar_dados_arquivo(); //salva os dados do vetor de estrutura Alimento em um arquivo de texto


        // Protótipo da Função com a Tela
int tela_menu(); //mostra a tela com o menu de opções (retorna -1 se for inválida)
void tela_cadastrar(); //mostra a tela de cadastro
void tela_pesquisar(); //mostra a tela de pesquisa pelo nome
void tela_remover(); //mostra a tela remover alimento do cadastro
void tela_relatorio(); //mostra a tela de relatório do estoque
int tela_sair(); //mostra a tela sair (retorna 1 para encerrar e 0 para não encerrar)
int estoque_vazio(); //mostra que o estoque está vazio (utilizado em pesquisa, remover e relatório)

        // Protótipo das Funções de Mensagem e Entrada/Leitura de Dados do Teclado
int tela_mensagem(char *mensagem); //mostra uma mensagem com a opçao de escolher "sim" ou "não" - retorna 1 caso seja escolhido o "sim" e 0 caso seja escolhido o "não"




//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




int main()
{

    //muda a localização para Português do Brasil
    setlocale(LC_ALL, "portuguese");
    system("chcp 1252 > null");

    //variaveis utilizadas para controlar o loop de execução do programa
    int sair = 0;   //controla quando o program deve ser encerrao
    int opcao;      //guarda a opção escolhida pelo usuário no menu de opção
    int erro;       //indicador de erro usado na leitura de valores do teclado
    int continuar;  //controla se o usuário quer continuar: cadastrar, pesquisar, ou remover um alimento;

    cadastro_inicializar(); //faz as inicializações do cadastro de alimentos

    cadastro_inicializar_arquivo(); //cria o arquivo de dados (caso ele não exista) que irá guardar os dados do cadastro

    cadastro_carregar_dados_arquivo(); //carrega os dados de um arquivo de texto para o vetor de estruturas Alimento

    //variáveis utilizadas para fazer a leitura dos dados do alimento do teclado!
	char nome[101];
	int quantidade;
	int dia, mes, ano;
	char validade[11];
    int idxPesquisa = -1; //guarda o indice de: alimento pesquisado - alimento que será removida

    //loop de execução do programa
    do {
        //TELA COM O MENU DE OPÇÕES
        opcao = tela_menu();

        //verifica qual opção foi escolhida
        switch(opcao)
        {
            //TELA DE CADASTRO
            case 1:
                tela_cadastrar();
            break;

            //TELA DE PESQUISA
            case 2:
                tela_pesquisar();
            break;

            // TELA DE REMOÇÃO
            case 3:
                tela_remover();
            break;

            // TELA DE RELATÓRIO
            case 4:
                tela_relatorio();
            break;

            // TELA ENCERRAR APLICAÇÃO
            case 5:
                sair = tela_sair();
            break;

            // TRATAMENTO DE OPÇÃO INVÁLIDA
            default:
                printf("\nOpção Inválida !!! \n");
                system("pause");
        }
    } while (sair == 0);

    cadastro_salvar_dados_arquivo(); //salva os dados do vetor de estrutura Alimento em um arquivo de texto

    system("cls");
    printf("\nFim da execução do programa!\n");

    return 0;
}

















//---------------------------------------------------------------------------------------------------------------------------------------------

                            // FUNÇÕES

//---------------------------------------------------------------------------------------------------------------------------------------------


    // Iniciliza o vetor de cadastro
void cadastro_inicializar()
{
    total_alimento = 0; //zera o contador de alimentos cadastrados (variável global) - guarda o total de alimentos cadastrados

    //inicializa o vetor de alimentos - livres / desocupados
    for(int i = 0; i < NUM_MAX; i++)
    {
        //marca a posição como livre/desocupada, ou seja, pode receber os dados de um alimento!
        vetor_alimento[i].ocupado = 0;
    }
}


//---------------------------------------------------------------------------------------------------------------------------------------------


    // Mostra a tela com o menu de opções // retorna a opção (um valor de 1 a 5) escolhida // retorna -1 caso o usuário escolha uma opção inválida
int tela_menu()
{
    int opcao; //guarda a opção escolhida pelo usuário

    //mostra a Tela com o "Menu de Opções"
    system("cls");
    printf("Menu de Opções do Estoque de Alimentos \n");
    printf("1 - Cadastrar \n");
    printf("2 - Pesquisar \n");
    printf("3 - Remover \n");
    printf("4 - Relatório do estoque \n");
    printf("5 - Sair \n\n");

    printf("Escolha uma opção: "); //faz a leitura da opção escolhida
    int erro = scanf("%d", &opcao);

    //verifica se houve uma falha na leitura do scanf
    if(erro != 1) {
        fflush(stdin); //limpa o buffer do tecaldo (windows)
        opcao = -1; //como teve uma falha na leitura, marca uma opção inválida
    }
    return opcao; //retorna a opção escolhida
}


//---------------------------------------------------------------------------------------------------------------------------------------------


//mostra a tela de cadastro
void tela_cadastrar()
{
    //variáveis utilizadas para fazer a leitura dos dados do alimento do teclado!
	char nome[101];
	int quantidade;
	int dia, mes, ano;
	char validade[11];
	int idxPesquisa = -1; //guarda o indice de: alimento pesquisado - alimento que será removida
    int continuar; //controla se o usuário quer cadastrar um novo alimento
    int erro;       //indicador de erro usado na leitura de valores do teclado

    do {
        system("cls");
        printf("1 - Cadastrar \n");

        //verifica se o cadastro chegou na capacidade máxima
        if(total_alimento >= NUM_MAX)
        {
            //indica que o cadastro já está cheio
            printf("\nERRO: O cadastro já atingiu sua capacidade máxima de 100 alimentos!\n");
            system("pause");
            break; //encerra o laço do-while
        }

        //FAZ A ENTRADA DO NOME
        do
        {
            erro = 0; //marca que ainda não ocorreu um erro

            printf("\nDigite o nome: ");
            scanf(" %100[^\n]", nome);

            fflush(stdin); // limpa o buffer do teclado após a leitura

            //o nome pode ter no máximo 100 caracteres e no mínimo 2 caracteres
            if(strlen(nome) > 100)
            {
                erro = 1; //marca a ocorrência de um erro
                printf("ERRO: O nome do alimento deve possuir no máximo 100 (cem) carracteres!\n");
            }
            if(strlen(nome) < 2) {
                erro = 1; //marca a ocorrência de um erro
                printf("ERRO: O nome do alimento deve possuir pelo menos 2 (dois) carracteres!\n");
            }
        } while(erro == 1); //FIM DA ENTRADA DO NOME

        //FAZ A ENTRADA DA QUANTIDADE
        do
        {
            printf("\nDigite a quantidade: ");
            erro = scanf("%d", &quantidade);

            fflush(stdin); //limpa o buffer do teclado para o caso do scanf falhar, ou o usuário digitar alguma coisa após o número inteiro

            //verifica se houve um erro de leitua do scanf
            if(erro != 1)
            {
                printf("ERRO: Digite um valor inteiro válido!\n");
            }
        } while(erro != 1); //FIM DA ENTRADA DA QUANTIDADE


        //FAZ A ENTRADA DA VALIDADE
        do
        {
            erro = 0; //marca que ainda não ocorreu um erro

            printf("\nDigite a validade (xx/xx/xxxx): ");
            scanf(" %10[^\n]", validade);

            fflush(stdin); //limpa o buffer do teclado para o caso do scanf falhar, ou o usuário digitar alguma coisa após o número inteiro

            //a validade pode ter no máximo 10 caracteres e deve conter esse formato: xx/xx/xxxx
            if((strlen(validade) != 10) || (validade[2] != '/' || validade[5] != '/'))
            {
                erro = 1; //marca a ocorrência de um erro
                printf("ERRO 1: A validade deve possuir 10 caracteres e no formato indicado!\n");
            }

            //verifica se a data é válida
            if (sscanf(validade, "%d/%d/%d", &dia, &mes, &ano) != 3) {
                erro = 1;
                printf("ERRO 2: Deve ser informada no formato xx/xx/xxxx!\n");
            }

            if ((dia < 1 || dia > 31) || (mes < 1 || mes > 12) || (ano < 2020 || ano > 2100)) {
                erro = 1;
                printf("ERRO 3: Validade inválida!\n");
            }
        }while(erro == 1); //FIM DA ENTRADA DA VALIDADE

        idxPesquisa = -1;  //indica que por enquanto não encontrou ninguem com o mesmo nome

        //verifica se já existe um alimento cadastrada com o mesmo nome
        for(int i = 0; i < NUM_MAX; i++)
        {
            //compara as strings, se encontrar com o mesmo nome
            if(strcasecmp(vetor_alimento[i].nome, nome) == 0)
            {
                idxPesquisa = i; //indice do alimento com o mesmo nome no vetor de cadastro
                break;
            }
        }

        //caso o idxPesquisa seja diferente de -1, quer dizer que encontrou um alimento com o nome igual no cadastro.
        if(idxPesquisa != -1)
        {
            //indica que já existe um alimento com o mesmo nome no cadastro
            printf("\nErro: Não foi possível inserir os dados pois já existe um alimento com o mesmo nome no cadastro:\v");

            printf("\nAlimento com o mesmo nome: \n");
            printf("Nome:         %s\n", vetor_alimento[idxPesquisa].nome);
            printf("Quantidade:   %d\n", vetor_alimento[idxPesquisa].quantidade);
            printf("Validade:     %s\n\n",vetor_alimento[idxPesquisa].validade);
            system("pause");
        }

        //não encontrou um alimento já cadastrada com o mesmo nome!
        else {
            //procura um elemento livre (não ocupado) no vetor de alimentos!
            for(int i = 0; i < NUM_MAX; i++)
            {
                //encontrou uma posição livre
                if(vetor_alimento[i].ocupado == 0)
                {
                    vetor_alimento[i].ocupado = 1; //marca a posição do vetor como ocupada

                    //insere os dados do alimento no vetor !!!
                    strcpy(vetor_alimento[i].nome, nome);
                    vetor_alimento[i].quantidade = quantidade;
                    strcpy(vetor_alimento[i].validade, validade);

                    total_alimento = total_alimento + 1; //incrementa a variavel global que contem o total de alimentos cadastrados

                    printf("\nDados cadastrados com sucesso! \n");
                    system("pause");
                    break;
                }
            }
        }

        //mostra uma mensagem na tela perguntando se o usuário deseja cadastrar outro alimento // essa função retorna 1 (escoheu sim) ou 0 (escolheu não)
        continuar = tela_mensagem("\nGostaria de cadastrar outro alimento? ");

    } while(continuar == 1);
}


//---------------------------------------------------------------------------------------------------------------------------------------------


//mostra a tela de pesquisa pelo nome
void tela_pesquisar()
{
    char nome[101];
    int idxPesquisa = -1; //guarda o indice de: alimento pesquisado - alimento que será removida
    int continuar; //controla se o usuário quer cadastrar um novo alimento
    int erro;       //indicador de erro usado na leitura de valores do teclado

    do{
        system("cls");
        printf("2 - Pesquisar \n");

        // verifica se há algum alimento cadastrado
        if (estoque_vazio()) {
            return; // sai da função se o estoque estiver vazio
        }

        //ENTRADA DO NOME DO ALIMENTO
        do {
            erro = 0; //marca que por enquanto não houve erro

            printf("\nDigite o nome: "); //ler no máximo 100 caracteres
            scanf(" %100[^\n]", nome);

            fflush(stdin); // limpa lixo no buffer do teclado
        } while(erro == 1); // FIM ENTRADA DO NOME

        //indica que por enquanto não encontrou nenhum alimento com o nome pesquisado
        idxPesquisa = -1;

        //pesquisa um alimento no cadastro a partir do nome, percorre todo o vetor com o cadastro dos alimentos
        for(int i = 0; i < NUM_MAX; i++){
            //verifica se está ocupado com os dados de um alimento
            if(vetor_alimento[i].ocupado == 1) {
                //verifica se o nome do alimento é igual ao nome pesquisado
                if(strcasecmp(vetor_alimento[i].nome, nome) == 0){
                    //guarda o indice do alimento que tem o nome igual ao nome pesquisado
                    idxPesquisa = i;
                    break; //encontrou o alimento, encerra o laço de busca
                }
            }
        }

        //caso o indice seja diferente de -1, quer dizer que encontrou um alimento com o nome igual ao nome pesquisado.
        if(idxPesquisa != -1) {
            printf("\nAlimento Encontrado: \n");
            printf("Nome:         %s\n", vetor_alimento[idxPesquisa].nome);
            printf("Quantidade:   %d\n", vetor_alimento[idxPesquisa].quantidade);
            printf("Validade:     %s\n\n", vetor_alimento[idxPesquisa].validade);
            system("pause");
        }
        //não encontrou um alimento
        else {
            printf("\nNão foi encontrado um alimento com o nome informado!\n\n");
            system("pause");
        }

        //mostra uma mensagem na tela perguntando se o usuário deseja cadastrar outro alimento // essa função retorna 1 (escoheu sim) ou 0 (escolheu não)
        continuar = tela_mensagem("\nGostaria de pesquisar outro alimento? ");

    } while(continuar == 1);
}


//---------------------------------------------------------------------------------------------------------------------------------------------


//mostra a tela remover alimento do cadastro
void tela_remover()
{
    char nome[101];
    int idxPesquisa = -1; //guarda o indice de: alimento pesquisado - alimento que será removida
    int continuar; //controla se o usuário quer cadastrar um novo alimento
    int erro;       //indicador de erro usado na leitura de valores do teclado

    do {
        system("cls");
        printf("3 - Remover \n");

        // verifica se há algum alimento cadastrado
        if (estoque_vazio()) {
            return; // sai da função se o estoque estiver vazio
        }

        //ENTRADA DO NOME DO ALIMENTO
        do {
            erro = 0; //marca que por enquanto não houve erro

            printf("\nDigite o nome: ");
            scanf(" %100[^\n]", nome);

            fflush(stdin); // limpa lixo no buffer do teclado!!!
        } while(erro == 1); // FIM ENTRADA DO NOME DO ALIMENTO

        idxPesquisa = -1; //indica que por enquanto não encontrou ninguem com o nome pesquisado

        //percorre todo o vetor com os alimentos cadastradas
        for(int i = 0; i < NUM_MAX; i++) {
            //verifica apenas elementos do vetor de alimentos que realmente estão ocupados
            if(vetor_alimento[i].ocupado == 1) {
                //verifica se o nome do alimento é igual ao nome passado como parâmentro
                if(strcasecmp(vetor_alimento[i].nome, nome) == 0){
                    //encontrou o alimento, então tem que decrementar o contador de alimentos
                    total_alimento = total_alimento - 1;
                    //marca o espaço/elemento do vetor como livre, ou seja pode ser reutilizado para guardar os dados de outro alimento!
                    vetor_alimento[i].ocupado = 0;
                    //guarda o indice do alimento que tem o nome igual ao nome pesquisado
                    idxPesquisa = i;
                    break;
                }
            }
        }

        //caso o indice seja diferente de -1, quer dizer que encontrou um alimento com o nome igual ao nome pesquisado.
        if(idxPesquisa != -1) {
            printf("\nAlimento removido com sucesso!\n\n");
        }
        else {
            printf("\nNão foi possível remover o alimento do cadastro!\n\n");
        }
        system("pause");

        //mostra uma mensagem na tela perguntando se o usuário deseja cadastrar outro alimento // essa função retorna 1 (escoheu sim) ou 0 (escolheu não)
        continuar = tela_mensagem("\nGostaria de remover outro alimento? ");
    } while(continuar);
}


//---------------------------------------------------------------------------------------------------------------------------------------------


//mostra a tela de relatório
void tela_relatorio()
{
    system("cls");
    printf("4 - Relatório \n");

    // verifica se há algum alimento cadastrado
    if (estoque_vazio()) {
        return; // sai da função se o estoque estiver vazio
    }

    printf("Total de Alimentos Cadastrados: %d\n\n", total_alimento);

    //percorre todo o vetor com o cadastro dos alimentos
    for(int i = 0; i < NUM_MAX; i++){
        if(vetor_alimento[i].ocupado == 1) {
            printf("Nome:         %s\n", vetor_alimento[i].nome);
            printf("Quantidade:   %d\n", vetor_alimento[i].quantidade);
            printf("Validade:     %s\n\n", vetor_alimento[i].validade);
        }
    }
    system("pause");
}


//---------------------------------------------------------------------------------------------------------------------------------------------


// Mostra a tela sair // retorna 1 caso o usuário escolha encerrar a aplicação e 0 caso contrário
int tela_sair()
{
    int sair;
    system("cls");
    printf("5 - Sair \n");

    //mostra uma mensagem na tela perguntando se o usuário deseja cadastrar outro alimento // essa função retorna 1 (escoheu sim) ou 0 (escolheu não)
    sair = tela_mensagem("\nDeseja mesmo sair?");

    return sair; //retorna 1 (sair) ou 0 (não sair)
}


//---------------------------------------------------------------------------------------------------------------------------------------------


// Mostra quando o estoque estiver vazio
int estoque_vazio()
{
    // verifica se há algum alimento cadastrado
    if (total_alimento == 0) {
        printf("\nEstoque vazio, portanto não há alimentos cadastrados!!\n\n");
        system("pause");
        return 1; // estoque vazio
    }
    return 0; // estoque não vazio
}


//---------------------------------------------------------------------------------------------------------------------------------------------


    // Mostra uma mensagem com a opçao de escolher "sim" ou "não" // retorna 1 caso seja escolhido o "sim" e 0 caso seja escolhido o "não"
int tela_mensagem(char *mensagem)
{
    char ch;              //usado no controle de opções "sim" ou "não"
    char texto[101] = ""; //cria uma string vazia com capacidade de até 100 caracteres
    int erro;             //indicador de erro usado na leitura de valores do teclado

    strcat(texto, mensagem); //copia a mensagem e coloca " (s/n): " no final
    strcat(texto, " (s/n): ");

    do {
        erro = 0; //limpa / indica que ainda não ocorreu um erro

        printf(texto); //imprime a mensagem

        scanf(" %c", &ch); //lê a escolha do usuário

        fflush(stdin); //limpa o buffer do tecaldo (windows), se o usuário digitar mais de um caracteres o buffer ficará com lixo (por isso eu limpo)

        ch = toupper(ch); //converte o caractere lido para maiusculo

        if(!(ch == 'S' || ch == 'N')) { //verifica se o usuário selecionou um caractere válido
            erro = 1;
            printf("ERRO: São aceitos apenas os valores 's' ou 'n'!\n");
        }
    } while(erro); //executa o laço enquanto o usuário não digitar 's' ou 'n'

    //retorna 1 se escolheu 's' e 1 se escolheu 'n'
    if(ch == 'S')
        return 1;
    else
        return 0;
}











//---------------------------------------------------------------------------------------------------------------------------------------------

                            // FUNÇÕES DE ARQUIVO

//---------------------------------------------------------------------------------------------------------------------------------------------


    // Cria o arquivo de dados (caso ele não exista) que irá guardar os dados do cadastro
void cadastro_inicializar_arquivo()
{
	strcpy(caminho_arquivo_alimento, "EstoqueAlimentos.txt"); //caminho e nome do arquivo usado para salvar os dados do cadastro de alimentos - é uma variável global

	FILE *fp = fopen(caminho_arquivo_alimento, "r"); //tenta abrir o arquivo para leitura, se conseguir quer dizer que ele existe

	if(fp == NULL) //indica que não conseguiu abrir o arquivo (ex: ele não existe)
    {
		fp = fopen(caminho_arquivo_alimento, "w"); //cria o arquivo pela primeira vez

		fprintf(fp, "%d\n", total_alimento); //a primeira linha do arquivo sempre irá ter o total de alimentos salvos;

		fclose(fp); //fecha o arquivo
	}
	else //conseguiu abrir o arquivo, então ele existe
    {
		fclose(fp); //fecha o arquivo
	}
}


//---------------------------------------------------------------------------------------------------------------------------------------------


    // Carrega os dados de um arquivo de texto para o vetor de estruturas Alimento
void cadastro_carregar_dados_arquivo()
{
	FILE *fp = fopen (caminho_arquivo_alimento, "r"); //abre o arquivo contendo os dados do cadastro - o arquivo deve existir

	if(fp == NULL){ //caso o arquivo não exista ou não seja entrado
		printf("Erro ao abrir o arquivo !!!");
		exit(EXIT_FAILURE); //encerra o programa sinalizando uma falha
	}

	//lê a primeira linha do arquivo que sempre irá conter o total de alimentos cadastrados
    //o espaço em branco no final do especificador de formato é para o scanf ler e descartar os caracteres '\n'
	fscanf(fp, "%d ", &total_alimento);

    //for utilizado para ler todos os cadastro de alimento do arquivo
	for(int i = 0; i < total_alimento; i++){

		Alimento alimento; //variavel usada para guardar os dados de um alimento

		//lê os dados do alimento no arquivo e salva na variável alimento
        //o espaço em branco no final do especificador de formato é para o scanf ler e descartar os caracteres '\n'
		fscanf(fp, "%100[^\n] ", alimento.nome);
		fscanf(fp, "%d ", &alimento.quantidade);
		fscanf(fp, "%10[^\n] ", alimento.validade);

		alimento.ocupado = 1; //marca a struct como ocupada (contém dados)

		vetor_alimento[i] = alimento; //insere a variável alimento no vetor de alimento
	}
	fclose(fp); //fecha o arquivo
}


//---------------------------------------------------------------------------------------------------------------------------------------------


//salva os dados do vetor de estrutura Alimento em um arquivo de texto
void cadastro_salvar_dados_arquivo()
{
    //abre o arquivo contendo os dados do cadastro - o arquivo deve existir - abre o arquivo para escrita, apaga todo o conteúdo dele
	FILE *fp = fopen (caminho_arquivo_alimento, "w");

	//caso o arquivo não exista ou não seja entrado
	if(fp == NULL){
		printf("Erro ao abrir o arquivo !!!");
		exit(EXIT_FAILURE); //encerra o programa sinalizando uma falha
	}

	fprintf(fp, "Total de Alimentos: %d\n\n", total_alimento); //grava, na primeira linha do arquivo, sempre o total de alimentos cadastrados

	//percorre todo o vetor de alimentos, salvando apenas os elementos do vetor que contém dados (estão ocupados)
	for(int i = 0; i < NUM_MAX; i++)
    {
        //se o elemento do vetor conter os dados de um alimento
        if(vetor_alimento[i].ocupado == 1) {
            //salva os dados do alimento no arquivo
            fprintf(fp, "Nome: %s\n", vetor_alimento[i].nome);
            fprintf(fp, "Quantidade: %d\n", vetor_alimento[i].quantidade);
            fprintf(fp, "Validade: %s\n\n", vetor_alimento[i].validade);
        }
    }
	fclose(fp); //fecha o arquivo - nesse ponto os dados são salvos de fato no arquivo
}
