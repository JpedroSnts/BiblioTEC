DROP SCHEMA IF EXISTS BiblioTec;
CREATE SCHEMA BiblioTec;
USE BiblioTec;

DROP TABLE IF EXISTS editora;

CREATE TABLE  editora 
(
  cd_editora INT,
  nm_editora VARCHAR(200),
  CONSTRAINT pk_editora PRIMARY KEY (cd_editora) 
);

CREATE TABLE  livro 
(
  cd_livro INT,
  cd_ISBN VARCHAR(200),
  nm_livro TEXT,
  aa_edicao INT,
  ds_sinopse TEXT,
  cd_editora INT,
  img_capa longblob,
  CONSTRAINT pk_livro PRIMARY KEY (cd_livro),
  CONSTRAINT fk_livro_editora1 FOREIGN KEY (cd_editora)
    REFERENCES editora (cd_editora)
);

CREATE TABLE  autor 
(
  cd_autor INT,
  nm_autor VARCHAR(200),
  CONSTRAINT pk_autor PRIMARY KEY (cd_autor) 
);

CREATE TABLE  categoria 
(
  cd_categoria INT,
  nm_categoria VARCHAR(200),
  CONSTRAINT pk_categoria PRIMARY KEY (cd_categoria) 
);

CREATE TABLE  livro_categoria 
(
  cd_livro INT,
  cd_categoria INT,
  CONSTRAINT pk_livro_cat PRIMARY KEY (cd_livro, cd_categoria) ,
  CONSTRAINT fk_livro_categoria_livro1 FOREIGN KEY (cd_livro)
    REFERENCES livro (cd_livro),
  CONSTRAINT fk_livro_categoria_categoria1 FOREIGN KEY (cd_categoria)
    REFERENCES categoria (cd_categoria)
);

CREATE TABLE  localizacao 
(
  cd_localizacao INT,
  nm_localizacao VARCHAR(255),
  CONSTRAINT pk_localizacao PRIMARY KEY (cd_localizacao)
);

CREATE TABLE  exemplar 
(
  cd_exemplar INT,
  cd_livro INT,
  ic_fixo TINYINT(1),
  cd_localizacao INT,
  cd_rfId VARCHAR(255),
  CONSTRAINT pk_exemplar PRIMARY KEY (cd_exemplar, cd_livro),
  CONSTRAINT fk_exemplar_livro1 FOREIGN KEY (cd_livro)
    REFERENCES livro (cd_livro),
  CONSTRAINT fk_exemplar_localizacao1 FOREIGN KEY (cd_localizacao)
    REFERENCES localizacao (cd_localizacao)
);


CREATE TABLE  tipo_usuario 
(
  cd_tipo_usuario INT,
  nm_tipo_usuario VARCHAR(45),
  CONSTRAINT pk_tipo_usuario PRIMARY KEY (cd_tipo_usuario)
);

CREATE TABLE  usuario 
(
  nm_login VARCHAR(200),
  nm_usuario VARCHAR(255),
  nm_senha VARCHAR(64),
  ic_bloqueado TINYINT(1),
  dt_bloqueio DATE,
  cd_tipo_usuario INT,
  CONSTRAINT pk_usuario PRIMARY KEY (nm_login),
  CONSTRAINT fk_usuario_tipo_usuario1 FOREIGN KEY (cd_tipo_usuario)
    REFERENCES tipo_usuario (cd_tipo_usuario)
);

CREATE TABLE  tipo_emprestimo 
(
  cd_tipo_emprestimo INT,
  nm_tipo_emprestimo VARCHAR(45),
  CONSTRAINT pk_tipo_emp PRIMARY KEY (cd_tipo_emprestimo)
);

CREATE TABLE  emprestimo 
(
  nm_login VARCHAR(200),
  cd_exemplar INT,
  cd_livro INT,
  dt_emprestimo DATE,
  hr_emprestimo TIME,
  dt_devolucao_estimada DATE,
  dt_devolucao DATE,
  cd_tipo_emprestimo INT,
  CONSTRAINT pk_emp PRIMARY KEY (nm_login, cd_exemplar, cd_livro, dt_emprestimo),
  CONSTRAINT fk_usuario_exemplar_usuario1 FOREIGN KEY (nm_login)
    REFERENCES usuario (nm_login),
  CONSTRAINT fk_usuario_exemplar_exemplar1 FOREIGN KEY (cd_exemplar , cd_livro)
    REFERENCES exemplar (cd_exemplar , cd_livro),
  CONSTRAINT fk_emprestimo_tipo_emprestimo1 FOREIGN KEY (cd_tipo_emprestimo)
    REFERENCES tipo_emprestimo (cd_tipo_emprestimo)
);

