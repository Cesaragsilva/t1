*Realize o clone desse repositorio! (Diretorio na máquina de sua preferencia)

		* As instruções estão dentro de cada projeto. Verifique e implemente, após realizar o teste faça um pull request para o repositorio inicial *

# Questões Teóricas

* Qual a diferença entre uma Struct e uma Class?
Não é possível criar uma classe que herde uma struct, construtor obrigatório para Struct e opcional para Class, é obrigatório a atribuir valores às variáveis locais logo ao instancia-las nas Struct e nas classes não, a instância de um Struct é limpo da memória assim que o método é retornado o oposto de uma classe, ao atribuir valor à variável é feito uma cópia e não uma referência em uma Struct, além de todo oposto citado anteriormente Class comumente têm seu nivel de acesso private e Struct public;

* Qual o objetivo da criação de um Objeto Anônimo?
O objetivo principal é encapsular propriedade somente leitura em um unico objeto sem precisar inferir um tipo explicitamente

* Explique o termo CRUD
É uma sigla auto explicativa, C - Create, R - Read, U - Update, D - Delete, são funções básicas de um sistema qualquer

* Qual o gerenciador de pacotes mais utilizado no momento?
NuGet

* Explique a grande diferença entre .NET e .NET CORE
A maior diferença no meu ponto de vista é a portabilidade que o Core possibilita, sendo ele otimizado e mais simples com maior foco em web, containers e microsserviços, além de ser multiplataforma (Linuz, Windows, Mac)

* Qual o conceito e suas vantagens do termo REST?
REST é um padrão arquitetura de API comumente utilizado para organizar endpoints em verbos e nomeações padronizadas, além de ter um retorno de dado comumente padronizado para consumo em diversas aplicações. Seu retorno de dado mais comum é no formato .JSON

* Windows Services possuem algumas desvantagens, comente sobre?
-

* Explique o conceito de orientação orientada a objeto e de um exemplo.
O paradigma de orientação a objeto (POO) tende a abstrair conceitos reais de objetos tornando-os em classes que são instanciados e geram "objetos" em memória para utilização singular sem que haja conflito ou sobreposição entre os dados

* Explique os 4 pilares da programação orientada a objetivo.
Se me recordo bem, os pilares são a Abstração, que traz a ideia de algo real para o código (objeto); Herança, que tende a reutilizar código de uma classe já existente; Encapsulamento, que torna os dados acessíveis dentro de um escopo definido (public, private, protected, static) e o Polimorfismo que permite um método ou função aceitar diversar assinaturas em sua invocação

* Explique como funciona um gerenciamento de rotas de uma SPA
A ideia de uma SPA é carregar diversas páginas em uma página principal não recarregando a aplicação mas sim chamando rotas de forma dinâmica, essas rotas geralmente são organizadas por módulos, mas isso depende da arquitetura da aplicação;

* Falando sobre DevOps, comente o que conhece sobre.
DevOps é uma cultura que tende a aproximar os programadores do meio de infraestruturas, trazendo geralmente sistemas para orquestração de periféricos e também a própria entrega de código.

* Explique sobre um método agile.
Métodos agile são conjunto de ações que tendem organizar e otimizar a entrega de trabalhos. O Scrum é um método agile, ele é um framework que utiliza-se do conceito de "sprint" para quebrar uma entrega grande em pequenas entregar, mantendo um fluxo de planejamento e replanejamento, entrega e validação num cronograma setado pelo próprio time

* Comente sobre CI e CD.
CI e CD tratam da "integração continua" e "entrega continua" respectivamente, são métodos facilitadores para entrega constante do produto ao usuário final/cliente

* Comente o que sabe sobre Docker/Container.
Containers são pacotes facilitadores, são escálaveis, facilmente gerenciáveis e podem mudar de um ambiente em poucos segundos, trazendo maior garantia de funcionamento da aplicação caso um deles dê erro, pois sua instalação é dependente de pouco tempo

* Quais as vantagens e desvantagens sobre API e quais preocupaçõe devemos ter quando escolhemos essa abordagem ?
API trazem facilidade de integração entre sistemas, manutenção mais simples e organização maior, acredito que uma API pode trazer desvantagens em sua alteração da entrega de dados que pode quebrar uma integração já criada e que não esperava pela mudança do endpoint, e também pode ser desnecessária se a aplicação for simples, pequena e única e os serviços todos próprios

* Fale um pouco sobre o conceito de mensageria e cite um sistema que exerça essa função.
Tenho pouco conhecimento sobre o assunto, porém sei que é um conceito de sistemas distribuidos para comunicação por meio de eventos. Posso citar o Kafka e o RabbitMQ como sistemas de mensageria