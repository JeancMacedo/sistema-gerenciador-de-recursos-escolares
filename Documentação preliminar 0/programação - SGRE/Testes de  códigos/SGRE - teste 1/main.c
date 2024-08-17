#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <locale.h>
#include <string.h>

#define NUM_MAX 100 // número máximo de alimentos cadastrados permitidos

typedef struct Alimento {
    int ocupado;
	char nome[101];
	int quantidade;
	char validade[11];
	int dia, mes, ano;
} Alimento;

int main()
{
    Alimento vetor_alimento[NUM_MAX]; //cria um vetor com capacidade de armazenar os dados de 100 alimentos
    int total_alimento = 0; //guarda o total de alimentos cadastradas

    //muda a localização para Português do Brasil
    setlocale(LC_ALL, "portuguese");
    system("chcp 1252 > null");

    //variaveis utilizadas para controlar o loop de execução do programa
    int sair = 0;   //controla quando o program deve ser encerrao
    int opcao;      //guarda a opção escolhida pelo usuário no menu de opção
    int erro;       //indicador de erro usado na leitura de valores do teclado
    int continuar;  //controla se o usuário quer: cadastrar, pesquisar, ou remover um alimento;
    char ch;        //usado no controle de opções "sim" ou "não"

    //inicializa o vetor de alimentos - livres / desocupados
    for(int i=0; i < NUM_MAX; i++)
    {
        //marca a posição como livre/desocupada, ou seja, pode receber os dados de um alimento!
        vetor_alimento[i].ocupado = 0;
    }

    //variáveis utilizadas para fazer a leitura dos dados do alimento do teclado!
	char nome[101];
	int quantidade;
	int dia, mes, ano;
	char validade[11];
    int idxPesquisa = -1; //guarda o indice de: alimento pesquisado - alimento que será removida

    //loop de execução do programa
    do {
        //TELA DE OPÇÕES
        system("cls");
        printf("Menu de Opções do Estoque de Alimentos \n");
        printf("1 - Cadastrar \n");
        printf("2 - Pesquisar\n");
        printf("3 - Remover \n");
        printf("4 - Relatório do estoque\n");
        printf("5 - Sair \n\n");

        printf("Escolha uma opção: "); //faz a leitura da opção escolhida
        erro = scanf("%d", &opcao);

        //verifica se houve uma falha na leitura do scanf
        if(erro != 1) {
            fflush(stdin); //limpa o buffer do tecaldo (windows)
            opcao = -1; //como teve uma falha na leitura, marca uma opção inválida
        }

        //verifica qual opção foi escolhida
        switch(opcao)
        {
            //TELA DE CADASTRO
            case 1:
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
                        if(strcmp(vetor_alimento[i].nome, nome) == 0)
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

                    //mostra uma mensagem na tela perguntando se o usuário deseja cadastrar outro alimento
                    do{
                        printf("\nGostaria de cadastrar outro alimento? (s/n): ");
                        scanf(" %c", &ch); //faz a leitura da opção (caractere) escolhida

                        fflush(stdin); //limpa o buffer do tecaldo (windows) se o usuário digitar mais de um caracteres o buffer ficará com lixo (por isso limpa)

                        ch = toupper(ch); //converte o caractere lido para maiusculo
                    }while(!(ch == 'S' || ch == 'N')); //caso o usuário não digite 's' ou 'n'

                    //o usuário decidiu cadastrar outra pessoa
                    if(ch == 'S') {
                        continuar = 1;
                    }
                    //o usário não quer cadastrar outra pessoa
                    else{
                        continuar = 0;
                    }
                } while(continuar == 1);
            break;

            //TELA DE PESQUISA
            case 2:
                do{
                    system("cls");
                    printf("2 - Pesquisar \n");

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
                            if(strcmp(vetor_alimento[i].nome, nome) == 0){
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

                    //mostra uma mensagem na tela perguntando se o usuário deseja pesquisar outro alimento
                    do{
                        printf("\nGostaria de pesquisar outro alimento?  (s/n): ");
                        scanf(" %c", &ch); //faz a leitura da opção (caractere) escolhida

                        fflush(stdin); //limpa o buffer do tecaldo (windows) se o usuário digitar mais de um caracteres o buffer ficará com lixo (por isso eu limpo)

                        ch = toupper(ch); //converte o caractere lido para maiusculo
                    } while(!(ch == 'S' || ch == 'N'));

                    //o usuário decidiu pesquisar outro alimento
                    if(ch == 'S') {
                        continuar = 1;
                    }
                    //o usário não quer pesquisar outro alimento
                    else{
                        continuar = 0;
                    }
                } while(continuar == 1);
            break;

            // TELA DE REMOÇÃO
            case 3:
                do {
                    system("cls");
                    printf("3 - Remover \n\n");

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
                            if(strcmp(vetor_alimento[i].nome, nome) == 0){
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
                        printf("\nAlimento removido com sucesso!\n");
                    }
                    else {
                        printf("\nNão foi possível remover o alimento do cadastro!\n");
                    }
                    system("pause");

                    //mostra uma mensagem na tela perguntando se o usuário deseja remover outro alimento
                    do {
                        printf("\nGostaria de remover outro alimento?  (s/n): ");
                        scanf(" %c", &ch); //faz a leitura da opção (caractere) escolhida

                        fflush(stdin); //limpa com lixo

                        ch = toupper(ch); //converte o caractere lido para maiusculo
                    } while(!(ch == 'S' || ch == 'N')); //caso o usuário não digite 's' ou 'n'

                    //o usuário decidiu pesquisar outro alimento
                    if(ch == 'S') {
                        continuar = 1;
                    }
                    //o usário não quer pesquisar outro alimento
                    else {
                        continuar = 0;
                    }
                }while(continuar);
            break;

            // TELA DE RELATÓRIO
            case 4:
                system("cls");
                printf("4 - Relatório \n\n");
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
            break;

            // TELA ENCERRAR APLICAÇÃO
            case 5:
                system("cls");
                printf("5 - Sair \n\n");

                do{
                    printf("Deseja mesmo sair?  (s/n): ");
                    scanf(" %c", &ch); //faz a leitura da opção (caractere) escolhida

                    fflush(stdin); // limpa com lixo

                    ch = toupper(ch); //converte o caractere lido para maiusculo

                    //caso o usuário escolha 'S', isto é sair
                    if(ch == 'S') {
                        //marca a variável sair como 1 para encerrar o loop do programa!!!
                        sair = 1;
                    }
                //caso o usuário não digite 's' ou 'n'
                }while(!(ch == 'S' || ch == 'N'));
            break;

            // TRATAMENTO DE OPÇÃO INVÁLIDA
            default:
                printf("\nOpção Inválida !!! \n"); //mostra uma mensagem informando que a opção escolhida do "Menu de Opções" é inválida!
                system("pause");
        }
    } while (sair == 0);

    system("cls");
    printf("\nFim da execução do programa!\n");

    return 0;
}
