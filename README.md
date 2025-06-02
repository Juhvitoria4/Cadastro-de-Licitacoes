title: Cadastro de Licitações - API e Frontend

resumo_do_desafio: >
  Este projeto consiste em desenvolver uma aplicação para cadastro de licitações,
  contendo uma API backend em .NET 8 com Entity Framework Core e MySQL,
  e um frontend em React para consumir a API. O objetivo é permitir operações CRUD
  (Criar, Ler, Atualizar e Deletar) para licitações, com validações e persistência no banco de dados.

detalhes_tecnicos:
  backend:
    plataforma: .NET 8 (Web API)
    orm: Entity Framework Core
    banco_de_dados: MySQL
    ferramentas:
      - Swagger para documentação
      - CORS configurado para integração com frontend
    configuracao: >
      Suporte a operações CRUD para a entidade Licitacao,
      incluindo validações de unicidade e campos obrigatórios.
  frontend:
    biblioteca: React (via Create React App)
    requisicoes_http: Axios
    funcionalidades:
      - Listagem de licitações
      - Formulário para criação
      - Exclusão de registros
    comunicacao: Consome API RESTful via HTTP
  configuracoes_importantes:
    - Backend configurado para permitir requisições do frontend (http://localhost:3000) via CORS.
    - Comunicação entre frontend e backend via HTTP (para desenvolvimento local, evitando problemas com certificados SSL autoassinados).

passos_para_execucao:

  pre_requisitos:
    - .NET 8 SDK: https://dotnet.microsoft.com/en-us/download
    - Node.js e npm: https://nodejs.org/
    - MySQL instalado e em execução localmente

  backend:
    - "Clone o repositório e entre na pasta do backend:"
    - 'cd Cadastro-de-Licitacoes/licitacaoApi'
    - "Configure a string de conexão no arquivo appsettings.json para seu banco MySQL:"
    - |
      ConnectionStrings:
        DefaultConnection: "server=localhost;port=3306;database=licitacoesdb;user=root;password=SuaSenha"
    - "Restaure os pacotes e crie o banco:"
    - 'dotnet restore'
    - 'dotnet ef database update'
    - "Rode a API:"
    - 'dotnet run --launch-profile http'
    - "A API estará disponível em http://localhost:5220."
    - "Opcional: Acesse a documentação Swagger em http://localhost:5220/swagger."

  frontend:
    - "Abra outro terminal e entre na pasta do frontend:"
    - 'cd Cadastro-de-Licitacoes/licitacao-frontend'
    - "Instale as dependências:"
    - 'npm install'
    - "Inicie o frontend:"
    - 'npm start'
    - "A aplicação abrirá em http://localhost:3000 e estará integrada com o backend."

consideracoes_finais:
  - "Para desenvolvimento local, o backend está configurado para rodar sem HTTPS para evitar problemas com certificados autoassinados."
  - "O CORS está configurado para liberar chamadas do frontend."
  - "Teste os endpoints via Swagger ou Postman se necessário."
  - "A aplicação é simples e pode ser expandida com autenticação, melhorias na interface e mais funcionalidades conforme o projeto evoluir."

license: |
  Eu, <Julia Vitória Freire Silva>,
  Declaro que todo código contido neste repositório é de minha autoria e não contém conteúdo ilegal ou de terceiros sem autorização explícita.
  Também declaro que o Portal de Compras Públicas pode utilizar o conteúdo deste repositório livremente.
