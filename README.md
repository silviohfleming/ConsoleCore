# Resutaldo Final:

Dois microserviços que se comunicam entre si, com persistência de dados, utilizando bancos não relacionais e relacionais.

O primeiro microserviço é de cadastro de usuários, possuindo seguintes recursos: 

- Listar, exibir, criar, alterar e excluir usuários.

O segundo microserviço é de cadastro de pedidos, onde cada pedido possui o id do usuário que solicitou o pedido e se comunica com microserviço de usuários para verificar se o id do usuário é existente para realizar o pedido, onde o mesmo possui os seguintes recursos:

- Listar, Listar por usuário, exibir, criar, alterar e excluir.

Cada microserviço por sua vez, faz a persistência dos dados em seus respectivos banco de dados, utilizando os padrões REST.

# Requisitos:

Permitir comunicações com as portas 8080, 8090, 9200, 6379 e 5432 em seu host local, pois são as portas utilizadas nos microsserviços.

# Libraries Utilizadas:

- User Api:
  FastApi, SQLAlchemy, Redis e Pytest.

- Order Api:
  FastApi, ElasticSearch, Requests e PyTest.

FastApi: É um framework para Python, com alto desempenho, fácil de aprender, rápido para codificar e pronto para produção.

SQLAlchemy: É um kit de ferramentas Python SQL e mapeador relacional de objetos que fornece aos desenvolvedores de aplicativos todo o poder e flexibilidade do SQL.

Redis: É um armazenamento de estrutura de dados na memória de código aberto (licenciado por BSD), usado como banco de dados, cache e agente de mensagens.

Pytest: É um framework que torna fácil a escrita de códigos para testes, mas pode ser escalonada para suportar testes funcionais complexos para aplicativos e bibliotecas.

ElasticSearch: É um mecanismo de busca e análise de dados distribuído e open source para todos os tipos de dados, incluindo textuais, numéricos, geoespaciais, estruturados e não estruturados.

Requests: É uma biblioteca HTTP elegante e simples para Python.

# Execução dos microserviços com Docker:

Sequência: user-api > order-api.

Com docker em execução, acesse a raiz de cada Api e execute: 
  
```  
  docker-compose up -d
```

# Endereços e Microserviços:

Acesse através do navegador:

User Api: http://localhost:8080/docs / http://localhost:8080/redoc

Order Api: http://localhost:8090/docs / http://localhost:8090/redoc

PostgreSQL: localhost:5432
- Usuário: postgres
- Senha: postgres

ElasticSearch: localhost:9200

Variáveis de ambiente estão localizadas no arquivo ".env"

# Links e Demais Observações:

Para Utilizar Docker é necessario ter instalado:

```  
  Docker: https://www.docker.com/

  Docker-Compose: https://docs.docker.com/compose/
  
``` 



PR:

## Descrição

Esta PR implementa solução para o problema proposto no commit #19b7e03372a16034ed1025ff51105d3cbe74f356.

Criação de dois microserviços que se comunicam entre si, com persistência de dados, utilizando bancos não relacionais e relacionais.

O primeiro microserviço é de cadastro de usuários, possuindo seguintes recursos:

Listar, exibir, criar, alterar e excluir usuários.
O segundo microserviço é de cadastro de pedidos, onde cada pedido possui o id do usuário que solicitou o pedido e se comunica com microserviço de usuários para verificar se o id do usuário é existente para realizar o pedido, onde o mesmo possui os seguintes recursos:

Listar, Listar por usuário, exibir, criar, alterar e excluir.
Cada microserviço por sua vez, faz a persistência dos dados em seus respectivos banco de dados, utilizando os padrões REST.

## Tecnologias

- User Api: FastApi, SQLAlchemy, Redis e Pytest.

- Order Api: FastApi, ElasticSearch, Requests e PyTest.

FastApi: É um framework para Python, com alto desempenho, fácil de aprender, rápido para codificar e pronto para produção.

SQLAlchemy: É um kit de ferramentas Python SQL e mapeador relacional de objetos que fornece aos desenvolvedores de aplicativos todo o poder e flexibilidade do SQL.

Redis: É um armazenamento de estrutura de dados na memória de código aberto (licenciado por BSD), usado como banco de dados, cache e agente de mensagens.

Pytest: É um framework que torna fácil a escrita de códigos para testes, mas pode ser escalonada para suportar testes funcionais complexos para aplicativos e bibliotecas.

ElasticSearch: É um mecanismo de busca e análise de dados distribuído e open source para todos os tipos de dados, incluindo textuais, numéricos, geoespaciais, estruturados e não estruturados.

Requests: É uma biblioteca HTTP elegante e simples para Python.

## Comandos e Execução

**Sequência**: user-api > order-api.

Com docker em execução, acesse a raiz de cada Api e execute: 
  
```  
  docker-compose up -d
```

Acesse através do navegador:

User Api: http://localhost:8080/docs / http://localhost:8080/redoc

Order Api: http://localhost:8090/docs / http://localhost:8090/redoc

PostgreSQL: localhost:5432
- Usuário: postgres
- Senha: postgres

ElasticSearch: localhost:9200

Variáveis de ambiente estão localizadas no arquivo ".env"

## Observações

* Escolha do Pyhton FastApi como framework: Ele possui grande performance, fácil aprendizado, código rápido, produção em tempo real, intuitivo e robusto.
