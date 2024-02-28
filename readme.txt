Versões

.NET 5.0 SDK (v 5.0.408)
Angular CLI: 12.2.18
Node: 14.17.6
NPM: versão - 8.3.0

Para rodar o projeto no visual studio code:
No terminal, navegue até a pasta ProEventos-App (que está dentro de 'Front')  e inicie com o comando ng serve -o

Antes de rodar o back é necessário instalar o Entity framework:
No terminal, navegue até a pasta 'src' que fica dentro de 'back' e aplique o comando:
dotnet tool install --global dotnet-ef --version 5.0.2

ainda dentro de src, no terminal, execute o comando: dotnet ef database update -s ProEventos.API
Com esse comando será criado um banco de dados SQLite, dentro da pasta ProEventos.API

Agora, ainda no terminal e ainda dentro de src, execute o seguinte comando para rodar o projeto:
dotnet watch run -p ProEventos.API

Provavemente assim que compilar, vai abrir em uma aba o swagger.
Então vc já pode voltar pra pagina inicial da Pro Eventos e registrar um usuário.
Irá registrar e já estará logado.