CREATE TABLE  tipo_ocorrencia 
(
  cd_tipo_ocorrencia INT,
  nm_tipo_ocorrencia VARCHAR(45),
  CONSTRAINT pk_tipo_ocorrencia PRIMARY KEY (cd_tipo_ocorrencia)
);

CREATE TABLE  ocorrencia 
(
  nm_login VARCHAR(200),
  cd_exemplar INT,
  cd_livro INT,
  dt_emprestimo DATE,
  cd_tipo_ocorrencia INT,
  ds_ocorrencia TEXT,
  CONSTRAINT pk_ocorrencia PRIMARY KEY (nm_login, cd_exemplar, cd_livro, dt_emprestimo, cd_tipo_ocorrencia) ,
  CONSTRAINT fk_emprestimo_tipo_ocorrencia_emprestimo1 FOREIGN KEY (nm_login , cd_exemplar , cd_livro , dt_emprestimo)
    REFERENCES emprestimo (nm_login , cd_exemplar , cd_livro , dt_emprestimo),
  CONSTRAINT fk_emprestimo_tipo_ocorrencia_tipo_ocorrencia1 FOREIGN KEY (cd_tipo_ocorrencia)
    REFERENCES tipo_ocorrencia (cd_tipo_ocorrencia)
);

CREATE TABLE  computador 
(
  dt_uso_computador DATE,
  nm_login VARCHAR(200),
  CONSTRAINT pk_computador PRIMARY KEY (dt_uso_computador, nm_login) ,
  CONSTRAINT fk_computador_usuario1 FOREIGN KEY (nm_login)
    REFERENCES usuario (nm_login)
);

CREATE TABLE  livro_autor 
(
  cd_livro INT,
  cd_autor INT,
  CONSTRAINT pk_livro_autor PRIMARY KEY (cd_livro, cd_autor),
  CONSTRAINT fk_livro_autor_livro1 FOREIGN KEY (cd_livro)
    REFERENCES livro (cd_livro),
  CONSTRAINT fk_livro_autor_autor1 FOREIGN KEY (cd_autor)
    REFERENCES autor (cd_autor)
);

INSERT INTO editora (cd_editora, nm_editora) VALUES (1, 'Editora FTD');
INSERT INTO livro (cd_livro, cd_ISBN, nm_livro, aa_edicao, ds_sinopse, cd_editora, img_capa) VALUES (1, '8532223796', 'Matematica - V. 3 - Geometria Analitica, Numeros Complexos E Polinomio', 2021, 'Livro de matemática. OSB: Bem legaaaal', 1, LOAD_FILE('E:/matematica.jpg'));
INSERT INTO autor (cd_autor, nm_autor) VALUES (1, 'Regina Giovanni');
INSERT INTO autor (cd_autor, nm_autor) VALUES (2, 'Jose Ruy Bonjorno');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (1, 'Literatura');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (2, 'Biografia');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (3, 'Educação');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (4, 'Filosofia');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (5, 'Química');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (6, 'Geografia');
INSERT INTO categoria (cd_categoria, nm_categoria) VALUES (7, 'Matemática');
INSERT INTO livro_categoria (cd_livro, cd_categoria) VALUES (1, 7);
INSERT INTO localizacao (cd_localizacao, nm_localizacao) VALUES (1, 'E02C01P01 - Estante 02 - Coluna 01 - Prateleira 01');
INSERT INTO localizacao (cd_localizacao, nm_localizacao) VALUES (2, 'E01C03P01 - Estante 01 - Coluna 03 - Prateleira 01');
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao, cd_rfid) VALUES (1, 1, 1, 1, 'HT:K3:82:AH');
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao, cd_rfid) VALUES (2, 1, 0, 1, 'JS:I2:3J:SK');
INSERT INTO tipo_usuario (cd_tipo_usuario, nm_tipo_usuario) VALUES (1, 'Admin');
INSERT INTO tipo_usuario (cd_tipo_usuario, nm_tipo_usuario) VALUES (2, 'Operador');
INSERT INTO tipo_usuario (cd_tipo_usuario, nm_tipo_usuario) VALUES (3, 'Cliente');
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('admin', 'Administrador', '123', 0, NULL, 1);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('operador', 'Operador', '123', 0, NULL, 2);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('adalberto', 'Adalberto', '123', 0, NULL, 3);
INSERT INTO usuario (nm_login, nm_usuario, nm_senha, ic_bloqueado, dt_bloqueio, cd_tipo_usuario) VALUES ('12577', 'Frederico Arco e Flexa Machado Justo', '123', 1, NULL, 3);
INSERT INTO tipo_emprestimo (cd_tipo_emprestimo, nm_tipo_emprestimo) VALUES (1, 'Consulta');
INSERT INTO tipo_emprestimo (cd_tipo_emprestimo, nm_tipo_emprestimo) VALUES (2, 'Empréstimo');
INSERT INTO tipo_ocorrencia (cd_tipo_ocorrencia, nm_tipo_ocorrencia) VALUES (1, 'Devolução com leve dano');
INSERT INTO tipo_ocorrencia (cd_tipo_ocorrencia, nm_tipo_ocorrencia) VALUES (2, 'Devolução com grave dano');
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (1, 1);
INSERT INTO livro_autor (cd_livro, cd_autor) VALUES (1, 2);
INSERT INTO editora VALUES (2, 'Editora Arqueiro');
INSERT INTO autor VALUES (3, 'Douglas Adams');
INSERT INTO categoria VALUES (8, 'Aventura');
INSERT INTO categoria VALUES (9, 'Ação');
INSERT INTO livro VALUES (2,'9788599296578','O Guia do Mochileiro das Galáxias',1979,'Arthur Dent é um homem normal, que está tendo um péssimo dia. Após saber que sua casa está prestes a ser demolida, ele descobre que Ford Prefect, seu melhor amigo, é um extraterrestre. Para completar, fica sabendo que a Terra está perto de ser destruída. Sem saída, Arthur pega carona em uma nave espacial que está de passagem. Ele passa então a conhecer o universo, sendo que tudo o que precisa saber sobre sua nova vida está contido em um valioso livro: o Guia do Mochileiro das Galáxias.',2, LOAD_FILE('E:/o-guia-mochileiro-das-galaxias.jpg'));
INSERT INTO livro_categoria VALUES (2, 1);
INSERT INTO livro_categoria VALUES (2, 8);
INSERT INTO livro_categoria VALUES (2, 9);
INSERT INTO livro_autor VALUES (2, 3);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao, cd_rfid) VALUES (3, 2, 0, 2, 'SJ:83:S8:AS');

