use cad_usuario;

create table tb_produto 
(
	codProduto int primary key auto_increment not null,
    descricao varchar(50) not null,
    
);
create table tb_procedimentos
(
	codigoProduto int primary key auto_increment not null,
    nome_teste varchar(50) not null,
    unidade_medida varchar(15),
    especificado_max varchar(10),
    especificado_min varchar(15),
	constraint foreign key (codigoProduto) references tb_produto(codProduto)
    on delete cascade 
    on update cascade
);
ALTER TABLE tb_procedimentos ADD constraint foreign key (descricao) references tb_produto(descricao);
ALTER TABLE tb_procedimentos DROP COLUMN codProduto;
select *from tb_produto;
drop tables tb_procedimentos;
show tables;