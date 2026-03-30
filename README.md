<h1>Objetivo Do Projeto</h1>

<p>
  Esse projeto foi criado com base nos seguintes requisitos passado pelo Professor: <br>
</p>

<br>

<h2>Descrição do Sistema</h2>

<p>
  O projeto <b>project_mencao</b> consiste em uma aplicação desktop desenvolvida em C# utilizando Windows Forms, composta por três telas principais.
</p>

<ul>
  <li>
    <b>Tela de Login:</b> responsável pela autenticação do usuário. O acesso às demais funcionalidades do sistema é liberado após a validação de login e senha.
  </li>

  <li>
    <b>Tela de Cálculo de Médias:</b> permite o registro das notas dos alunos e realiza o cálculo da média final. 
    A interface possui as seguintes ações:
    <ul>
      <li><b>Calcular:</b> realiza o cálculo da média</li>
      <li><b>Limpar:</b> limpa os campos preenchidos</li>
      <li><b>Sair:</b> encerra ou retorna da tela</li>
    </ul>
  </li>

  <li>
    <b>Tela de Produtos:</b> permite o cadastro de produtos com cálculo de frete baseado no estado de entrega.
    O sistema considera os seguintes valores:
    <ul>
      <li>São Paulo: R$ 3,00</li>
      <li>Rio de Janeiro: R$ 5,00</li>
      <li>Bahia: R$ 10,00</li>
      <li>Demais estados: R$ 15,00</li>
    </ul>
    Além disso, a tela permite a exibição da imagem do produto cadastrado.
  </li>
</ul>
</p>
<hr>

<p>
  Esse projeto foi proposto pelo Professor Anderson na aula de Desenvolvimento de Sistemas no Segundo Ano do MTEC em Desenvolvimento de Sistemas
  O professor orientou que os requisitos podiam ser expandidos com base no interesse do aluno, Isso resultou nas seguintes expansões:
</p>

<ul>
  <li>Implementação de tela de registro de usuários</li>
  <li>Criação de uma tela principal (Hub) para navegação</li>
  <li>Implementação de histórico de compras</li>
  <li>Cadastro de produtos</li>
  <li>Cadastro de alunos</li>
  <li>Implementação de sistema de pedidos</li>
  <li>Integração com banco de dados real</li>
  <li>Expansão do sistema de cálculo de notas</li>
  <li>Melhoria no sistema de compra de produtos</li>
  <li>Adoção de arquitetura em camadas (Layered Architecture), Separation of Concerns (SoC) e organização inspirada em DDD</li>
</ul>
<hr>

<h2>Estrutura Interna</h2>

<ul>
  <li><b>Models:</b> Representação das entidades</li>
  <li><b>Repositories:</b> Acesso ao banco de dados</li>
  <li><b>SQL</b> Contem Scrips SQL sobre o projeto</li>
  <li><b>Forms:</b> Interface do usuário</li>
  <li><b>Utilidades:</b> Constantes e Enums</li>
</ul>
<hr>

<h2>Decisões de Design</h2>

<ul>
  <li>Separação entre logica do form e logica do Back-End</li>
  <li>Uso de repositories para abstrair e facilitar o acesso aos dados</li>
  <li>Implementação da regra de negocio no codigo do Form pois é uma regra simples</li>
</ul>
<hr>

<h2>Regras de negocio</h2>

<ul>
  <li>Notas devem estar entre 0 e 10</li>
  <li>Frete Varia Conforme o estado</li>
  <li>Login exige usuario e senha validos</li>
</ul>

<h2>Possiveis melhorias</h2>

<ul>
  <li>Implementação de uma segurança mais Robusta</li>
  <li>Criação de uma API com base nos repositorios para uma possivel implementação multi-plataforma</li>
  <li>Melhoria na interface e experiencia do usuario</li>
</ul>
<hr>

<h2>Informações Tecnicas</h2>

<ul>
  <li>Linguagem : <b>C#</b></li>
  <li>Banco de dados : <b>MySQL</b></li>
  <li>Framework  : <b>.NET (Windows Forms)</b></li>
  <li>Arquitetura: <b>Layered Architecture, SoC(Separation of Concerns), Inspiração na filosofia de DDD</b></li>
</ul>
<hr>

<h2>Como Executar o Projeto</h2>

<ol>
  <li>Clonar o repositório</li>
  <li>Abrir o projeto no Visual Studio</li>
  <li>Configurar a conexão com o banco de dados MySQL</li>
  <li>A conexão do banco de dados esta na classe DataBaseConnector, mude o campo de password para a senha do MySQL de sua maquina</li>
  <li>Rodar o script quickstart.sql  para criar o banco de dados e tabelas
  <li>Executar o projeto</li>
</ol>
