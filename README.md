# ToDoList

Este é um projeto simples de gerenciamento de tarefas criado em C#. O sistema permite que o usuário adicione, remova, busque e liste tarefas, além de outras operações de gerenciamento.

## Funcionalidades

- Adicionar nova tarefa com título e data de vencimento.
- Remover tarefa pelo ID informado.
- Buscar tarefas pelo nome.
- Listar todas as tarefas.
- (Outras funcionalidades podem ser implementadas conforme necessário.)

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (versão compatível com o projeto, por exemplo, .NET 6 ou superior)
- [Visual Studio Code](https://code.visualstudio.com/) (opcional, mas recomendado)
- Sistema Operacional Windows

## Como Executar

1. Clone o repositório:

   ```bash
   git clone https://github.com/joaoemanoelaho/ToDoList.git
   ```
2. Navegue até o diretório do projeto:
   ```bash
   cd ToDoList
   ```
3. Compile o projeto:
   ```bash
   dotnet build
   ```
4. Execute o projeto:
   ```bash
   dotnet run --project ToDoList
   ```

Estrutura do Projeto
Tarefa.cs: Define a classe Tarefa com propriedades como Id, Título, Data de Vencimento e status de conclusão.
GerenciadorTarefas.cs: Contém os métodos para manipulação da lista de tarefas (adicionar, remover, buscar, etc).
Program.cs: Ponto de entrada do aplicativo, onde o menu interativo é exibido e as operações são executadas.
Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests para melhorar o projeto.

Licença
Este projeto está licenciado sob a MIT License.

Aviso
Este projeto é um exemplo educacional e pode ser estendido conforme suas necessidades.
