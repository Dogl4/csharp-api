### Dia dois

Testes:
- Unix - library de testes
- FluentAssertions - library para ajudar a escrever mais entendivel ao humano.

#### Comandos
```bash
# criar um projeto console
$ dotnet new console -o <nome_da_pasta>

# criar um projeto teste
$ dotnet new xunit -o <nome_da_pasta>.Test

# adicionar a dependencia, exemplo:
$ dotnet add package FluentAssertions --version 6.5.1

# adicionar referência
$ dotnet add reference ../<nome_da_pasta>/<nome_do_arquivo>.csproj

# entre na pasta que criou
$ cd <nome_da_pasta>

# instalar depencendias
$ dotnet restore

# rodar teste, na pasta do projeto de teste
$ dotnet test
```