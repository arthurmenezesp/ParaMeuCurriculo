O que foi utilizado
Linguagem de Programação: C#

Utilizamos o C# para implementar o simulador de jogo de dados devido à sua simplicidade e excelente suporte para manipulação de entrada/saída via console.
Estruturas:

Random: Para gerar números aleatórios (lançamento do dado).
Arrays: Para armazenar o número de vezes que cada face do dado foi lançada.
Estrutura de controle: Usamos um loop do-while para manter o menu interativo e executar o jogo até que o usuário decida encerrar.
Métodos:

LancarDado(): Método para gerar um número aleatório de 1 a 6, simulando o lançamento de um dado.
ExibirProbabilidades(): Método para calcular e exibir as probabilidades de cada face do dado sair.
Etapas implementadas
Criação de um menu interativo:

Um menu com opções para lançar o dado, exibir resultados, calcular probabilidades e sair do simulador.
Lançamento do dado:

Cada vez que o usuário seleciona a opção de lançar o dado, o método LancarDado() é chamado para gerar um número aleatório entre 1 e 6. O resultado é armazenado em um array que registra quantas vezes cada face foi sorteada.
Armazenamento de dados:

Utilizamos um array int[] resultados = new int[6] para rastrear quantas vezes cada face do dado saiu. O índice do array corresponde ao número da face do dado.
Cálculo de probabilidades:

O método ExibirProbabilidades() calcula a probabilidade de cada face sair, dividindo o número de vezes que aquela face foi sorteada pelo total de lançamentos e multiplicando por 100.
Controle de repetição e término:

O loop do-while garante que o menu seja repetido até o usuário escolher a opção "Sair", permitindo múltiplos lançamentos e exibições de probabilidades.
Backlog (melhorias futuras)
Interface gráfica:

Atualmente o código é um programa de console. Poderíamos migrar para uma interface gráfica (GUI), talvez usando Windows Forms ou WPF, para tornar o simulador mais visual e interativo.
Opção de diferentes tipos de dados:

Poderíamos adicionar a opção para simular dados com mais ou menos de 6 faces (como um dado de 10 ou 20 lados), o que ampliaria a funcionalidade do simulador.
Armazenamento e recuperação de histórico:

Implementar a capacidade de salvar o histórico de lançamentos em um arquivo, para que o usuário possa continuar a simulação em outro momento.
Simulação de múltiplos dados ao mesmo tempo:

Poderíamos permitir ao usuário lançar múltiplos dados simultaneamente, registrando os resultados de cada um separadamente.
Medições estatísticas avançadas:

Implementar mais cálculos estatísticos, como desvio padrão, média de resultados, ou comparações de diferentes séries de lançamentos.