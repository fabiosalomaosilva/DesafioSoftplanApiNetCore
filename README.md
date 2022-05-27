# Desafio Softplan - Backend .Net

Teste técnico para criação de Web API com regras de negócio e persistencia de dados, utilizando conceitos de DDD, SOLID e Clean Code

Criação de um front-end em Angular 12, com telas de CRUD

# Considerações

Projeto possui uma API padronizada em que se utiliza, com exceção dos endpoints de "account", do respeito aos verbos HTTP ao estilo RestFull.
Desenvolvido em .Net Core 3.1

Acesso à API exige autenticação basic com usuário pré-existente resgistrado em seed na primeira migration. (email: tester@teste.com | password: teste123)

Foi disponibilizada documentação do Swagger para consultas, em ambiente de desenvolvedor.

Possui versionamento V1 e V2.

Os dados relativos aos países que são persistidos em banco de dados, estão sendo convertidos na camada de "services" de objeto C# para json e inseridos em linha campo único.

Os dados estão sendo persistidos em banco de dados Postgres
    
Em razão da indisponibilidade técnica da API Graph Countries, os dados estão sendo validados na API Rest Countries
Aplicação possui Dockerfile e roda em ambiente Docker
    
NÃO NECESSITA DE CONFIGURAÇÕES PARA NOVAS IMPLANTAÇÕES para as APIs de países.
    
Possui implementação do serviço SignalR para disponibilização de chat em tempo real. 
Para o serviço de chat, é necessário apontar a origem do (URL do site) cliente Frontend React, no CORS da API para faver a conexão.
    
# Endereços dos serviços publicados

- Projeto publicado em Azure Web App com o seguinte endereço (acessível por clientes Rest):
 
https://desafiosoftplanapinetcore.azurewebsites.net
 
 
- O cliente Frontend (com o chat em funcionamento) está disponível em:
 
http://desafiosoftplan.salomaovogth.com.br

- API possui endpoint via HTTP GET que retorna os links de repositórios:

https://desafiosoftplanapinetcore.azurewebsites.net/api/v1/RepositoriosGit
    
    
