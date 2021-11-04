## Paradigma

No mundo de programação existem vários paradigmas.. dentre eles a orientação á objetos, que refere-se ao mundo real.. objetos do dia a dia e utiliza uma abordagem de **resolver problemas** pensando nisso; dividir para conquistar, reutilizar e reaproveitar (através de ponteiros) código de forma organizada e simples.

## Classe e Objeto

São divididos entre propriedades (características), métodos (ações) e eventos que são respostas ás ações.

Objeto - sempre é um tipo de referência (memória de ponteiro)

Class - molde para um objeto 

Struct - preferencia de se utilizar, armazena tipos de valor

## Encapsulamento

Basicamente o encapsulamento é um dos principais pilares da OO, é o conceito de encapsular os atributos de casses e objetos nos mesmos, segregando e separando em conjuntos coisas que são relacionadas.

## Abstração

É o ato de esconder os detalhes. Coisas que não fazem sentido serem expostas, devem ser abstraídas. Quanto menor a exposição de um objeto, melhor.

## Herança

É a capacidade que um objeto tem de herdar propriedades, métodos e eventos de outros objetos.

## Polimorfismo

Determina que os objetos podem assumir várias formas. Ou seja, dois objetos podem ser filhos de um mesmo pai porém realizar ações diferentes no mesmo método herdado.

- virtual - permite que o método seja subscrito
- override - subscrição do método

## Modificadores de Acesso

Determinam o por quem e como podem ser acessados os atributos, métodos e eventos das classes, são eles:

- private - o atributo é privado da classe
- protected - permite acessar dados privados de um pai (herança)
- internal - qualquer classe do mesmo namespace tem acesso ao atributo
- public - acesso liberado á todos

## Tipos Complexos

Sempre que criamos classes ou structs, estamos criando um novo tipo complexo, que são todos os que não são primitivos.

- primitive obsession: obsessão por tipos primitivos: é negativo, o ideal é segmentar o máximo possível as classes, para justamente conseguir reaproveitar

## Propriedades

As propriedades da classe são os atributos de fato, existem atalhos para criar propriedades:

- prop
- propfull
- propg

o "GET" e o "SET" são os assessores, podem ser modificados para interagirmos com a ação.

## Métodos

São as ações de uma classe.

- Podem haver várias sobrecargas (overloads) com o mesmo nome, desde que o tipo dos atributos seja diferente. Pode receber atributos com valores automáticos.
- Também trabalham com o modificador virtual para poderem ser sobrescritos.
- Podem ser métodos construtores nas classes, que serão sempre chamados durante a instância daquela classe.
- Os construtores de filhos podem referenciar o construtor do pai com o ": base"

## Using e Dispose

.NET framework possui o garbage collector, que de tempos em tempos limpa objetos em memória que não estão mais sendo utilizados.

Para que uma classe possa ser destruível, ela precisa implementar a interface "IDisposable", que determina o contrato com o método "Dispose". Sendo assim, toda vez que o objeto for destruído, o método dispose será chamado.

Para garantir que o dispose seja chamado, utiliza-se o "using".

## Classes Estáticas

Classes estáticas não podem ser instanciadas, pois são estáticas, ou seja, a classe já está disponível em memória junto ao start da aplicação.

Uma utilização boa são configurações, já que serão utilizadas por toda a aplicação. É necessário tomar cuidado para não ter classes pesadas ou classes que serão utilizadas por múltiplos usuários, por exemplo: não faz sentido uma classe de pagamento estática, já que cada pagamento atende um contexto e é único.

## Classes Seladas

O modificador "sealed" serve para  impedir que a classe seja derivada pelas demais. Utiliza-se quando não se quer ter versões de uma determinada classe.

## Classes Parciais (Partial Class)

Serve para separar uma classe em mais pedaços. Dentro do mesmo namespace, se a classe tiver o mesmo nome e o prefixo "partial", a classe pode ser fragmentada. Proporciona uma melhor organização no projeto, para que separemos por contexto as propriedades das classes.
No final, a classe sera uma só, qualquer instância "enxerga" o conteúdo de todas as partes.

## Interfaces

A interface nada mais é do que um contrato. Essa classe vai determinar o que as classes que herdarem dessa interface devem ter. A ideia não é dizer como fazer, mas sim o que deve ser feito.

## Classes Abstratas

Classes que são abstratas, não podem ser instanciadas. Devem ser utilizadas quando existe algo abstrato, por exemplo "pagamento" e quer-se executar algo. A diferença da interface e da classe abstrata é que em classes abstratas pode-se executar métodos, por exemplo validações.

## Upcast e Downcast

Uma instância de uma determinada classe pode receber uma nova instância de uma outra classe desde que as classes possuam uma relação, nada mais é do que a assimilação de um objeto filho para um objeto pai. Isso é possível pois as classes compartilham seus atributos.

Upcast: pai virando filho

Downcast: filho virando pai (só é possível realizando um cast explícito)

## Comparando Objetos

Para que seja possível comparar objetos, é necessário herdar uma interface genérica chamada "IEquatable" que implica na instância do método "Equals", desta forma, pode-se determinar quais serão as regras da validação.

## Delegates

Também podem ser chamados de métodos anônimos. Servem para delegar funções para outros lugares do programa. É aplicado com o modificador "delegate". Para que seja possível, é necessário que a assinatura entre as funções seja a mesma.

Digamos que na classe "Pagamento", o método Pagar seja delegado, e numa outra classe possuamos o método "RealizarPagamento". Para chamarmos a função, será necessário criar uma instância, por exemplo:

```jsx
var pagar = new Pagamento.Pagar(RealizarPagamento);
pagar(valor);
```

## Events

Quando algo acontecer, um evento pode ser disparado. Para isso, utiliza-se o modificador "event" e é necessário haver o handler, desta forma:

```csharp
public event EventHandler RoomSoldOutEvemt;

protected virutal void OnRoomSoldOut(EventArgs e)
{
	EventHandler handler = RoomSoldOutEvent;
	handler.Invoke(this, e);
}
```

O código acima demonstra a chamada do evento. Podem ser adicionadas regras durante a execução do mesmo.

Para que o evento seja chamado por quem instanciar esse evento, é necessário delegar a ação ao evento. Isso pode ser feito com delegate ou então "+=" ao método do evento.

## Generics

É o modificador que permite a construção de coisas genéricas, classes que compartilhem a regra.

Normalmente, a letra <T> é utilizada como acrônimo á palavra "Type".

É possível limitar o tipo do generics com o modificador where, ex: <T> where T : Person. Podendo "person" ser uma classe ou uma interface.

## Listas

Basicamente, as listas em C# podem ser de qualquer coisa. Existem diferentes tipos:

List - A lista com mais membros e métodos, recomenda-se quando há muita manipulação no objeto.

ICollection - Utilizada mais com acesso á dados.

IEnumerable - Boa para restringir bastante o código, exemplo:

```csharp
IEnumerable<Payment> payments = new List<Payment>();
```
