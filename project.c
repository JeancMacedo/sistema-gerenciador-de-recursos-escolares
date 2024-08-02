#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_PRODUTOS 100

// Definição da estrutura Produto
typedef struct {
    char nome[50];
    int quantidade;
    char tamanho[10];
} Produto;

// Função para adicionar um produto ao estoque
void adicionarProduto(Produto estoque[], int *numProdutos) {
    if (*numProdutos < MAX_PRODUTOS) {
        printf("Nome do produto: ");
        scanf("%s", estoque[*numProdutos].nome);
        printf("Quantidade: ");
        scanf("%d", &estoque[*numProdutos].quantidade);
        printf("Tamanho: ");
        scanf("%s", estoque[*numProdutos].tamanho);

        (*numProdutos)++;
        printf("Produto adicionado com sucesso!\n");
    } else {
        printf("O estoque esta cheio. Não eh possivel adicionar mais produtos.\n");
    }
}

// Função para exibir o estoque
void exibirEstoque(Produto estoque[], int numProdutos) {
    printf("===== ESTOQUE =====\n");
    printf("Nome\t\tQuantidade\tTamanho\n");
    for (int i = 0; i < numProdutos; i++) {
        printf("%s\t\t%d\t\t%s\n", estoque[i].nome, estoque[i].quantidade, estoque[i].tamanho);
    }
}

// Função para salvar o estoque em um arquivo CSV
void salvarEstoqueEmCSV(Produto estoque[], int numProdutos, const char *nomeArquivo) {
    FILE *arquivo = fopen(nomeArquivo, "w");
    if (arquivo == NULL) {
        printf("Erro ao abrir o arquivo para escrita.\n");
        return;
    }

    fprintf(arquivo, "Nome,Quantidade,Tamanho\n");
    for (int i = 0; i < numProdutos; i++) {
        fprintf(arquivo, "%s,%d,%s\n", estoque[i].nome, estoque[i].quantidade, estoque[i].tamanho);
    }

    fclose(arquivo);
    printf("Estoque salvo em %s com sucesso!\n", nomeArquivo);
}

// Função para salvar a presença dos alunos em um arquivo CSV
void salvarPresencaEmCSV(char nomes[][50], int presencas[], int numAlunos, const char *nomeArquivo) {
    FILE *arquivo = fopen(nomeArquivo, "w");
    if (arquivo == NULL) {
        printf("Erro ao abrir o arquivo para escrita.\n");
        return;
    }

    fprintf(arquivo, "Nome,Presenca\n");
    for (int i = 0; i < numAlunos; i++) {
        fprintf(arquivo, "%s,%d\n", nomes[i], presencas[i]);
    }

    fclose(arquivo);
    printf("Presenca salva em %s com sucesso!\n", nomeArquivo);
}

int main() {
    Produto estoque[MAX_PRODUTOS];
    int numProdutos = 0;
    int opcao;

    char nomesAlunos[MAX_PRODUTOS][50];
    int presencas[MAX_PRODUTOS];
    int numAlunos = 0;

    do {
        printf("\n===== SISTEMA GERENCIADOR DE RECURSOS ESCOLARES =====\n");
        printf("1. Adicionar Produto ao Estoque\n");
        printf("2. Exibir Estoque\n");
        printf("3. Salvar Estoque em Arquivo CSV\n");
        printf("4. Registrar Presenca de Aluno\n");
        printf("5. Salvar Presenca em Arquivo CSV\n");
        printf("6. Sair\n");
        printf("Escolha uma opcao: ");
        scanf("%d", &opcao);

        switch (opcao) {
            case 1:
                adicionarProduto(estoque, &numProdutos);
                break;
            case 2:
                exibirEstoque(estoque, numProdutos);
                break;
            case 3:
                salvarEstoqueEmCSV(estoque, numProdutos, "estoque.csv");
                break;
            case 4:
                if (numAlunos < MAX_PRODUTOS) {
                    printf("Nome do aluno: ");
                    scanf("%s", nomesAlunos[numAlunos]);
                    printf("Presenca (1 para presente, 0 para ausente): ");
                    scanf("%d", &presencas[numAlunos]);
                    numAlunos++;
                    printf("Presenca registrada com sucesso!\n");
                } else {
                    printf("Numero maximo de alunos atingido. Nao eh possivel registrar mais presenças.\n");
                }
                break;
            case 5:
                salvarPresencaEmCSV(nomesAlunos, presencas, numAlunos, "presenca.csv");
                break;
            case 6:
                printf("Encerrando o programa...\n");
                break;
            default:
                printf("Opcao invalida. Tente novamente.\n");
        }
    } while (opcao != 6);

    return 0;
}