INSERT INTO editora VALUES (3, 'Ballantine Books');
INSERT INTO autor VALUES (4, 'Alex Haley');
INSERT INTO autor VALUES (5, 'MALCOLM X');
INSERT INTO livro VALUES (3,'0345350685','The Autobiography of Malcolm X: As Told to Alex Haley Edição',1987,'In the searing pages of this classic autobiography, originally published in 1964, Malcolm X, the Muslim leader, firebrand, and anti-integrationist, tells the extraordinary story of his life and the growth of the Black Muslim movement. His fascinating perspective on the lies and limitations of the American Dream, and the inherent racism in a society that denies its nonwhite citizens the opportunity to dream, gives extraordinary insight into the most urgent issues of our own time. The Autobiography of Malcolm X stands as the definitive statement of a movement and a man whose work was never completed but whose message is timeless. It is essential reading for anyone who wants to understand America.',3, LOAD_FILE('E:/malcolm-x.jpg'));
INSERT INTO livro_categoria VALUES (3, 2);
INSERT INTO livro_autor VALUES (3, 4);
INSERT INTO livro_autor VALUES (3, 5);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao, cd_rfid) VALUES (4, 3, 0, 2, 'KJ:F3:YD:WQ');

INSERT INTO editora VALUES (5, 'Nova Fronteira');
INSERT INTO autor VALUES (8, 'Adam Smith');
INSERT INTO livro VALUES (5,'8520939074','A riqueza das nações',2017,'A riqueza das nações é considerada a obra fundadora da ciência econômica. Escrito no século XVIII, o clássico de Adam Smith gerou uma série de mudanças nas políticas econômicas. O livro aborda temas como o acúmulo de riqueza, divisão do trabalho, sistemas de economia, e até hoje é grande referência entre os estudiosos de todo o mundo. A edição integral impressiona pelo conteúdo e principalmente por sua extensão. Esta versão condensada traz uma criteriosa seleção dos cinco livros originais e mantém a essência da obra-prima de Smith.',5, LOAD_FILE('E:/a-riqueza-das-nacoes.jpg'));
INSERT INTO categoria VALUES (11, 'Economia');
INSERT INTO livro_categoria VALUES (5, 11);
INSERT INTO livro_autor VALUES (5, 8);
INSERT INTO exemplar (cd_exemplar, cd_livro, ic_fixo, cd_localizacao, cd_rfid) VALUES (6, 5, 0, 2, 'PY:JS:01:42');

INSERT INTO emprestimo VALUES ('admin', 3, 2, CURDATE(), CURTIME(), CURDATE() + INTERVAL 15 DAY, NULL, 2);
INSERT INTO emprestimo VALUES ('operador', 3, 2, "2021-09-02", CURTIME(), "2021-09-09", "2021-09-09", 2);
INSERT INTO emprestimo VALUES ('12577', 2, 1, "2022-02-10", CURTIME(), "2022-02-17", "2022-02-15", 2);