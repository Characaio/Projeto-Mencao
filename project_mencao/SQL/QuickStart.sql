# database ProjetoMencao;
create database ProjetoMencao;

use ProjetoMencao;

create table Alunos(
	AlunoId integer primary key auto_increment,
    nome varchar(255)
);

create table Notas(
	NotaId integer primary key auto_increment,
    NotaFinal decimal(5,2),
    NotaProva decimal(5,2),
    NotaAtividade decimal(5,2),
    NotaComportamento decimal(5,2),
    AlunoId integer,
    foreign key (AlunoId) references Alunos(AlunoId)
);

create table Usuarios(
	UsuarioId integer primary key auto_increment,
    
    Nome varchar(255),
    Telefone varchar(11),#(xx) xxxxx-xxxx
    Email varchar(255),
    Senha varchar(255),
	MateriaLecionada varchar(255)
);
