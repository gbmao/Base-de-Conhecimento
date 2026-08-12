# Casos de uso


Diagramas de caso de uso são modelos simples para documentar de forma esquemáticas as funções de um sistema a partir do ponto de vista do user.
Bem  como as interrelações das funções de um sistema e as relações entre essas funções e seu ambiente.

---

- existem 3 objetos no diagrama de caso de uso


1. [nome] = caso de uso. *ex* `cadastrar usuário`

2. [ator] = não representa uma pessoa em si. representar um grupo ou um função, ou outro sistema. É, basicamente quem interage com o sistema

3. [limite do sistema] = limite do sistema: ator e caso de uso ficam do lado de fora, pois não fazem parte do sistema



### Relações


- extend: basicamente significa que um caso de uso não representa toda funcionalidade, nesse caso você o extende

- include: um caso de uso chama, obrigatoriamente outro caso de uso

casoA[caso de uso A] --extend--> casoB[caso de uso B]
casoA <--include-- casoB



ator[ator] <-- associação --> casoA

ator --generalização--> ator





## Como identificar atores e casos de uso

- Quem utiliza o sistema?
- Como é o uso do sistema?
- Quais informações são fornecidas ou obtidas pelo sistema?
- Como o sistema é mantido?
- Quais outros sistemas interagem com esse sistema?


### Perguntas para detalhar cenários

- Quando tudo da certo, como o sistema se comporta?
- Algo pode ocorrer diferente?
- O que pode dar errado?



---

## Exemplo


# Diagrama de caso de uso de sistema de locadora

- Ao realizar uma locação, o locador informa seu código. se o código não estiver cadastrado, a locação deve ser cancelada eo cliente informado de como proceder.
Caso esteja cadastrado, verificar se o locador não tenha pendencias

- caso o locador não tenha pendências, o funcionário deve registrar a locação e fornecer o carro.

- O funcionário deve realizar a manutenção dos carros, por exemplo cadastrar um novo carro.




locador --> cadastrar locador

funcionario --> cadastrar locador

locador --> realizar locação

funcionario --> realizar locação

funcionario --> manter carros






### Especificações



Nome|Realizar locação
:--:|:--:
*Atores*|Locador,Funcionário
*Resumo*| Descreve a sequência de funções realizadas para fazer a locação de um carro
*Pré-condições*|Existir carro disponível
*pós-condições*|Pagar valor da locação
*Fluxo principal*| -
*Ações do ator*|*ações do sistema*
1.informar código|- 
-| 2.Verificar situação do locador
-| 3.Locar carro para locador
*Fluxo Alternativo(1)*| Cliente não cadastrado, encaminha para cadastro
*Fluxo alternativo(2)*| Locador possui pendências de pagamentos, cacelar locação até que sejam satisfeitas


---
 
