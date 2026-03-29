drop database ProjetoMencaoCaio;
create database ProjetoMencaoCaio;

use ProjetoMencaoCaio;

create table Alunos(
	AlunoId integer primary key auto_increment,
    Nome varchar(255),
    Turma varchar(4)
    
);

create table Notas(
	NotaId integer primary key auto_increment,
    AlunoId integer,
    Bimestre integer,#Bimestre 5 é a nota Final, os outros representam os Bimestres Corretos
    NotaFinal decimal(5,2),
    NotaProva decimal(5,2),
    NotaAtividade decimal(5,2),
    NotaComportamento decimal(5,2),
    foreign key (AlunoId) references Alunos(AlunoId)
);

create table Usuarios(
	UsuarioId integer primary key auto_increment,
    
    Nome varchar(255),
    Telefone varchar(16),#(xx) xxxxx-xxxx
    Email varchar(255),
    Senha varchar(255),
	MateriaLecionada varchar(255)
);

create table Produtos(
	ProdutoId integer primary key auto_increment,
    Nome varchar(255),
    Valor decimal (10,2),
    Descricao text,
    Tipo varchar(255),
    Marca varchar(255)
);

create table Pedidos(
	PedidoId integer primary key auto_increment,
    UsuarioId integer,
    ProdutoId integer,
    ValorDaCompra decimal(10,2),
    Quantidade integer,
    DataDaCompra timestamp default current_timestamp,
    foreign key (UsuarioId) references Usuarios(UsuarioId),
    foreign key (ProdutoId) references Produtos(ProdutoId)
);